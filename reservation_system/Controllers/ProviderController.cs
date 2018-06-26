using System;
using System.Linq;
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
        
        [HttpGet("{id}")]
        public IActionResult getProvider(int id)
        {
            var provider = dbContext.Providers
                .Include(e => e.Tags).Where(e => e.Id == id)
                .Include(e => e.Reservations).Where(e => e.Id == id); //.Find(id).;
                
            foreach (var res in provider.First().Reservations)
            {
                res.StartTime = DateTime.Parse(res.StartTime).ToString();
            }
            return new JsonResult(provider);
        }

        [HttpGet("{id}/reserve")]
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