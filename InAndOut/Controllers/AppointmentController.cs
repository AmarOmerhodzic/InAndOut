﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();

           
        }

        public IActionResult Details(int id)
        {
            return Ok("u entered id = {id}" + id);
        }
    }
}