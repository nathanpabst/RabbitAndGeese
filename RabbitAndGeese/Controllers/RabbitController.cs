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
    }
}