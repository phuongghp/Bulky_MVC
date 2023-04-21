﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
       
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; } 
        [Required]
        [Display(Name ="List Price")]//mua 1 quyen
        [Range(1,1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-50")]//mua tu 2-50 quyen
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 50+")]//mua hon 50 q
        [Range(1, 1000)]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]//mua hon 100 q
        [Range(1, 1000)]
        public double Price100 { get; set; }
      
    }
}
