using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gruppövning
{
    public class ExceptionHelper
    {
        //try
        //{
        //
        //}
        //catch (Exception exception)
        //    {
        //        WriteToLogFile(exception);
        //    }

        public ExceptionHelper()
        {

        }

       public void WriteToLogFile(Exception exception)
        {
            string filePath = @"C:\Error.txt";

            using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine("=============Error Logging ===========");
                    writer.WriteLine("===========Start============= " + DateTime.Now);
                    writer.WriteLine("Error Message: " + exception.GetType().ToString());
                    writer.WriteLine("===========End============= " + DateTime.Now);
                }

        }
    }
}
