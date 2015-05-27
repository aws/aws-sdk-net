using CommonTests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConsoleApp
{
    public class ConsoleRunner : TestRunner
    {
        public ConsoleRunner()
            : base(File.OpenRead(@".\Assets\credentials.json"))
        {
        }
    }
}
