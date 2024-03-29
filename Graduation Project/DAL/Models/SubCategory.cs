﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SubCategory
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("category")]
        public int CategoryID { get; set; }

        public Category category { get; set; }

    }
}
