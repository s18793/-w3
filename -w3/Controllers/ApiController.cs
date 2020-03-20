using System;
using cwiczenia3.NewFolder;
using Microsoft.AspNetCore.Mvc;


namespace cwiczenia3.Controllers
{
    [ApiController]
    [Route("api/students")]

    public class StudentsController : ControllerBase 
    {
        public string GetStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }

        [HttpGet("{id}")]

        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            } else if (id == 2)
            {
                return Ok("Malewski");
            }
            return NotFound("No Student Find");
        }

        [HttpGet] 

        public string GetStudents(string orderby)
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderby}";

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

    }
}