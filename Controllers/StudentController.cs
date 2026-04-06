
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
namespace StudentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService s){_service=s;}

        [HttpGet]
        public async Task<IActionResult> GetAll()=>Ok(await _service.GetAll());

        [HttpPost]
        public async Task<IActionResult> Add(Student s){await _service.Add(s);return Ok();}

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Student s){await _service.Update(id,s);return Ok();}

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){await _service.Delete(id);return Ok();}
    }
}
