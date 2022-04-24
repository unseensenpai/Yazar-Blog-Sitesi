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
    public class SubsManager : ISubsService
    {
        ISubsDal _subsDal;

        public SubsManager(ISubsDal subsDal)
        {
            _subsDal = subsDal;
        }

        public void AddSubs(Subs sub)
        {
            _subsDal.Insert(sub);
        }
    }
}
