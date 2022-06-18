using cw11.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Data.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> Students { get; set; }
        public List<bool> HowSortStudents { get; set; }
        public StudentService()
        {
            Students = new List<Student>()
            {
                new Student
                {
                    IdStudent = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Avatar = "https://cdn4.vectorstock.com/i/1000x1000/97/68/silhouette-businessman-man-in-suit-with-tie-vector-13429768.jpg",
                    BirthDate = DateTime.Parse("2000-01-01"),
                    Studies = "Informatyka"
                },
                new Student
                {
                    IdStudent = 2,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Avatar = "https://cdn4.vectorstock.com/i/1000x1000/97/68/silhouette-businessman-man-in-suit-with-tie-vector-13429768.jpg",
                    BirthDate = DateTime.Parse("2001-01-01"),
                    Studies = "Informatyka"
                },
                new Student
                {
                    IdStudent = 3,
                    FirstName = "Anna",
                    LastName = "Kowalska",
                    Avatar = "https://image.shutterstock.com/image-vector/woman-profile-picture-vector-260nw-438753232.jpg",
                    BirthDate = DateTime.Parse("2002-01-01"),
                    Studies = "SNM"
                }
            };

            HowSortStudents = new List<bool> { true, true, true, true, true };
        }

        public void DeleteStudent(int id)
        {
            Students.Remove(GetStudent(id));
        }

        public Student GetStudent(int id)
        {
            return Students.FirstOrDefault(e => e.IdStudent == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }

        public void SortStudent(int id)
        {
            switch (id)
            {
                case 1: if (HowSortStudents[0]) { Students = Students.OrderBy(e => e.Avatar).ToList(); HowSortStudents[0] = !HowSortStudents[0]; } else { Students = Students.OrderByDescending(e => e.Avatar).ToList(); HowSortStudents[0] = !HowSortStudents[0]; } break;
                case 2: if (HowSortStudents[1]) { Students = Students.OrderBy(e => e.FirstName).ToList(); HowSortStudents[1] = !HowSortStudents[1]; } else { Students = Students.OrderByDescending(e => e.FirstName).ToList(); HowSortStudents[1] = !HowSortStudents[1]; } break;
                case 3: if (HowSortStudents[2]) { Students = Students.OrderBy(e => e.LastName).ToList(); HowSortStudents[2] = !HowSortStudents[2]; } else { Students = Students.OrderByDescending(e => e.LastName).ToList(); HowSortStudents[2] = !HowSortStudents[2]; } break;
                case 4: if (HowSortStudents[3]) { Students = Students.OrderBy(e => e.BirthDate).ToList(); HowSortStudents[3] = !HowSortStudents[3]; } else { Students = Students.OrderByDescending(e => e.BirthDate).ToList(); HowSortStudents[3] = !HowSortStudents[3]; } break;
                case 5: if (HowSortStudents[4]) { Students = Students.OrderBy(e => e.Studies).ToList(); HowSortStudents[4] = !HowSortStudents[4]; } else { Students = Students.OrderByDescending(e => e.Studies).ToList(); HowSortStudents[4] = !HowSortStudents[4]; } break;
            }
        }
    }
}
