using PoeStash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PoeStash.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.pathofexile.com/api/public-stash-tabs");
            }

            List<Item> listItems = new List<Item>();
            Item item1 = new Item();
            item1.name = "test1";
            item1.icon = "http://pathofexile.com";
            item1.league = "Perandus";
            listItems.Add(item1);

            Item item2 = new Item();
            item2.name = "test2";
            item2.icon = "http://poetrade.com";
            item2.league = "Taliman";
            listItems.Add(item2);

            return View(listItems);
        }
    }
}
