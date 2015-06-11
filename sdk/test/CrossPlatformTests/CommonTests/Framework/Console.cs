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
            TestRunner.Instance.WriteVerbose(format, LogLevel.Verbose, args);
        }

        public static void WriteLine(object format, params object[] args)
        {
            TestRunner.Instance.WriteVerbose(format.ToString(), args);
        }

        public static void WriteError(object format, params object[] args)
        {
            TestRunner.Instance.WriteError(format.ToString(), args);
        }
    }
}
