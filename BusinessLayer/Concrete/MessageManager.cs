﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddT(Message t)
        {
            throw new NotImplementedException();
        }

        public void DelT(Message t)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDal.GetList();
        }

        public List<Message> GetRecieverListByWriter(string p)
        {
            return _messageDal.GetList(x=>x.Receiver == p);
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateT(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
