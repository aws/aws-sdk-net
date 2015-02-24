using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    /// <summary>
    /// A TraceListener that writes to Console.
    /// 
    /// This implementation is not as efficient as System.Diagnostics.ConsoleTraceListener,
    /// but it works with test frameworks that modify Console.
    /// </summary>
    public class ConsoleTraceListener : TraceListener
    {
        private static string TimeStamp
        {
            get
            {
                var now = DateTime.Now;
                return now.ToString("HH:mm:ss:fffffff");
            }
        }

        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine(TimeStamp + " >>> " + message);
        }
    }
}