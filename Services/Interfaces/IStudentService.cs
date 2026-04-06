using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using StudentManagementSystem.Models;
namespace StudentManagementSystem.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task Add(Student s);
        Task Update(int id, Student s);
        Task Delete(int id);
    }
}
