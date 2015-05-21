using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace ProjectAPI.Controllers
{
    
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return new ResponseMessageResult(new HttpResponseMessage()
            {
                Content = new StringContent("Welcome to my API!")
            });
        }
    }
}
