using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    public class WelcomeController : ApiController
    {

        [System.Web.Http.Route("api/form/getinfo")]
        [System.Web.Http.HttpGet]
        // GET api/<controller>
        public string Get()
        {
            
            return "value";
            
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}