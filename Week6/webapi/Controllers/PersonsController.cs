using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return getPersons();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        private List<Person> getPersons()
        {
            return InMemory.persons;
        }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] Person person)
        // {
        //     person.ID = getNextId();

        //     InMemory.persons.Add(person);
        // }

        // private int getNextID();
        // {
        //     return InMemory.persons.Max(p => p.Id) + 1;
        // }
    }
}