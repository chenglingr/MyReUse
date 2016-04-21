using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyReUse.Models;
using MyReUse.ViewModels;
namespace MyReUse.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Employee ee = new Employee();
            ee.FirstName = "张";
            ee.LastName = "三";
            ee.Salary = 888;

         // ViewData["Employee"] = ee;
            ViewBag.Employee = ee;
            return View();
        }
        public ActionResult Index1()
        {
            Employee emp = new Employee();
            emp.FirstName = "张";
            emp.LastName = "三";
            emp.Salary = 888;
            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
             vmEmp.Salary = emp.Salary.ToString("C");
              if (emp.Salary > 15000)
                    {
                       vmEmp.SalaryColor = "yellow";
                   }
                else
                   {
                        vmEmp.SalaryColor = "green";
                     }

            vmEmp.UserName = "Admin";

            return View(vmEmp);
        }
        public ActionResult getString()
        {
            Employee ee = new Employee();
            ee.FirstName = "李";
            ee.LastName = "四";
            ee.Salary = 1888;
            return View("getString", ee);
        }
        public Employee getEmployee()
        {
            Employee ee = new Employee();
            ee.FirstName = "张";
            ee.LastName = "三";
            ee.Salary = 888;
            return ee;
        }

        [NonAction]
        public string getNoAction() //非action
        { return "testtest"; }
    }
  
}