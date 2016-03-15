using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EmployeeApp.Controllers
{
    public class EmployeeApiController : ApiController
    {
        // GET: EmployeeApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        public void Delete(int id)
        {

        }
    }
}