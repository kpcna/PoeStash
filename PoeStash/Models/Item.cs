using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoeStash.Models
{
    public class Item
    {
        public string accountName { get; set; }
        public string lastCharacterName { get; set; }
        public string stash { get; set; }
        public string stashType { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public bool verified { get; set; }
        public string league { get; set; }
    }
}