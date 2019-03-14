using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        
        private readonly SchoolContext _dbContext;

        public PersonsController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Person>> GetAllPersons()
        {
            return Ok(_dbContext.Person.Include(p => p.Person).ToList());
        }

        // [HttpGet("{personId}")]
        // public ActionResult<Person> GetPerson(int personId)
        // {
        //     var person = _dbContext.Person
        //         .SingleOrDefault(p => p.PersonId == personId);

        //     if (person != null) {
        //         return person;
        //     } else {
        //         return NotFound();
        //     }
        // }

    }
}