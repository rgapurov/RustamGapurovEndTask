﻿namespace RustamGapurovEndTask.AdminPanel.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int TagId { get; set; }
        public int CategoryId { get; set; }
    }
}
