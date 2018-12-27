using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Mcally.Web.Controller
{

   public class TestController : ApiController
    {


        [HttpGet]
        public object GetTest() {

            return "Sucess";
        }

        public object Hello() {

            return "Hello Word";
        }


        
    }
}
