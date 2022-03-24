﻿using MVC_DFA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DFA.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            MVCDBContext db = new MVCDBContext();
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }
    }
}