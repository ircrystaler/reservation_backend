using Microsoft.AspNetCore.Mvc;
using reservation_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reservation_system.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly ApiContext dbContext;
        public UserController(ApiContext dbContext)
        {  
            this.dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public IActionResult getUser(int id)
        {
            var a = dbContext.Providers.Count();
            return new JsonResult(id + " " + a);
        }

        [HttpGet("{id}/getrsvs")]
        public IActionResult getReservations(int id)
        {
            return new JsonResult("mamad");
        }

        [HttpPost("{id}/reserve/{timeId}")]
        public IActionResult reserve(int id, int timeId) 
        {
            return new JsonResult(true);
        }

        [HttpPost("{id}/cancel/{timeId}")]
        public IActionResult cancelReservation(int id, int timeId)
        {
            return new JsonResult(true);
        }
    }
}