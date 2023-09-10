using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace JwtAuthentication.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class SecretController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecret()
        {
            return Ok("This is a secret!!");
        }

        [HttpGet("admin")]
        [Authorize(Roles = "Administrator")]
        public IActionResult GetAdminSecret()
        {
            return Ok("This is a secret for admins only!!");
        }

        [HttpGet("employee")]
        [Authorize(Policy = "EmployeeOnly")]
        public IActionResult GetEmployeeSecret()
        {
            return Ok("This is a secret for employees only!!");
        }
    }
}