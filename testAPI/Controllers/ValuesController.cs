using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testAPI.Models;
using testAPI.Components.BC;

namespace testAPI.Controllers
{
    [Route("v1")]
    public class ValuesController : ApiController
    {
       

        // GET api/values/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody]HttpRequestMessage value)
        {
            OperationsBC objBc=null;
            Response resp = new Response();
            resp = (Response)objBc.ProcessRequest("Post");
            HttpResponseMessage response = Request.CreateErrorResponse(HttpStatusCode.OK, resp.ToString());
            return response;
        }

        // PUT api/values/5
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            Response resp = new Response();

            HttpResponseMessage response = Request.CreateErrorResponse(HttpStatusCode.OK, resp.ToString());
            return response;
        }

        // DELETE api/values/5
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            Response resp = new Response();

            HttpResponseMessage response = Request.CreateErrorResponse(HttpStatusCode.OK, resp.ToString());
            return response;
        }
    }
}
