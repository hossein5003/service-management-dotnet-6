﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class WebImages
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public byte[]? Picture { get; set; }
    }
}

 