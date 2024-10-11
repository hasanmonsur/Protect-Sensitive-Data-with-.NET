using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Contacts;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecretsController : ControllerBase
    {

        private readonly IMyService _myService;

        public SecretsController(IMyService myService)
        {
            _myService = myService;
        }


        [HttpGet]
        public IActionResult GeSecretsValue(string secretkey)
        {
            var user = _myService.GetSecret(secretkey);
            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
