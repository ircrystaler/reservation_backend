using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using reservation_system.Models;
using System.Linq;

namespace Controllers
{
    public class MasterController : ControllerBase
    {
        private readonly ApiContext dbContext;

        public MasterController(ApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("search")]
        public IActionResult search(string q)
        {
            var searchResults = from Provider provider in dbContext.Providers
                                where (provider.Name).Contains(q) 
                                select provider;
            return new JsonResult(searchResults);
        }
    }
}