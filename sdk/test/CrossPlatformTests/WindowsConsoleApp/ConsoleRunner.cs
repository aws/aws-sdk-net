using CommonTests;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
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

        //public override ITestListener Listener
        //{
        //    get
        //    {
                
        //    }
        //}

        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }

    
}
