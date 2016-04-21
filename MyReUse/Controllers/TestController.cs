using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyReUse.Models;
using MyReUse.ViewModels;
using MyReUse.BusinessLayer;
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

        public ActionResult IndexList()
        {
           EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
              
           EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
           List<Employee> employees = empBal.GetEmployees();
           
           List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
              
          foreach (Employee emp in employees)
                    {
                        EmployeeViewModel empViewModel = new EmployeeViewModel();
                       empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                         empViewModel.Salary = emp.Salary.ToString("C");
                        if (emp.Salary > 15000)
                           {
                                 empViewModel.SalaryColor = "yellow";
                          }
                       else
                         {
                               empViewModel.SalaryColor = "green";
                          }
                        empViewModels.Add(empViewModel);
                    }
                 employeeListViewModel.Employees = empViewModels;
                employeeListViewModel.UserName = "Admin";
                 return View(employeeListViewModel);

           
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