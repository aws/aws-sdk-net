using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class AssertExtensions
    {
        public static void ExpectException(Action action)
        {
            bool gotException = false;
            try
            {
                action();
            }
            catch (Exception)
            {
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception");
        }

        public static void ExpectException(Action action, Type exceptionType)
        {
            bool gotException = false;
            try
            {
                action();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.GetType(), exceptionType);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
        }
    }
}
