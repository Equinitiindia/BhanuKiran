using BussinessLogic;
using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            List<ApiModel> getApiModel = new List<ApiModel>();
            WebApiServices webApiServices = new WebApiServices();
            getApiModel = webApiServices.GetApiData().ToList();
            if (getApiModel.Count > 0)
            {
                return Ok(getApiModel);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            List<ApiModel> getApiModelById = new List<ApiModel>();
            WebApiServices webApiServices = new WebApiServices();
            getApiModelById = webApiServices.GetApiDataById(id).ToList();
            if (getApiModelById != null)
            {
                return Ok(getApiModelById);
            }
            else
            {
                return NotFound();
            }
        }

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
