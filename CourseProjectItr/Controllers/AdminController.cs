using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectItr.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CourseProjectItr.Controllers
{
    public class AdminController : Controller
    {
        public ApplicationContext db;
        private readonly UserManager<User> _userManager;
        public AdminController(ApplicationContext context, UserManager<User> userManager)
        {
            db = context;
            _userManager = userManager;
        }
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            User user = new User
            {
                UserName = "justnommad@gmail.com",
                NickName = "JustNomad",
                FirstName = "Maksim",
                LastName = "Kruk",
                Email = "justnommad@gmail.com",
                Age = 23,
                LastLogin = DateTime.Now,
                RegisterDate = DateTime.Now
            };
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("author") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("author"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await roleManager.FindByNameAsync("blocked") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("blocked"));
            }
            if (await userManager.FindByNameAsync(user.Email) == null)
            {
                IdentityResult result = await userManager.CreateAsync(user, "Qaz123#");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "author");
                }
            }
        }
        [HttpPost]
        public async Task<IActionResult> Block([FromBody]dynamic id)
        {
            if (ModelState.IsValid)
            {
                List<string> checkId = JsonConvert.DeserializeObject<List<string>>(id.ToString());
                User user = await _userManager.FindByIdAsync(checkId[0]);
                if (user != null)
                {
                    await _userManager.RemoveFromRoleAsync(user, "user");
                    await _userManager.AddToRoleAsync(user, "blocked");
                    await _userManager.UpdateSecurityStampAsync(user);

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("AdminList", "User");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return RedirectToAction("AdminList", "User");
        }

        [HttpPost]
        public async Task<IActionResult> Unblock([FromBody]dynamic id)
        {
            if (ModelState.IsValid)
            {
                List<string> checkId = JsonConvert.DeserializeObject<List<string>>(id.ToString());
                User user = await _userManager.FindByIdAsync(checkId[0]);
                if (user != null)
                {
                    await _userManager.RemoveFromRoleAsync(user, "blocked");
                    await _userManager.AddToRoleAsync(user, "user");
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("AdminList", "User");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return RedirectToAction("AdminList", "User");
        }
        [HttpPost]
        public async Task<IActionResult> AdminRole([FromBody]dynamic id)
        {
            if (ModelState.IsValid)
            {
                List<string> checkId = JsonConvert.DeserializeObject<List<string>>(id.ToString());
                User user = await _userManager.FindByIdAsync(checkId[0]);
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, "admin");
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("AdminList", "User");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return RedirectToAction("AdminList", "User");
        }
    }
}
