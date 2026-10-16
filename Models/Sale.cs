using System;

namespace RetailInventoryApp.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; } = "";

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double TotalAmount { get; set; }

        public DateTime SaleDate { get; set; }
    }
}