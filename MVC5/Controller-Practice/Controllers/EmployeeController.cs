using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controller_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string Profile(int id, string name)
        {
            return "ID = " + id + " and Name = " + name + " .";
        }


        public string FullName(string first = null, string last = null)
        {
            if (first != null && last != null)
            {
                return "your full name is " + first + " " + last;
            }
            else if (first == null)
            {
                return "your full name is " + last;
            }
            else
            {
                return "your full name is " + first;
            }
        }

    }
}