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

            studentStore.Add(new Student
            {
                Id = 2,
                Name = "Mona"
            });

            var student = studentStore.GetById(2);

            Console.WriteLine($"Student: {student?.Name}");


            var courseStore = new Store<Course>();

            courseStore.Add(new Course
            {
                Id = 1,
                Title = "C#",
                Price = 1500
            });

            var course = courseStore.GetById(1);

            Console.WriteLine($"Course: {course?.Title}");

        }
    }
}