using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_Practice.Models;

namespace Model_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Profile()
        {
            Employee em = getdata();
            return View(em);

        }

        private Employee getdata()
        {
            return new Employee()
            {
                ID = 1,
                Name = "afshan"
            };
        }
    }
}