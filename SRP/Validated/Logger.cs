using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Validated
{
    public class Logger
    {
        public void LogFile(string filePath,string log)
        {
            File.WriteAllText(filePath, log);
        }



    }
}
