using Solid.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Validated.Concrete
{
    public class Restorurant
    {
        private List<IProduct> products;



        public Restorurant(List<IProduct> products)
        {
            this.products = products;
        }

        public string GenerateInstructıons()
        {


            string ınstructıons = string.Empty;

            foreach (var item in products)
            {

                ınstructıons += item.GetCookingInstructıons();
            }


            return ınstructıons;
        }


    }
}
