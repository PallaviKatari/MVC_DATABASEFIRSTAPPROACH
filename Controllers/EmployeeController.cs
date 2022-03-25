using MVC_DFA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DFA.Controllers
{
    //CUSTOM FILTER
    [MyLogActionFilter]
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            MVCDBContext db = new MVCDBContext();
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            MVCDBContext db= new MVCDBContext();
            Employee emp=db.Employees.FirstOrDefault(x=>x.EmpID==id);
            return View(emp);
        }
        //An action filter can be applied to
        //either an individual controller action or an entire controller.
        [OutputCache(Duration = 10)]
        //There are three types of action selector attributes −

        //ActionName
        //NonAction
        //ActionVerbs
        //ACTIONNAME
       [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

        //The new method TimeString is called from
        //the GetCurrentTime1() but you can’t use it as action in URL.
        [ActionName("CurrentTime1")]
        public string GetCurrentTime1()
        {
            return TimeString();
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }
        //MVC framework supports the following ActionVerbs.
        //HttpGet
        //HttpPost
        //HttpPut
        //HttpDelete
        //HttpOptions
        //HttpPatch
    }
}