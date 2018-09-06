using System;
using System.ComponentModel.DataAnnotations;

namespace Product.Model
{
    public class ProductList
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }

        [Required]
        public int ProductPrice { get; set; }

        [Required]
        public int ProductCategoryById { get; set; }
        [Required]
        public DateTime ProductDate { get; set; }
    }
}
