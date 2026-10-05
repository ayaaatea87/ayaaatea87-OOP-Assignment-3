using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
{
    new Student { Id = 1, Name = "Aya" },
    new Student { Id = 2, Name = "Mona" },
    new Student { Id = 3, Name = "Sara" },
    new Student { Id = 4, Name = "Nour" },
    new Student { Id = 5, Name = "Laila" }
};

            Console.WriteLine("Page 2:");

            foreach (var student in students.Page(2, 2))
            {
                Console.WriteLine(student.Name);
            }
            var foundStudent = students.FindById(3);

            Console.WriteLine($"Found: {foundStudent?.Name}");
            var dictionary = students.ToIdDictionary();

            Console.WriteLine($"Dictionary count: {dictionary.Count}");
            Console.WriteLine($"Student with Id 4: {dictionary[4].Name}");
        }
    }
}