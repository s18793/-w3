﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            return NotFound("Nie znaleziono studenta");
        }

        [HttpGet]

        public string GetStudents(string orderby)
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderby}";

        }

       [HttpPost]

       public IActionResult CreateStudent (Student student){

            //...ad to database
            //... generating index numebr
            student.IndexNumber = $"s{new Random().Next(1,20000)}";
        }

        
    }
}