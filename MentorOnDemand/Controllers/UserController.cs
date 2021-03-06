﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorOnDemand.BusinessLayer.Interfaces;
using MentorOnDemand.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MentorOnDemand.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserServices _service;

        public UserController(IUserServices service)
        {
            _service = service;
        }

        // GET: User
        public async Task<ActionResult> AllUsers()
        {
            var user = await _service.GetAllUserAsync();
            return View(user);
        }

        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user, IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                await _service.SignUpAsync(user);
                return RedirectToAction(nameof(AllUsers));
            }
            catch
            {
                return View();
            }
        }
    }
}