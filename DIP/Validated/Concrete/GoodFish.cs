using Solid.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Validated.Concrete
{
    public class GoodFish : IProduct

    {
        public string GetCookingInstructıons()
        {
            return "Balık hayvanı";
        }
    }
}
