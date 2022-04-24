﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class // Herhangi Entitry gönderildiğinde bir classa ait tüm değerleri kullanacak
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);

        List<T> GetList(Expression<Func<T, bool>> filter);
    }
}
