using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.Framework
{
    public static class AssertExtensions
    {
        public static T VerifyException<T>(AggregateException ae)
            where T : Exception
        {
            Assert.IsNotNull(ae);
            Assert.IsNotNull(ae.InnerExceptions);
            Assert.AreEqual(1, ae.InnerExceptions.Count);
            var inner = ae.InnerExceptions[0] as T;
            Assert.IsNotNull(inner);
            return inner;
        }

        public static async Task ExpectExceptionAsync(Task task, string message = null)
        {
            bool gotException = false;
            try
            {
                await task;
            }
            catch (Exception e)
            {
                gotException = true;
                if (!string.IsNullOrEmpty(message))
                    Assert.AreEqual(message, e.Message);
            }

            Assert.IsTrue(gotException, "Failed to get expected exception");
        }

        public static void ExpectException(Action action, string message = null)
        {
            bool gotException = false;
            try
            {
                action();
            }
            catch (Exception e)
            {
                gotException = true;
                if (!string.IsNullOrEmpty(message))
                    Assert.AreEqual(message, e.Message);
            }

            Assert.IsTrue(gotException, "Failed to get expected exception");
        }


        public static Task<T> ExpectExceptionAsync<T>(Task task, string message = null) where T : Exception
        {
            return ExpectException_HelperAsync<T>(task, message);
        }

        public static T ExpectException<T>(Action action, string message = null) where T : Exception
        {
            return ExpectException_Helper<T>(action, message);
        }


        private static T ExpectException_Helper<T>(Action action, string message = null) where T : Exception
        {
            var exceptionType = typeof(T);
            bool gotException = false;
            Exception exception = null;
            try
            {
                action();
            }
            catch (Exception e)
            {
                exception = e;
                Assert.AreEqual(exceptionType, e.GetType());
                if (!string.IsNullOrEmpty(message))
                    Assert.AreEqual(message, e.Message);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return (T)exception;
        }
        private static async Task<T> ExpectException_HelperAsync<T>(Task task, string message = null) where T : Exception
        {
            var exceptionType = typeof(T);
            bool gotException = false;
            Exception exception = null;
            try
            {
                await task;
            }
            catch (Exception e)
            {
                exception = e;
                Assert.AreEqual(exceptionType, e.GetType());
                if (!string.IsNullOrEmpty(message))
                    Assert.AreEqual(message, e.Message);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return (T)exception;
        }
    }
}
