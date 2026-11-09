using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public class SqlOrderRepository:IOrderRepositry
    {
        public void Save(int orderId, DateTime processedAt) =>
            Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }
}
