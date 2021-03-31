﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStoreMVCRedBadge.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required, Display(Name = "# In Stock")]
        public int InventoryCount { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required, Display(Name = "It is Food")]
        public Boolean IsFood { get; set; }
    }
    public class GeneralStoreDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
    }
}