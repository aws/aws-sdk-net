using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Utils
{
    public static class AssertExtensions
    {
        public static Exception ExpectException(Action action)
        {
            bool gotException = false;
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                gotException = true;
                exception = e;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception");
            return exception;
        }

        public static Exception ExpectException(Action action, Type exceptionType)
        {
            bool gotException = false;
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e;
                Assert.AreEqual(e.GetType(), exceptionType);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return exception;
        }

        public static T ExpectException<T>(Action action) where T : Exception
        {
            var exceptionType = typeof(T);
            return (T)ExpectException(action, exceptionType);
        }

        public static void ExpectException(Action action, Type exceptionType, string exceptionMessage)
        {
            bool gotException = false;
            try
            {
                action();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.GetType(), exceptionType);
                Assert.AreEqual(e.Message, exceptionMessage);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
        }
    }
}
