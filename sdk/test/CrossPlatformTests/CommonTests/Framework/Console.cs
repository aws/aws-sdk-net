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
        public static void WriteLine()
        {
            TestRunner.Instance.WriteVerbose(Environment.NewLine);
        }
        public static void WriteLine(object value)
        {
            TestRunner.Instance.WriteVerbose("{0}", value);
        }
        public static void WriteLine(string format, params object[] args)
        {
            TestRunner.Instance.WriteVerbose(format, args);
        }

        public static void WriteError(string format, params object[] args)
        {
            TestRunner.Instance.WriteError(format, args);
        }
    }
}
