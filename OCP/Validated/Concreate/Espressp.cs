using Solid.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Validated.Concreate
{
    public class Espressp : GoodCooffe
    {
        public override double GetTotalPrice(double amount)
        {
            
            return amount * 4.5;
        }
    }
}
