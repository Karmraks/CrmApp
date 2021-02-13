using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        CrmContext crmContext = new CrmContext();

        IEnumerable<Position> positions;

        public ActionResult Index()
        {
            IEnumerable<Employee> employees = crmContext.Employees;

            ViewBag.Employees = employees;

            return View();
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            positions = crmContext.Positions;

            ViewBag.Positions = positions;

            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            positions = crmContext.Positions;

            var position = positions.Where(p => p.PositionId == employee.PositionId).FirstOrDefault();

            if (position != null)
            {
                employee.PositionName = position.PositionName;

                crmContext.Employees.Add(employee);
                crmContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult AddPosition()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPosition(Position position)
        {
            crmContext.Positions.Add(position);
            crmContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}