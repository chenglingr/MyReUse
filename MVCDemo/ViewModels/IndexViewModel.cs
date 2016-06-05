using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class IndexViewModel
    {
        public List<Models.Account> Accounts { get; set; }
        public List<Models.Article> Articles { get; set; }
    }
}