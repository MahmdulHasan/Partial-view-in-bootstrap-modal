using PopUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PopUp.Controllers
{
    public class ListInBootstrapModalController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: ListInBootstrapModal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            List<Employee> employeeList = _db.Employees.ToList<Employee>();
            return Json(new { data = employeeList }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Details(int id)
        {
            List<Employee> employeeList = _db.Employees.Where(w=>w.EmployeeId==id).ToList();
            return PartialView("_Details", employeeList);
        }
    }
}