﻿using FinalProjectBackend.DAL;
using FinalProjectBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBackend.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Contact> contact = _db.Contacts.ToList();
            return View(contact);
           
        }
    }
}
