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
            var store = new Store<Student>();

            store.Add(new Student
            {
                Id = 1,
                Name = "Aya"
            });

            store.Add(new Student
            {
                Id = 2,
                Name = "Mona"
            });

            var student = store.GetById(2);

            Console.WriteLine(student?.Name);

            try
            {
                store.Add(new Student
                {
                    Id = 2,
                    Name = "Sara"
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}