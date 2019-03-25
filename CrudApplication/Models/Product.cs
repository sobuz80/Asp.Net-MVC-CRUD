using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Status Name")]
        [StringLength(20, ErrorMessage = "The (0) Must be at least (2) characters long.", MinimumLength = 3)]
        public string Name { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }

    }
}