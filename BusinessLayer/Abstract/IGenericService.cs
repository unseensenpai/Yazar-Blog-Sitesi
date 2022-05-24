using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> // Generic yapı
    {
        void AddT(T t);
        void DelT(T t);
        void UpdateT(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
