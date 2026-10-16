using System;
using System.Collections.Generic;
using System.Text;

namespace RetailInventoryApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = "";

        public double Price { get; set; }

        public int StockQuantity { get; set; }
    }
}