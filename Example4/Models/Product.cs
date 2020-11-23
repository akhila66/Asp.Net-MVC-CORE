using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Example4.Models
{
    public partial class Product
    {

        // Product attrubites and validation entiries to create conrollers and views from entity framework

        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter Product Name")]
        [Display(Name = "Product Name")]
        [StringLength(100)]
        public string ProductName { get; set; }

        public int? SupplierId { get; set; }
        [Required(ErrorMessage = "Please choose Category")]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
        
        public string QuantityPerUnit { get; set; }

        [Required(ErrorMessage = "Please enter Unit Price")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }



        [Required(ErrorMessage = "Please enter Units in Stock")]
        [Display(Name = "Units in Stock")]
        public short? UnitsInStock { get; set; }
        
    

        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual Category Category { get; set; }
        
    }
}
