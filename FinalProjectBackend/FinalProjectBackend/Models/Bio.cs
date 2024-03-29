﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBackend.Models
{
    public class Bio
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Logo { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; } 
        [NotMapped]

        public IFormFile Photo { get; set; }
    }
}
