﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class AccountListViewModel:BaseViewModel
    {
        public List<Models.Account> Accounts { get; set; }
    }
}