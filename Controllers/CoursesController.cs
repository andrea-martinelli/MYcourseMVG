using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MYcourse.Controllers
{
   
    public class CoursesController : Controller
    {
      

    
        public IActionResult Index()
        {
            return Content("Sono Index");
        }

        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}