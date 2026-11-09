using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01012345678".IsValidEgyptianPhone());      // True
            Console.WriteLine("01312345678".IsValidEgyptianPhone());      // False

            Console.WriteLine("29901011234567".IsValidEgyptianNationalId()); // True
            Console.WriteLine("19901011234567".IsValidEgyptianNationalId()); // False

        }
    }
}
