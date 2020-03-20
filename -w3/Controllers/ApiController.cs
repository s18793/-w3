using System;
using cwiczenia3.NewFolder;
using Microsoft.AspNetCore.Mvc;

using _w3.DAL;

namespace cwiczenia3.Controllers
{
    [ApiController]
    [Route("api/students")]

    public class StudentsController : ControllerBase 
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;

        }
        [HttpGet]
        public IActionResult getStudents(String orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpPost]

        public IActionResult CreateStudent(Student student)
        {

           
            student.IndexNumber = $"s{new Random().Next(1,20000)}";
             return Ok(student);
        }

        [HttpPut]
        public IActionResult PutStudent(int id)
        {
            return Ok($"Aktualizacja dokonczona {id}");
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            return Ok($"Usuwanie ukończone {id}");
        }

        [HttpGet("{id}")]
        public IActionResult getStudent(int id)
        {
            return Ok(_dbService);
        }

    }
}