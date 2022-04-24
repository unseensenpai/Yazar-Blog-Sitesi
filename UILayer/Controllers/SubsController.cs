using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class SubsController : Controller
    {
        SubsManager sm = new SubsManager(new EfSubsRepository());
        [HttpGet]
        public PartialViewResult SubsMail()
        {
            return PartialView();
        }
        //[HttpPost]
        //public PartialViewResult SubsMail(Subs p)
        //{
        //    p.MailStatus = true;
        //    sm.AddSubs(p);
        //    return PartialView();
        //}

        [HttpPost]
        public JsonResult SubsMail(Subs p)
        {
            p.MailStatus = true;
            sm.AddSubs(p);
            return Json("Abone Olundu. Teşekkürler.");
        }
    }
}
