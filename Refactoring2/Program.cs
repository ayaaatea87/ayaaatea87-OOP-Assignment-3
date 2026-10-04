using Refactoring2.Part_02.src;
using Refactoring2.Part_02.src.Enrollment;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Reports ===");
            var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
            Directory.CreateDirectory(outDir);

            new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
            new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
            new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
            Console.WriteLine($"Wrote reports to {outDir}");
            Console.WriteLine();

            Console.WriteLine("=== Enrollment ===");

            var studentId = "S100";
            var courseId = "CS201";
            var amount = 1500m;

            var enrollment = new EnrollmentFacade();

            enrollment.Enroll(studentId, courseId, amount);

        }
    }
}
