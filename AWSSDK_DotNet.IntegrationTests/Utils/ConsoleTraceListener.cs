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
        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}