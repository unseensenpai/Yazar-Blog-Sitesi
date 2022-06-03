using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
        public IActionResult BlogListByWriter(int id)
        {
            var values = bm.GetBlogListWithCategoryByWriter(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {           
            List<SelectListItem> catvalues = (from x in cm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryID.ToString(),
                                              }).ToList();
            ViewBag.cv = catvalues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog p)
        {
            BlogValidator validator = new BlogValidator();
            ValidationResult results = validator.Validate(p);
            List<SelectListItem> catvalues = (from x in cm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryID.ToString(),
                                              }).ToList();
            ViewBag.cv = catvalues;
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                bm.AddT(p);
                return RedirectToAction("BlogListByWriter", "Blog");
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
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            bm.DelT(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            List<SelectListItem> catvalues = (from x in cm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CategoryName,
                                                  Value = x.CategoryID.ToString(),
                                              }).ToList();
            ViewBag.cv = catvalues;
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            var blogvalue = bm.TGetById(p.BlogID);
            p.WriterID = 1;
            p.BlogCreateDate = DateTime.Parse(blogvalue.BlogCreateDate.ToShortDateString());
            p.BlogStatus = true;
            bm.UpdateT(p);
            return RedirectToAction("BlogListByWriter");
        }
    }


}
