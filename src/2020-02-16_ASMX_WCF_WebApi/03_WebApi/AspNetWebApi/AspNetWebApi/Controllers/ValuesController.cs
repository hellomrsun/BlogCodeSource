﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;

namespace AspNetWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/v1/Values/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var content = "{ 'id';" + id + "}";
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent(content, Encoding.UTF8);
            return response;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
