using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoeStash.Models
{
    public class Item
    {
        public string name { get; set; }
        public string icon { get; set; }
        public bool verified { get; set; }
        public string league { get; set; }
    }

    public class ItemsList
    {
        public List<Item> Items { get; set; }
    }
}