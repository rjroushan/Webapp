using Microsoft.AspNetCore.Mvc;

namespace Webapp.Controllers
{
    [Route("fc")]
    public class FirstController : Controller
    {

        [Route("n")]

        public string  GetName()
        {
            return "John Doe";
        }
        [Route("a")]
        public string GetAddress()
        {
            return "123 Main St";
        }
        public string GetAddress2()
        {
            return "456 Oak Ave";
        }
    }
}
