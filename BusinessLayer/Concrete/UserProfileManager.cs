using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class UserProfileManager
    {
        Repository<User> repoUser = new Repository<User>();
        public List<User> GetUserByUserName(string p)
        {
            return repoUser.List(x => x.UserName == p);
        }
    }
}
