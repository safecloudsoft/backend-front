using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class DataManager
    {
        Repository<Data> repoData = new Repository<Data>();
       public List<Data> GetDataByUserName(int id)
        {
            return repoData.List(x => x.UserId == id);
        }

        public int DeleteBlog(int p)
        {
            Data data = repoData.Find(x => x.DataId == p);
            return repoData.Delete(data);
        }
    }
}
