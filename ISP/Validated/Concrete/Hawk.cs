using Solid.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Validated.Concrete
{
    public class Hawk : IFlyBırd,IFlıghlessBırd
    {
        public string Fly()
        {
            return "Bu sahın ucar";
        }

        public string Walk()
        {
            return "Bu sahın yuruyebilirde";
        }
    }
}
