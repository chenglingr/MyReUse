﻿using System.Web.Mvc;
using MyReUse.Models;
using MyReUse.BusinessLayer;
using System.Web.Security;

namespace MyReUse.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoLogin(UserDetails u)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
                //if (bal.IsValidUser(u))
                //{
                //    FormsAuthentication.SetAuthCookie(u.UserName, false);
                //    return RedirectToAction("AddNew", "Employee");
                //}
                //else
                //{
                //    ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                //    return View("Login");
                //}

                UserStatus status = bal.GetUserValidity(u);
                bool IsAdmin = false;
                if (status == UserStatus.AuthenticatedAdmin)
                    {
                           IsAdmin = true;
                    }
                else if (status == UserStatus.AuthentucatedUser)
                    {
                          IsAdmin = false;
                    }
                else
                   {
                         ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                         return View("Login");
                   }
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                Session["IsAdmin"] = IsAdmin;
                return RedirectToAction("IndexList", "Employee");
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
}
}