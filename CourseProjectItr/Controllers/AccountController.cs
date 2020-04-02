using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseProjectItr.ViewModels; 
using CourseProjectItr.Models;
using System;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Security.Claims;

namespace CourseProjectItr.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> CheckEmail(string email)
        {
            User user = await _userManager.FindByEmailAsync(email);
            if (user != null)
                return Json(false);
            return Json(true);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Email = model.Email,
                    UserName = model.Email,
                    NickName = model.NickName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Age = model.Age,
                    LastLogin = DateTime.Now,
                    RegisterDate = DateTime.Now,
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                await _userManager.AddToRoleAsync(user, "user");
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Collection");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl)
        {
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByEmailAsync(model.Email);
                var roleIdentity = await _userManager.GetRolesAsync(user);
                foreach (var check in roleIdentity)
                {
                    if (check == "blocked")
                    {
                        ModelState.AddModelError("", "You are blocked!");
                        model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                        return View(model);
                    }
                }
                if (user != null)
                {
                    user.LastLogin = DateTime.Now;
                    await _userManager.UpdateAsync(user);
                }
                else
                {
                    ModelState.AddModelError("", "You are not registered!");
                    model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                    return View(model);
                }

                var result =
                    await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Collection");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Wrong login and (or) password");
                    model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                    return View(model);
                }
            }
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account",
                new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null )
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            LoginViewModel loginViewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if(remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external prvider: {remoteError}");
                return View("Login", loginViewModel);
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if(info == null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external prvider: {remoteError}");
                return View("Login", loginViewModel);
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if(signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if(email != null)
                {
                    var user = await _userManager.FindByNameAsync(email);

                    if(user == null)
                    {
                        user = new User
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                            RegisterDate = DateTime.Now,
                        };
                        await _userManager.CreateAsync(user);
                        await _userManager.AddToRoleAsync(user, "user");                        
                    }

                    var roleIdentity = await _userManager.GetRolesAsync(user);
                    foreach (var check in roleIdentity)
                    {
                        if (check == "blocked")
                        {
                            ModelState.AddModelError("", "You are blocked!");
                            return View();
                        }
                    }
                    user.LastLogin = DateTime.Now;

                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user != null)
            {
                await _userManager.UpdateAsync(user);
                await _signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", "Collection");
        }

        [HttpPost]
        public async Task<ActionResult> Delete([FromBody]dynamic id)
        {
            List<string> checkId = JsonConvert.DeserializeObject<List<string>>(id.ToString());
            User user = await _userManager.FindByIdAsync(checkId[0]);
            if (user != null && user.Email == User.Identity.Name)
            {
                await _userManager.DeleteAsync(user);
                await _signInManager.SignOutAsync();
            }
            else if (user != null)
            {
                await _userManager.DeleteAsync(user);
                await _userManager.UpdateSecurityStampAsync(user);
            }
            return RedirectToAction("AdminList", "User");
        }
    }
}