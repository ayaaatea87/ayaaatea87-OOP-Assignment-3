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

            studentStore.Add(new Student
            {
                Id = 1,
                Name = "Aya"
            });

            var courseStore = new Store<Course>();

            courseStore.Add(new Course
            {
                Id = 1,
                Title = "C#",
                Price = 1500
            });

            Console.WriteLine(studentStore.GetAll().Count);
            Console.WriteLine(courseStore.GetAll().Count);


        }
    }
}