using System.Collections.Generic;

namespace EntityTask.DATA.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }


        public Category Category { get; set; }


        public ICollection<UserProduct> UserProducts { get; set; } = new List<UserProduct>();
    }
}
