using cw11.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Data.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        void DeleteStudent(int id);
        void SortStudent(int id);
    }
}
