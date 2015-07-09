using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            args = new string[]
            {
                //"CommonTests.IntegrationTests.DynamoDB.DynamoDBTests.TestUnsupportedTypesSync"
                //"TestITypeInfo"
                //"TestUnsupportedTypesSync"
            };

            bool allPassed;
            try
            {
                var runner = new ConsoleRunner();

                if (args != null && args.Length > 0)
                    runner.TestsToRun = new HashSet<string>(args, StringComparer.OrdinalIgnoreCase);

                allPassed = runner.ExecuteAllTests();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                allPassed = false;
            }

            Console.WriteLine("Test run complete!");
            return (allPassed ? 0 : 1);
        }
    }
}
