using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers.Home
{
    public class HomeController : Controller
    {

        private readonly SchoolCommunityContext ctxt;

        public HomeController(SchoolCommunityContext context)
        {
            ctxt = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
