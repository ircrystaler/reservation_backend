using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reservation_system.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult getUser(int id)
        {
            return new JsonResult(id);
        }
    }
}