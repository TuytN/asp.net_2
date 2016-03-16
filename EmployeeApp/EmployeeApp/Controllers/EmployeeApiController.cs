using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EmployeeApp.Controllers
{
    public class EmployeeApiController : ApiController
    {
        // GET: EmployeeApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //[HttpPost]
        //public string delete(string id)
        //{
        //    if (id == null)
        //    {
        //        throw new ArgumentNullException("prefix");
        //    }

        //    if (id.Count() == 0)
        //    {
        //        return "";//_sortedValues.Length > 0; // only match empty string when we have some value
        //    }

        //    return "delete" + id.ToString();
        //}

        [HttpPost]
        [ActionName("Delete")]
        public string Delete([FromBody]List<int> id)
        {
            return "delete" + id.Count().ToString();
        }

        [HttpPost]
        [ActionName("Edit")]
        public string Edit(int id)
        {
            return "edit" + id.ToString();
        }
    }
}