using Solid.DIP.Validated.Abstract;
using Solid.DIP.Validated.Concrete;
using Solid.ISP.Validated.Concrete;
using Solid.LSP.Validated;
using Solid.OCP.Validated.Abstract;
using Solid.OCP.Validated.Concreate;
using Solid.SRP.Model;
using Solid.SRP.Validated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {

            //solid prensıblerı slid 5 onmeli prensbıbı bulunur 
            //temiz moduler gve genişletilebilir.kod yazımına oneml kurallar getitrir.
            //agıle adaptive yazılım geliştirme için kullanılır.



            Employee newemployee = new Employee();
            newemployee.Id = 1;
            newemployee.FirstName = "muhammet";
            newemployee.HireDate = new DateTime(1997, 1, 1);


            GoodEpmloyeeProcess processor = new GoodEpmloyeeProcess();
           // processor.InsertEmployee(newemployee) ? "Basarılır" : "Basarısız");

            //OCP==>OCP SINIFLAR VE METOTLAR GENİŞLETİLMETE ACIK DEGİŞKLİGE KAPALI OLMALIDIR HER IHTIYAC DUYDGUMUZDA YAZDIGIMIZ KODU DEGİŞTİRMEK ZORUND KALMAMAK ICIN ISLERIMIZI UZUN VADEDE RAHATLATIR.

            GoodCooffe kahve1 = new Espressp();
            GoodCooffe kahve2 = new Latte();
            GoodCooffe kahve3 = new Maccıato();
            double totalprice = 0;
            totalprice = kahve1.GetTotalPrice(20);
            Console.WriteLine("kahve fşyat:"+totalprice);
            totalprice = kahve2.GetTotalPrice(20);
            Console.WriteLine("kahve fşyat:" + totalprice);
            totalprice = kahve3.GetTotalPrice(20);
            Console.WriteLine("kahve fşyat:" + totalprice);

          



            GoodRectangle rectangle = new GoodRectangle();
            rectangle.Height = 10;
            rectangle.Width = 15;
            Console.WriteLine(rectangle.RectangleArea());

            GoodSquare square = new GoodSquare();
             square.Witdh = 10;
            
            Console.WriteLine(square.SquareArea());





            //Isp=>ınterface Seqragatıon princeble



            Chicken tavuk = new Chicken();
            Console.WriteLine(tavuk.Walk());
            Hawk kartal = new Hawk();
            Console.WriteLine(kartal.Fly()) ;
            Console.WriteLine( kartal.Walk());












            //DİP=>dependenciy ınversion Principle
            //ust seviye sınıflar alt sevıye sınıflara bagımlı olmamalıdır.,

            List<IProduct> ürünler = new List<IProduct>();

            GoodFish fsh = new GoodFish();
            Poultry duck = new Poultry();
            Et kofte = new Et();

            ürünler.Add(fsh);
            ürünler.Add(duck);
            ürünler.Add(kofte);


            Restorurant rst = new Restorurant(ürünler);

            Console.WriteLine(rst.GenerateInstructıons()); 









            Console.ReadLine();


        }
    }
}
