using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PelicanBundle.Models;
namespace PelicanBundle.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Display()
        {
            return View("Index");
        }
    }
}
