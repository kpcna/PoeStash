using Newtonsoft.Json.Linq;
using PoeStash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace PoeStash.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            List<Item> listItems = new List<Item>();
            using (WebClient wc = new WebClient())
            {
                //http://www.pathofexile.com/api/public-stash-tabs?id=
                var json = wc.DownloadString("http://www.pathofexile.com/api/public-stash-tabs");
                //JToken Stashes = o.Last;
                JObject jobject = JObject.Parse(json);
                JToken PreviousNextId = null;
                JToken CurrentNextId = jobject.First;

                while (PreviousNextId != CurrentNextId)
                { 
                    dynamic deserialized = JsonConvert.DeserializeObject(jobject.ToString());               

                    foreach (var data in deserialized.stashes)
                    {
                        Item item1 = new Item();
                        item1.accountName = data.accountName;
                        item1.stashType = data.stashType;
                        item1.stash = data.stash;
                        item1.lastCharacterName = data.lastCharacterName;
                        listItems.Add(item1);
                    }

                    json = wc.DownloadString("http://www.pathofexile.com/api/public-stash-tabs?id=" + CurrentNextId.First);
                    jobject = JObject.Parse(json);
                    PreviousNextId = CurrentNextId;
                    CurrentNextId = jobject.First;
                }
            }        

            return View(listItems);
        }
    }
}
