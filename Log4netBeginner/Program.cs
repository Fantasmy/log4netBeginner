using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netBeginner
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger(); /*log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);*/
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //log.Error("This is an error message");
            //Console.ReadLine();
            XmlConfigurator.Configure();

            try
            {
                int a = 0, b = 1;

                log.Debug("Log Debug");
                log.Info("Log info");
                log.Warn("Log Warn");
                log.Fatal("Log Fatal");


                float c = b / a;

            }
            catch (Exception ex)
            {
                log.Error("some errro in the application ", ex);
            }
        }

      
    }
}
