using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RiZhiDal
    {
       
        public List<RiZhi> Show()
        {
            string Sql = "select * from RiZhi";
            return DBHelper.GetList<RiZhi>(Sql);
        }
        public int Del(int YHId)
        {
            string sql = $"delete from RiZhi where YHId={YHId}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public List<RiZhi> GetUserShow()
        {
            string sql = $"select * from RiZhi  where States=1";
            return DBHelper.GetList<RiZhi>(sql);
        }
        public int DelUser(int YHId)
        {
            string sql = $"update RiZhi set States=2 where UserId={YHId}";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
