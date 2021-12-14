using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sifte.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return Content("Salam");
        }
    }
}
