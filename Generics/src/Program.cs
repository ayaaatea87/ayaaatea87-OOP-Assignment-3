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
            var store = new StudentStore();

            store.Add(new Student { Id = 1, Name = "Aya" });
            store.Add(new Student { Id = 2, Name = "Mona" });

            var student = store.GetById(2);
            Console.WriteLine(student.Name);

            var courseStore = new CourseStore();

            courseStore.Add(new Course
            {
                Id = 1,
                Title = "C#",
                Price = 1500
            });

            var course = courseStore.GetById(1);

            Console.WriteLine(course?.Title);
            Console.WriteLine(course?.Price);

            
        }
    }
}