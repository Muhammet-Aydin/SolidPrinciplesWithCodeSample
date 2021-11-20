using Solid.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Validated
{
    public class GoodEpmloyeeProcess
    {

        Logger logger;
        string log;

        public GoodEpmloyeeProcess()
        {
            logger = new Logger();
        }


        //gordugunuz uzerere ınsertemployee sadece veri girişinden sorumluhale geldi.
        //son adım olarak buradakı metodu bıze bilgi verekcek sekılde guncelleyelim.
        //bool tipine cevirererk eklenen yazdırma kodunu siliniz.
        //unıt test ıcın faydalıdır.
        public bool InsertEmployee(Employee newemployee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                sb.Append(newemployee.Id);
                sb.AppendLine();
                sb.Append(newemployee.FirstName);
                sb.AppendLine();
                sb.Append(newemployee.Lastname);
                sb.AppendLine();
                sb.Append(newemployee.HireDate);
                sb.AppendLine();


               

                sb = new StringBuilder();
                sb.Append("KAyıt EKlemeTarihi");
                sb.Append(DateTime.Now.ToString());

        
               

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }




        }
    
    }
}
