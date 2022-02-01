using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EntityLayer.Concrete
{
   public class Data
    {
       
        [Key]
        public int DataId { get; set; }

        public string Image { get; set; }
        //public HttpPostedFileBase File { get; set; }

        //public string DataName { get; set; }

        //public DateTime DataTime { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
