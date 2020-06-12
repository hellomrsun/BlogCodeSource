using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var appName = ConfigurationManager.AppSettings["ApplicationName"];
            Console.WriteLine($"Application name is: {appName}.");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
