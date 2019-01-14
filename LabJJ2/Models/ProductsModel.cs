using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabJJ2.Models
{
    public class ProductsModel
    {
        [Required]
        [MaxLength(50, ErrorMessage ="Please limit the name to 50 characters")]
        [DisplayName("Product name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Please limit the description to 50 characters")]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Please enter price with two decimal places and no dollar sign")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Please enter a valid price with only two decimal places")]
        public decimal Price { get; set; }

    }
}