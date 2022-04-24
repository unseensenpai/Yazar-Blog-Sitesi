using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void AddCom(Comment com)
        {
            _CommentDal.Insert(com);
        }

        public List<Comment> GetList(int id)
        {
            return _CommentDal.GetList(x => x.BlogID == id);
        }
    }
}
