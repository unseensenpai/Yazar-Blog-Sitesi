using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_Layer.Controllers
{
    //[Authorize] // Yazarla ilgili hiçbir resulta ulaşamaz. Proje seviyesinde authorize için Startup.cs incele.
    public class WriterController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
    }
}
