using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Product.Model
{
    class ProductListCategory
    {

        [Required]
        public int CategoryId { set; get; }
        [Required]
        public string CategoryName { set; get; }
        [Required]
        public int IsActive { set; get; }

    }
}
