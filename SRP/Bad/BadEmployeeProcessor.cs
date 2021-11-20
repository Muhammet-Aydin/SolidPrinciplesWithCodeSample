using Solid.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Bad
{
    public class BadEmployeeProcessor
    {

        public void InsertEmployee(Employee newemployee)
        {        StringBuilder sb = new StringBuilder();
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


                File.WriteAllText(@"C:\Users\Aydın\Desktop\test.Employee.txt", sb.ToString());

                sb = new StringBuilder();
                sb.Append("KAyıt EKlemeTarihi");
                sb.Append(DateTime.Now.ToString());

                File.WriteAllText(@"C:\Users\Aydın\Desktop\test.Log.txt", sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }




        }
    }
}
