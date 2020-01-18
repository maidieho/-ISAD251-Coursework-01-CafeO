using System.Collections.Generic;

namespace CafeO.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ProductTypeId { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public byte[] Image { get; set; }

        public string ImagePath { get; set; }

        public bool IsAvailable { get; set; }

        public virtual ProductType ProductType { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}