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
    public class StudentsController : ControllerBase
    {
        
        private readonly IService _service;

        public StudentsController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<StudentDto>> GetAllStudents()
        {
            // return Ok(_dbContext.Student.Include(p => p.Person).ToList());

            return _service.GetAllStudents();
        }
    }
}