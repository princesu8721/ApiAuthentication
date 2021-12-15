using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAuthentication.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        public List<Employee> Get()
        {
            using (EmployeeDBEntities emp = new EmployeeDBEntities())
            {
                return emp.Employees.ToList();
            }
        }


    }
}
