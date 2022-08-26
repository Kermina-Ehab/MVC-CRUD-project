using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Day07.Models;

namespace MVC_Day07.Controllers
{
    public class EmployeeController : Controller
    {
        readonly Model md;
        public EmployeeController(Model _model )
        {
            md = _model;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var emps = md.emps.Include(r => r.Department).ToList();
            return View(emps);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.depts =new SelectList(md.depts.ToList(), "id", "Deptname");         
            return View();
        }

        [HttpPost]
        public IActionResult Create(employee emp)
        {
            md.emps.Add(emp);
            md.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.depts = new SelectList(md.depts.ToList(), "id", "Deptname");

            var emp =md.emps.SingleOrDefault(e=>e.id==id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(employee emp)
        {
            md.emps.Update(emp);
            md.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public IActionResult Delete(int id)
        {
            employee emp = md.emps.Find(id);
            md.emps.Remove(emp);
            md.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
