using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Bad
{

    public class BadHawk : IBird
    {
        public string fly()
        {
            return "Bu SAhin ucabilir.";
        }

        public string walk()
        {
            return "Bu sahın yuruyemez.";
        }
    }
}
