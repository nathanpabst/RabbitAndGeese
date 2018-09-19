using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RabbitAndGeese.Models;

namespace RabbitAndGeese.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeeseController : ControllerBase
    {
        static List<Goose> Geese;

        static GeeseController()
        {
            Geese = new List<Goose>
            {
            new Goose {Name = "Gerald", Sex = Sex.Male, Social = false},
            new Goose {Name = "Stewart", Sex = Sex.Male, Social = false},
            new Goose {Name = "Bart", Sex = Sex.Male, Social = true},
            new Goose {Name = "Stephanie", Sex = Sex.Female, Social = true},
            new Goose {Name = "Gus", Sex = Sex.Female, Social = true},
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Goose>> GetAll()
        {
            return Geese;
        }

        [HttpGet("cool")]
        public ActionResult<IEnumerable<Goose>> GetCoolMaleGeese()
        {
            var coolGeese = Geese.Where(goose => goose.Sex == Sex.Male && goose.Social);
            return Ok(coolGeese);
        }


        [HttpPost]
        public IActionResult AddAGoose(Goose goose)
        {
            Geese.Add(goose);
            return Ok();
        }
    }
}