using Solid.ISP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Validated.Concrete
{
    public class Chicken : IFlıghlessBırd
    {
        public string Walk()
        {
            return "Bu tavuk yurur.";
        }
    }
}
