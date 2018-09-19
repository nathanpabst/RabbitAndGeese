using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitAndGeese.DataAccess;
using RabbitAndGeese.Models;

namespace RabbitAndGeese.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitController : Controller
    {
        [HttpPost]
        public void AddACustomer(Rabbit rabbit) 
        {
            var storage = new RabbitStorage();
            storage.Add(rabbit);

        }
        [HttpPost("{id}/geese")]
        public IActionResult AddGooseToRabbit(int id, Goose goose)
        {
            var storage = new RabbitStorage();
            var rabbit = storage.GetById(id);

            if (rabbit == null) return NotFound();

            rabbit.OwnedGeese.Add(goose);
            return Ok();
        }

        [HttpPut("{id}/saddles")]
        public IActionResult ProcureGooseSaddle(int id, Saddle saddle)
        {
            var storage = new RabbitStorage();
            var rabbit = storage.GetById(id);

            if (rabbit == null) return NotFound();

            rabbit.OwnedSaddles.Add(saddle);
            return Ok();
        }
    }
}