using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Validated
{
    public class GoodRectangle:Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RectangleArea()
        {


            return Width * Height;
        }


    }
}
