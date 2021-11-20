using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Bad
{
    public class BadRestourant
    {

        //restourant sınıfı hgh level bir moduldur yalnız lo level modullerden fısh ve poultry sınıflarına bagımlıdır.

        //dependenciy ınversion prensipbine göre degişiklikleri gerceklestırelım.

        BadFish tune = new BadFish();
        BadPoultry duck = new BadPoultry();


        public string GenerateIbstructıons()//talimat olusturdum.
        {
            return tune.GetFishCookingInstructıons() + " " + duck.GetPoultryCookingInstructıons();
        }
    }
}
