using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.Framework
{
    public class Console
    {
        public static void WriteLine(string format, params object[] args)
        {
            TestRunner.Instance.WriteToOutput(format, args);
        }

        public static void WriteLine(object format, params object[] args)
        {
            TestRunner.Instance.WriteToOutput(format.ToString(), args);
        }
    }
}
