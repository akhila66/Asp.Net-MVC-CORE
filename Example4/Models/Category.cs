using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Example4.Models
{
    public partial class Category
    {

        // Product attrubites and validation entiries to create conrollers and views from entity framework


        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter Category Name")]
        [Display(Name = "Category Name")]
        [StringLength(100)]
        public string CategoryName { get; set; }


        public string Description { get; set; }


        public byte[] Picture { get; set; } = Array.Empty<byte>();


        public virtual ICollection<Product> Products { get; set; }
    }
}
