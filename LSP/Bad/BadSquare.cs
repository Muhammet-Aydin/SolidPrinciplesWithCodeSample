using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Bad
{
    //karelerde birer 4 gen oldukları ıcın alttak yonetmı ızlemek yanlıs olamyacaktır  fakat 4gen yerıne kare sınfını kullandıgınızda ıslemler ıstedıgınız gibi sonuclanmayacaktır.bunun nedenı kodun yazım bııcımı soıd prensıplerıne uymamktır.
    public class BadSquare:BadRectangle
    {
        int _height;
        int _width;

        public override int Height
        {
            get { return _height; }

            set
            {
                _height = value;
                _width = value;
            }

        }
        public override int Width
        {
            get { return _width; }
            set
            {
                _height = value;
                _width = value;
            }


        }
    }





}
