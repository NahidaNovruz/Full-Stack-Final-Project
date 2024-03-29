﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBackend.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Image { get; set; } 
        public string TitleHeader { get; set; }
        public string Info { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
