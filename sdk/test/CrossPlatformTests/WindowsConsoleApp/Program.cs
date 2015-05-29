using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var runner = new ConsoleRunner();
                runner.ExecuteAllTests();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
