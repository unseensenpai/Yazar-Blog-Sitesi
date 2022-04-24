using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class PartialController : Controller
    {
        public PartialViewResult Partial1() // Navbar Header
        {
            return PartialView();
        }

        public PartialViewResult Partial2() // Top Header
        {
            return PartialView();
        }

        public PartialViewResult Partial3() // Footer
        {
            return PartialView();
        }
    }
}
