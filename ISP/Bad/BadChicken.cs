using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Bad
{
    public class BadChicken : IBird
    {
        public string fly()
        {
            return "Bu tavuk ucamaz.";
        }

        public string walk()
        {
            return "bu tavuk yuruyebilir.";
        }
    }
}
