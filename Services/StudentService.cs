using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;
using StudentManagementSystem.Services.Interfaces;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo){_repo=repo;}

        public async Task<IEnumerable<Student>> GetAll()=>await _repo.GetAll();
        public async Task Add(Student s)=>await _repo.Add(s);

        public async Task Update(int id, Student s)
        {
            var e=await _repo.GetById(id);
            if(e==null) throw new Exception("Not found");
            e.Name=s.Name; e.Email=s.Email; e.Age=s.Age; e.Course=s.Course;
            await _repo.Update(e);
        }

        public async Task Delete(int id)
        {
            var e=await _repo.GetById(id);
            if(e==null) throw new Exception("Not found");
            await _repo.Delete(e);
        }
    }
}
