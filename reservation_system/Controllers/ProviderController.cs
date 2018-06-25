using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reservation_system.Models;

namespace reservation_system.Controllers
{
    [Route("api/provider")]
    public class ProviderController : ControllerBase
    {
        private readonly ApiContext dbContext;
        public ProviderController(ApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult getProviders()
        {
            return Ok();
        }

        [HttpGet("{id}/rsvs")]
        public IActionResult getReservations(int id)
        {
            return new JsonResult(true);
        }

        [HttpPost("addtime")]
        public IActionResult reserve(DateTime beginDate, DateTime endDate, DateTime beginTime, DateTime endTime)
        {
            return new JsonResult(true);
        }
    }
}