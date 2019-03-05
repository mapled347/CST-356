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
    public class StudentsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return getStudents();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        private List<Student> getStudents()
        {
            return InMemory.students;
        }
    }
}