using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_Layer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        AdminManager wm = new AdminManager(new EfAdminRepository());
        public IActionResult Index()
        {
            var values = wm.GetList();
            return View(values);
        }
    }
}
