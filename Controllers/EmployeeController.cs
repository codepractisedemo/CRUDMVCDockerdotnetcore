using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDMVCDockerdotnetcore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.CodeAnalysis.CSharp;

namespace CRUDMVCDockerdotnetcore.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly ApplicationDbcontext _db;

        public EmployeeController(ApplicationDbcontext mydb)
        {
            _db = mydb;
        }
        public IActionResult Index()
        {
            var mydata = _db.emp.ToList();
            return View(mydata);    
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Create(Employee empData)
        {
            if (ModelState.IsValid)
            {
                _db.Add(empData);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(empData);
        }
    }
}
