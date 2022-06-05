using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_Layer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v1 = c.Blogs.Count(x => x.WriterID == 1).ToString();
            ViewBag.v2 = c.Categories.Count();
            ViewBag.v3 = c.Comments.Count(x => x.BlogID == 7).ToString();
            return View();
        }
    }
}
