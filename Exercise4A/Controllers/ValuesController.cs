using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exercise4A.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route ("GetValues")]
        public IEnumerable<String> Get() {
            return new string[] { "Value1","Value2" };
        }
        // GET api/values/5
        [Route("GetVal")]
        public string Get(int id)
        {
            return "value" +id.ToString();
        }
        [Route("PostVal")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            string val = value;
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.Created };
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
