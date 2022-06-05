using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_Layer.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MessageManager mm = new MessageManager(new EfMessageRepository());
            string p = "ornek@gmail.com";
            var values = mm.GetRecieverListByWriter(p);
            return View(values);
        }
    }
}
