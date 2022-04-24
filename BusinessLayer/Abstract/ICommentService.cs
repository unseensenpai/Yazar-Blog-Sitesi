using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddCom(Comment com);
        //void DelCom (Comment com);
        //void UpdateCom(Comment com);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}
