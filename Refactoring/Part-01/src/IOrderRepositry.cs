using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public interface IOrderRepositry
    {
        void Save(int orderId, DateTime processedAt);
    }
}
