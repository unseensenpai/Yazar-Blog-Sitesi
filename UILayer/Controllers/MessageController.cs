using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_Layer.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IActionResult Inbox()
        {
            int id = 3;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
        public IActionResult ReadMessage(int id)
        {
            var values = mm.TGetById(id);           
            return View(values);
        }
    }
}
