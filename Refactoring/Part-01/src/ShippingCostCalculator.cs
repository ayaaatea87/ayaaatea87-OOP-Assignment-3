using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public class ShippingCostCalculator
    {
        private readonly IShippingCost _carrier ;
        public ShippingCostCalculator(IShippingCost carrier) 
        { 
            _carrier = carrier;
        }
        
        public decimal Calculate(decimal weightKg)
        {
            return _carrier.Calculate(weightKg);
        }
    }

}
