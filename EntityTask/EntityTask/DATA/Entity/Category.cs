﻿using System.Collections.Generic;

namespace EntityTask.DATA.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
