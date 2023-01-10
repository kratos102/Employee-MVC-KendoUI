using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeManagementController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmployeeManagement/Read    
        public ActionResult Read()
        {
            EmployeeRepo EmpRepo = new EmployeeRepo();
            List<EmployeeViewModel> emp = EmpRepo.GetAllEmployees();
            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        // POST: EmployeeManagement/Create    
        [HttpPost]
        public ActionResult Create(FormCollection Emp)
        {
            List<EmployeeViewModel> list = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(Emp[0]);
            EmployeeRepo EmpRepo = new EmployeeRepo();
            EmpRepo.AddEmployee(list[0]);

            return View();
        }


        // POST: EmployeeManagement/Update/5    
        [HttpPost]
        public ActionResult Update(FormCollection Emp)
        {
            List<EmployeeViewModel> list = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(Emp[0]);
            EmployeeRepo EmpRepo = new EmployeeRepo();
            EmpRepo.UpdateEmployee(list[0]);

            return View();
        }

        // POST: EmployeeManagement/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection Emp)
        {
            List<EmployeeViewModel> list = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(Emp[0]);
            EmployeeRepo EmpRepo = new EmployeeRepo();
            EmpRepo.DeleteEmployee(list[0]);

            return View();
        }
    }
}