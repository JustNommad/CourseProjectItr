using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectItr.Models;
using CourseProjectItr.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CourseProjectItr.Controllers
{
    public class UserController : Controller
    {
        UserManager<User> _userManager;
        ApplicationContext db;

        public UserController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            db = context;
        }
        [HttpGet]
        [Authorize(Roles = "author, admin")]
        public IActionResult AdminList()
        {
            return View(_userManager.Users.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Index(string userName)
        {
            if (userName != null)
            {
                User user = await _userManager.FindByNameAsync(userName);
                if(user != null)
                {
                    var roleIdentity = await _userManager.GetRolesAsync(user);
                    ViewBag.Role = roleIdentity[0];
                    ViewBag.Collection = db.Collections.Where(c => c.UserId == user.Id).ToList();
                }
                return View(user);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public async Task<IActionResult> Edit(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            EditUserViewModel model = new EditUserViewModel { Id = user.Id, Email = user.Email, Age = user.Age, FirstName = user.FirstName, LastName = user.LastName, NickName = user.NickName };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.Age = model.Age;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.NickName = model.NickName;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "User", new { user.UserName });
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
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult<Likes>> Like([FromBody]LikeViewModel model)
        {
            Likes like = await db.Likes.FindAsync(model.ItemID);
            if (like != null && model.Choise == "true")
            {
                like.Like++;
                db.Likes.Update(like);
                await db.SaveChangesAsync();
                return Ok(like);
            }
            else if (like != null && model.Choise == "false")
            {
                like.Like--;
                db.Likes.Update(like);
                await db.SaveChangesAsync();
                return Ok(like);
            }
            return null;
        }
        [HttpPost]
        public async Task<ActionResult<Comments>> Comment([FromBody]CommentViewModel model)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName);
            Items item = await db.Items.FirstOrDefaultAsync(i => i.Id == model.ItemID);
            List<Comments> count = db.Comments.Where(c => c.ItemId == model.ItemID).ToList();
            if(user != null && item != null)
            {
                Comments comment = new Comments { Comment = model.Comment, ItemId = model.ItemID, UserId = user.Id, UserName = user.NickName, Number = count.Count() };
                db.Comments.Add(comment);
                await db.SaveChangesAsync();
                return Ok(comment);
            }
            return null;
        }
    }
}
