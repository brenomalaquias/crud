using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Data;
using Microsoft.AspNetCore.Mvc;
using projeto.Mappers;

namespace projeto.Controllers
{
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }
         
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _context.Students.ToList()
             .Select(s => s.ToStudentDto());

            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var student = _context.Students.Find(id);
            if(student == null)
            {
                return NotFound();
            }

            return Ok(student.ToStudentDto());
        }
    }
}