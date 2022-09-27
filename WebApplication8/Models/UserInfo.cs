using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class UserInfo
    {
        [Key]
        public int UserNo { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        
        public string Address { get; set; }
       
        public int Grade { get; set; }

        [ForeignKey("UserNo")]
        protected virtual User User { get; set; }
    }
}
