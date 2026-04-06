using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.Repositories.Interfaces;

namespace StudentManagementSystem.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _ctx;
        public StudentRepository(AppDbContext ctx){_ctx=ctx;}
        public async Task<IEnumerable<Student>> GetAll()=>await _ctx.Students.ToListAsync();
        public async Task<Student> GetById(int id)=>await _ctx.Students.FindAsync(id);
        public async Task Add(Student s){await _ctx.Students.AddAsync(s);await _ctx.SaveChangesAsync();}
        public async Task Update(Student s){_ctx.Update(s);await _ctx.SaveChangesAsync();}
        public async Task Delete(Student s){_ctx.Remove(s);await _ctx.SaveChangesAsync();}
    }
}
