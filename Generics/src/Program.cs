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
            var studentStore = new Store<Student>();

            studentStore.Add(new Student { Id = 1, Name = "Aya" });
            studentStore.Add(new Student { Id = 2, Name = "Mona" });
            studentStore.Add(new Student { Id = 3, Name = "Sara" });
            studentStore.Add(new Student { Id = 4, Name = "Nour" });
            studentStore.Add(new Student { Id = 5, Name = "Laila" });

            var courseStore = new Store<Course>();

            courseStore.Add(new Course { Id = 1, Title = "C#", Price = 1500 });
            courseStore.Add(new Course { Id = 2, Title = ".NET", Price = 2000 });
            courseStore.Add(new Course { Id = 3, Title = "SQL", Price = 1200 });
            Console.WriteLine(studentStore.GetById(2)?.Name);
            Console.WriteLine(courseStore.GetById(1)?.Title);
            try
            {
                studentStore.Add(new Student { Id = 2, Name = "Duplicate" });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Page 2:");

            foreach (var student in studentStore.GetAll().Values.Page(2, 2))
            {
                Console.WriteLine(student.Name);
            }

            var courses = new List<Course>
             {
                 new Course { Id = 1, Title = "C#" },
                 new Course { Id = 2, Title = ".NET" }
             };

            var foundCourse = courses.FindById(2);

            Console.WriteLine(foundCourse?.Title);
        }
    }
}