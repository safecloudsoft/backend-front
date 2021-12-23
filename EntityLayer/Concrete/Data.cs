using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Data
    {
        [Key]
        public int DataId { get; set; }

        public IFormFile Image { get; set; }

        public string DataName { get; set; }

        public DateTime DataTime { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
