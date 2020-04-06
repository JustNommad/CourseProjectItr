using CourseProjectItr.Models;
using CourseProjectItr.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectItr.Controllers
{
    public class CollectionController : Controller
    {
        private ApplicationContext db;
        private readonly IStringLocalizer<CollectionController> _localizer;
        private readonly ICloudStorage _cloudStorage;
        private readonly UserManager<User> _userManager;
        public CollectionController(ApplicationContext context, ICloudStorage cloudStorage, IStringLocalizer<CollectionController> localizer, UserManager<User> userManager)
        {
            db = context;
            _cloudStorage = cloudStorage;
            _localizer = localizer;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Collection(string userID)
        {
            ViewBag.UserID = userID;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ItemList(string collectionId, string userID)
        {
            Collections collection = await db.Collections.FirstOrDefaultAsync(c => c.Id == collectionId);
            User user = await _userManager.FindByIdAsync(collection.UserId);
            ViewBag.Collection = collection;
            ViewBag.UserID = userID;
            ViewBag.Creator = user.UserName;
            var itemsID = db.ItemsOfCollections.Where(i => i.CollectionId == collectionId).Select(it => it.Id).ToList();
            List<Items> itemsList = new List<Items>();
            if (itemsID != null && itemsID.Count != 0)
            {
                foreach(var id in itemsID)
                {
                    itemsList.Add(await db.Items.FirstOrDefaultAsync(c => c.Id == id));
                }
                return View(itemsList);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var coll = db.Collections.ToList();
            return View(coll);
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "author, admin, user")]
        public async Task<IActionResult> Collection(CollectionViewModel model)
        {
                Collections collections = await db.Collections.FirstOrDefaultAsync(c => c.Name == model.Name);
                if(collections == null && model.UserId != null)
                {
                    collections = new Collections
                    {
                        UserId = model.UserId,
                        Name = model.Name,
                        Theme = model.Theme,
                        Review = model.Review,
                        One = model.One,
                        Second = model.Second,
                        Third = model.Third,
                        NumberOne = model.NumberOne,
                        NumberSecond = model.NumberSecond,
                        NumberThird = model.NumberThird,
                        OneText = model.OneText,
                        SecondText = model.SecondText,
                        ThirdText = model.ThirdText,
                        CheckBox1 = model.CheckBox1,
                        CheckBox2 = model.CheckBox2,
                        CheckBox3 = model.CheckBox3,
                        Time1 = model.Time1,
                        Time2 = model.Time2,
                        Time3 = model.Time3
                    };
                if(model.ImageFile != null)
                {
                    await UploadFile(model, collections);
                }
                    db.Collections.Add(collections);
                    await db.SaveChangesAsync();
                User user = await db.Users.FindAsync(model.UserId);
                    return RedirectToAction("Index", "User", new {user.UserName });
                }
            return View(model);
        }
        private async Task UploadFile(CollectionViewModel model, Collections collection)
        {
            string fileNameForStorage = FormFileName(model.Name, model.ImageFile.FileName);
            collection.ImageUrl = await _cloudStorage.UploadFileAsync(model.ImageFile, fileNameForStorage);
            collection.ImageStorageName = fileNameForStorage;
        }

        private static string FormFileName(string title, string fileName)
        {
            var fileExtension = Path.GetExtension(fileName);
            var fileNameForStorage = $"{title}-{DateTime.Now.ToString("yyyyMMddHHmmss")}{fileExtension}";
            return fileNameForStorage;
        }

        public async Task<IActionResult> Edit(string id, string userName)
        {
            Collections collection = await db.Collections.FindAsync(id);
            User user = await _userManager.FindByNameAsync(userName);

            if (collection == null)
            {
                return NotFound();
            }
            if(collection.UserId == user.Id)
            {
                EditCollectionViewModel model = new EditCollectionViewModel
                {
                    Id = collection.Id,
                    UserId = collection.UserId,
                    Review = collection.Review,
                    Name = collection.Name,
                    Theme = collection.Theme,
                    ImageUrl = collection.ImageUrl,
                    ImageStorageName = collection.ImageStorageName,
                    OneText = collection.OneText,
                    SecondText = collection.SecondText,
                    ThirdText = collection.ThirdText,
                    CheckBox1 = collection.CheckBox1,
                    CheckBox2 = collection.CheckBox2,
                    CheckBox3 = collection.CheckBox3,
                    Time1 = collection.Time1,
                    Time2 = collection.Time2,
                    Time3 = collection.Time3,
                    One = collection.One,
                    Second = collection.Second,
                    Third = collection.Third,
                    NumberOne = collection.NumberOne,
                    NumberSecond = collection.NumberSecond,
                    NumberThird = collection.NumberThird
                };
                return View(model);
            }
            else
            {
                ModelState.AddModelError("", "You cant edit this collection");
                return View();
            }
        }

        [HttpPost]
        [Authorize(Roles = "author, admin, user")]
        public async Task<IActionResult> Edit(EditCollectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Collections collection = await db.Collections.FirstOrDefaultAsync(c => c.Name == model.Name);
                if (collection != null)
                {
                    if (model.ImageFile != null)
                    {
                        if (collection.ImageStorageName != null)
                        {
                            await _cloudStorage.DeleteFileAsync(collection.ImageStorageName);
                        }

                        string fileNameForStorage = FormFileName(model.Name, model.ImageFile.FileName);
                        collection.ImageUrl = await _cloudStorage.UploadFileAsync(model.ImageFile, fileNameForStorage);
                        collection.ImageStorageName = fileNameForStorage;
                    }
                    collection.Review = model.Review;
                    collection.Name = model.Name;
                    collection.Theme = model.Theme;
                    collection.OneText = model.OneText;
                    collection.SecondText = model.SecondText;
                    collection.ThirdText = model.ThirdText;
                    collection.CheckBox1 = model.CheckBox1;
                    collection.CheckBox2 = model.CheckBox2;
                    collection.CheckBox3 = model.CheckBox3;
                    collection.Time1 = model.Time1;
                    collection.Time2 = model.Time2;
                    collection.Time3 = model.Time3;
                    collection.One = model.One;
                    collection.Second = model.Second;
                    collection.Third = model.Third;
                    collection.NumberOne = model.NumberOne;
                    collection.NumberSecond = model.NumberSecond;
                    collection.NumberThird = model.NumberThird;

                    db.Collections.Update(collection);
                    await db.SaveChangesAsync();
                    User user = await db.Users.FindAsync(collection.UserId);
                    return RedirectToAction("Index", "User", new { user.UserName });
                }
            }
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "author, admin, user")]
        public async Task<IActionResult> Delete(string collectionId, string userName)
        {
            Collections collection = await db.Collections.FindAsync(collectionId);

            if (collection != null)
            {
                var items = db.ItemsOfCollections.Where(i => i.CollectionId == collectionId).Select(i => i.Id).ToList();
                foreach(var i in items)
                {
                    Items item = await db.Items.FindAsync(i);
                    ItemsOfCollections ic = await db.ItemsOfCollections.FindAsync(i);
                    if (item != null && ic != null)
                    {
                        if (item.ImageStorageName != null)
                        {
                            await _cloudStorage.DeleteFileAsync(item.ImageStorageName);
                        }
                        db.Items.Remove(item);
                        db.ItemsOfCollections.Remove(ic);
                    }
                }
                if(collection.ImageStorageName != null)
                {
                    await _cloudStorage.DeleteFileAsync(collection.ImageStorageName);
                }
                db.Collections.Remove(collection);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index", "User", new { userName });
        }      
    }
}
