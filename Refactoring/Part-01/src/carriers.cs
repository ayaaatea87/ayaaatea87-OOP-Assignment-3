using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public class AramexCarrier : IShippingCost
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 12m;
        }
    }

    public class FedExCarrier : IShippingCost
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 15m;
        }
    }

    public class DHLCarrier : IShippingCost
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 18m;
        }
    }

}
