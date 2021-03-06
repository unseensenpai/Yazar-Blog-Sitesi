using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.userName = userMail;
            var values = abm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMedia()
        {            
            return PartialView();
        }
    }
}
