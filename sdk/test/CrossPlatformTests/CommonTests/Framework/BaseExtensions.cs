using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.Framework
{
    public static class EncodingExtensions
    {
        public static string GetString(this Encoding self, byte[] bytes)
        {
            return self.GetString(bytes, 0, bytes.Length);
        }
    }

    public static class ITestResultExtensions
    {
        public static bool HasTestSucceeded(this ITestResult self)
        {
            if (self == null) throw new ArgumentNullException("self");

            var testSucceeded =
                self.FailCount == 0 &&
                self.InconclusiveCount == 0 &&
                self.SkipCount == 0;

            return testSucceeded;
        }
    }
}
