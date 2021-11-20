using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP.Bad
{
    public enum CooffeeType
    {
        Latte,Expresso,Maccıato,FiltreCoffee,

    }
    public class BadCoffee
    {
        public double GetTotalPrice(double amount,CooffeeType cooffeeType)
        {
            //burada daha fazla kahve cesiti eklenırse kodumuza bir tane daha else ıf blogu eklemnız gerekecektır her biri ıcın buda open closed presibini ihlal etmek demektır.
            double totalprice = 0;
            if (cooffeeType==CooffeeType.Expresso)
            {
                totalprice =amount*4.5;
            }
            else if(cooffeeType ==CooffeeType.FiltreCoffee)
            {
                totalprice = amount *5;
            }
            else if (cooffeeType==CooffeeType.Latte)
            {
                totalprice = amount * 6;

            }

            return totalprice;
        }



    }
}
