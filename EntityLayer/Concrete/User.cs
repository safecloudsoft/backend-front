using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(30)]
        public string Mail { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        public ICollection<Data> Datas { get; set; }
    }
}
