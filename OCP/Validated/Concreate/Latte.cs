using Solid.OCP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Validated.Concreate
{
    public class Latte : GoodCooffe
    {
        public override double GetTotalPrice(double amount)
        {
           return amount * 6;
        }
    }
}
