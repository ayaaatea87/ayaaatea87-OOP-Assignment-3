using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring3.Part_03.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }

    public static class StudentCatalog
    {
        public static IEnumerable<Student> GetAllStudents()
        {
            for (var i = 1; i <= 1_000_000; i++)
                yield return new Student
                {
                    Id = i,
                    Name = $"Student {i}"
                };
        }
    }
}
