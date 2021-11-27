using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_VEZBA1.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemCategory { get; set; }

        public bool ItemDiscount { get; set; }

        public ShopItem()
        {

        }

    }
}