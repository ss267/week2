using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace week2.Controllers
{
    public class RiZhiController : ApiController
    {
        RiZhiDal dal = new RiZhiDal();
        public List<RiZhi> Show()
        {
         return   dal.Show();
        }
        public int Del(int YHId)
        {
            return dal.Del(YHId);
        }
        public List<RiZhi> GetUserShow()
        {
            return dal.GetUserShow();
        }
        public int DelUser(int YHId)
        {
            return dal.DelUser(YHId);
        }
    }
}
