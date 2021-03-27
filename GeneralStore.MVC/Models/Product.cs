using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")] //We want the user to enter the product name, and when the 'DisplayFor' is called
        public string Name { get; set; }
        [Required]
        [Display(Name = "# In Stock")] //We want the user to enter the number in stock, and when the 'DisplayFor' is called, 
        //we want to use  more meaningful text , '# In Stock'
        public int InventoryCount { get; set; }

        [Required]
        //We definitely want to make the price a required field
        public double Price { get; set; }

        [Required]
        [Display(Name = "It is Food")]//We want to know if the item is a perishable one or not. The name displayed using 'DisplayFor' should be 'It Is Food'
        public Boolean IsFood { get; set; }
    }
}