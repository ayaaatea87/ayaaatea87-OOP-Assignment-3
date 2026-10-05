using  Refactoring3.Part_03.BlockedUsers;
using Refactoring3.Part_03.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Blocked users ===");
            const int blockedCount = 50_000;
            const int requestCount = 5_000;
            var blockedIds =new HashSet<int>(BlockedUserChecker.BuildBlockedIds(blockedCount));
            var requestIds = BlockedUserChecker.BuildRequestIds(requestCount, blockedCount);
            var ms = BlockedUserChecker.MeasureMs(blockedIds, requestIds, out var found);
            Console.WriteLine($"blockedIds={blockedCount}, requests={requestCount}, found={found}, time={ms} ms");
            Console.WriteLine();

            Console.WriteLine("=== Students (1_000_000) ===");
            var printed = 0;
            foreach (var student in StudentCatalog.GetAllStudents())
            {
                Console.WriteLine($"{student.Id}: {student.Name}");
                printed++;
                if (printed == 3)
                    break;
            }
            Console.WriteLine($"printed={printed}");

        }
    }
}
