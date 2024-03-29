﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Models
{
    public class DragonCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string DragonName { get; set; }
        public string DragonColor { get; set; }
        [MaxLength(8000)]
        public string DragonDescription { get; set; }

    }
}
