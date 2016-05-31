using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class AccountViewModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Models.Article> Articles { get; set; }
    }
}