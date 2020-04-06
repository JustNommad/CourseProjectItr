using CourseProjectItr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Korzh.EasyQuery.Linq;

namespace CourseProjectItr.Controllers
{
    public class SearchController : Controller
    {
        ApplicationContext db;
        public SearchController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<IActionResult> Search(string searchText)
        {
            if(!string.IsNullOrEmpty(searchText))
            {
                List<Items> items = new List<Items>();
                var itemList = db.Items.FullTextSearchQuery(searchText);
                foreach (var i in itemList)
                {
                    items.Add(i);
                }
                if(items.Count == 0)
                {
                    var collections = db.Collections.FullTextSearchQuery(searchText);
                    foreach (var c in collections)
                    {
                        var itemsID = db.ItemsOfCollections.Where(i => i.CollectionId == c.Id).Select(it => it.Id).ToList();
                        foreach (var i in itemsID)
                        {
                            items.Add(await db.Items.FirstOrDefaultAsync(c => c.Id == i));
                        }
                    }
                    return View(items);
                }
                return View(items);
            }
            return View();
        }
    }
}
