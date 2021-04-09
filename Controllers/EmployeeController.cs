using Jitendra_Joshi_Assignment.Models;
using Jitendra_Joshi_Assignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jitendra_Joshi_Assignment.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository rep = new EmployeeRepository();
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<Employee> obj = rep.SelectAllEmployee();
            return View(obj);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee employee = rep.SelectEmployeeById(id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                rep.InsertEmployee(employee);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee employee = rep.SelectEmployeeById(id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                // TODO: Add update logic here
                rep.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee employee = rep.SelectEmployeeById(id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                rep.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete_JS(int id)
        {
            Employee employee = rep.SelectEmployeeById(id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete_JS(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                rep.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}