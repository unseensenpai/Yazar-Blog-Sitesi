using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void AddCat(Category cat);
        void DelCat(Category cat);
        void UpdateCat(Category cat);
        List<Category> GetList();
        Category GetById(int id);

    }
}
