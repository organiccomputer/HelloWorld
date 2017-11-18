using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloAPI.Controllers
{
    public class HelloController : ApiController
    {
        // GET: api/Hello
        public string Get()
        {
            return "Hello World";
        }

        // POST: api/Hello
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Hello/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hello/5
        public void Delete(int id)
        {
        }
    }
}
