using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddT(Category t)
        {
            _categoryDal.Insert(t);
        }


        public void DelT(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public void UpdateT(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}



//public CategoryManager()
//{
//    efCatRepo = new EfCategoryRepository(); // Daha generic bir kod için repository yerine abstract sınıfları kullandım.
//}
//CategoryRepository cr = new CategoryRepository();
//GenericRepository<Category> repo = new GenericRepository<Category>();
//public void AddCat(Category cat)
//{           
//if (cat.CategoryName != "" && cat.CategoryDescription != "" && cat.CategoryName.Length >= 5 && cat.CategoryStatus == true) {
//    cr.AddCat(cat);
//}
//else
//{
//    //Hata Mesajı
//}            
//}

//public void DelCat(Category cat)
//{
//    _categoryDal.Delete(cat);
//    //if (cat.CategoryID != 0) {
//    //    repo.Delete(cat);
//    //}
//}
//public void UpdateCat(Category cat)
//{
//    _categoryDal.Update(cat);
//}