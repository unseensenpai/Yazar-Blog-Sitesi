using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UI_Layer.Models;

namespace UI_Layer.Controllers
{
    //[Authorize] // Yazarla ilgili hiçbir resulta ulaşamaz. Proje seviyesinde authorize için Startup.cs incele.
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        AddProfileImage api = new AddProfileImage();
        Writer w = new Writer();
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
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writervalues = wm.TGetById(1);
            return View(writervalues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p, IFormFile imageFile)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult results = wl.Validate(p);
            if (results.IsValid)
            {
                wm.UpdateT(p);
                api.ImageAdd(imageFile, out string imageName);
                w.WriterImage = imageName;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}


//public IActionResult WriterAdd(AddProfileImage p)
//{
//    Writer w = new Writer();
//    if (p.WriterImage != null)
//    {
//        var extension = Path.GetExtension(p.WriterImage.FileName);
//        var newImageName = Guid.NewGuid() + extension;
//        var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFiles/", newImageName);
//        var stream = new FileStream(location, FileMode.Create);
//        p.WriterImage.CopyTo(stream);
//        w.WriterImage = newImageName;
//    }
//    w.WriterMail = p.WriterMail;
//    w.WriterName = p.WriterName;
//    w.WriterPassword = p.WriterPassword;
//    w.WriterStatus = true;
//    w.WriterAbout = p.WriterAbout;
//    wm.AddT(w);
//    return RedirectToAction("Index", "Dashboard");
//}