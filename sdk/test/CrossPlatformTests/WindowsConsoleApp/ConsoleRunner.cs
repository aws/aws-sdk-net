using CommonTests;
using CommonTests.Framework;
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
            : base()
        {
        }

        //public override ITestListener Listener
        //{
        //    get
        //    {
                
        //    }
        //}

        protected override void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }

        protected override string TestTypeNamePrefix
        {
            get { return "WindowsConsoleApp"; }
        }
    }
}
