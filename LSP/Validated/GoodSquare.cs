using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Validated
{
    public class GoodSquare:Shape
    {
        public int Witdh { get; set; }

        public double SquareArea()
        {

            return Witdh * 4;

        }



    }
}
