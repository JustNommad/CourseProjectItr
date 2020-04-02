using CourseProjectItr.Models;
using CourseProjectItr.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace CourseProjectItr.Controllers
{
    public class ItemController : Controller
    {
        private ApplicationContext db;
        private readonly ICloudStorage _cloudStorage;
        public ItemController(ApplicationContext context, ICloudStorage cloudStorage)
        {
            db = context;
            _cloudStorage = cloudStorage;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string itemID)
        {
            Items item = await db.Items.FirstOrDefaultAsync(i => i.Id == itemID);
            List<Comments> comments = db.Comments.Where(c => c.ItemId == itemID).OrderBy(c => c.Number).ToList();
            if(comments != null)
            {

                ViewBag.Comments = comments;
            }
            Likes likes = await db.Likes.FirstOrDefaultAsync(l => l.Id == itemID);
            ViewBag.Likes = likes.Like;
            return View(item);
        }
        [HttpGet]
        public IActionResult Create(string collectionId, string userID)
        {
            ViewBag.Message = collectionId;
            ViewBag.UserID = userID;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "author, admin, user")]
        public async Task<IActionResult> Create(ItemViewModel model)
        {
            Items item = await db.Items.FirstOrDefaultAsync(i => i.Name == model.Name);
            if (item == null)
            {
                item = new Items
                {
                    UserId = model.UserId,
                    CollectionId = model.CollectionId,
                    Name = model.Name,
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
                db.Items.Add(item);
                if (model.ImageFile != null)
                {
                    await UploadFile(model, item);
                }

                ItemsOfCollections itCol = new ItemsOfCollections { Id = item.Id, CollectionId = model.CollectionId };
                Likes like = new Likes { Id = item.Id, Like = 0 };

                db.Likes.Add(like);
                db.ItemsOfCollections.Add(itCol);
                await db.SaveChangesAsync();
                return RedirectToAction("ItemList", "Collection", new {model.CollectionId, model.UserId });
            }

            return View(model);
        }
        [HttpGet]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "author, admin, user")]
        public async Task<IActionResult> Delete(string itemId)
        {
            Items item = await db.Items.FindAsync(itemId);
            ItemsOfCollections ic = await db.ItemsOfCollections.FindAsync(itemId);
            if(item != null)
            {
                if(item.ImageStorageName != null)
                {
                    await _cloudStorage.DeleteFileAsync(item.ImageStorageName);
                }
                db.Items.Remove(item);
                db.ItemsOfCollections.Remove(ic);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("ItemList", "Collection");
        }
        public async Task<IActionResult> Edit(string id)
        {
            Items item = await db.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            EditItemViewModel model = new EditItemViewModel
            {
                Id = item.Id,
                CollectionId = item.CollectionId,
                UserId = item.Id,
                Review = item.Review,
                Name = item.Name,
                ImageUrl = item.ImageUrl,
                ImageStorageName = item.ImageStorageName,
                OneText = item.OneText,
                SecondText = item.SecondText,
                ThirdText = item.ThirdText,
                CheckBox1 = item.CheckBox1,
                CheckBox2 = item.CheckBox2,
                CheckBox3 = item.CheckBox3,
                Time1 = item.Time1,
                Time2 = item.Time2,
                Time3 = item.Time3,
                One = item.One,
                Second = item.Second,
                Third = item.Third,
                NumberOne = item.NumberOne,
                NumberSecond = item.NumberSecond,
                NumberThird = item.NumberThird
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                Items item = await db.Items.FirstOrDefaultAsync(c => c.Name == model.Name);
                if (item != null)
                {
                    if(model.ImageFile != null)
                    {
                        if(item.ImageStorageName != null)
                        {
                            await _cloudStorage.DeleteFileAsync(item.ImageStorageName);
                        }

                        string fileNameForStorage = FormFileName(model.Name, model.ImageFile.FileName);
                        item.ImageUrl = await _cloudStorage.UploadFileAsync(model.ImageFile, fileNameForStorage);
                        item.ImageStorageName = fileNameForStorage;
                    }

                    item.Review = model.Review;
                    item.Name = model.Name;
                    item.OneText = model.OneText;
                    item.SecondText = model.SecondText;
                    item.ThirdText = model.ThirdText;
                    item.CheckBox1 = model.CheckBox1;
                    item.CheckBox2 = model.CheckBox2;
                    item.CheckBox3 = model.CheckBox3;
                    item.Time1 = model.Time1;
                    item.Time2 = model.Time2;
                    item.Time3 = model.Time3;
                    item.One = model.One;
                    item.Second = model.Second;
                    item.Third = model.Third;
                    item.NumberOne = model.NumberOne;
                    item.NumberSecond = model.NumberSecond;
                    item.NumberThird = model.NumberThird;

                    db.Items.Update(item);
                    await db.SaveChangesAsync();
                    return RedirectToAction("ItemList", "Collection", new { item.CollectionId, item.UserId });
                }
            }
            return View(model);
        }
        private async Task UploadFile(ItemViewModel model, Items item)
        {
            string fileNameForStorage = FormFileName(model.Name, model.ImageFile.FileName);
            item.ImageUrl = await _cloudStorage.UploadFileAsync(model.ImageFile, fileNameForStorage);
            item.ImageStorageName = fileNameForStorage;
        }

        private static string FormFileName(string title, string fileName)
        {
            var fileExtension = Path.GetExtension(fileName);
            var fileNameForStorage = $"{title}-{DateTime.Now.ToString("yyyyMMddHHmmss")}{fileExtension}";
            return fileNameForStorage;
        }
    }
}
