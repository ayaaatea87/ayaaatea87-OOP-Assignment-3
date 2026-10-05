using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public interface IShippingCost
    {
       decimal Calculate(decimal weightKg);
    }
}
