using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Filter
{
    public class HeaderFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
       {
            ViewResult v = filterContext.Result as ViewResult;
            if(v!=null) // v will null when v is not a ViewResult
             {
                  MVCDemo.ViewModels.BaseViewModel bvm = v.Model as MVCDemo.ViewModels.BaseViewModel;
                  if(bvm!=null)//bvm will be null when we want a view without Header and footer
                    {
                           bvm.UserName = HttpContext.Current.User.Identity.Name;
          
                   }
           }
      }
    }
}