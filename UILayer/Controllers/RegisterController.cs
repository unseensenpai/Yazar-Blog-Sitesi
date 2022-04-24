using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet] // Sayfa yüklenmesinde null kayıt yapılmaması için
        public IActionResult Index()
        {
            //var model = new ViewModel();
            //model.Sehirler = new List<SelectListItem>();
            //model.Sehirler.Add(new SelectListItem() { Text = "İstanbul", Value = "1", Selected = false });
            //model.Sehirler.Add(new SelectListItem() { Text = "Ankara", Value = "2", Selected = false });
            //model.Sehirler.Add(new SelectListItem() { Text = "İzmir", Value = "3", Selected = false });
            //model.Sehirler.Add(new SelectListItem() { Text = "Diğer", Value = "4", Selected = false });
            //return View(model);
            return View();
        }
        [HttpPost] // Sayfada butona basılınca
        public IActionResult Index(Writer p)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult results = validator.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Hakkında";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
            
        }      
    }
}

// httpget ve post methodlarının ismi aynı olmalı. Listelemelerde HTTPGET kullanılır.
