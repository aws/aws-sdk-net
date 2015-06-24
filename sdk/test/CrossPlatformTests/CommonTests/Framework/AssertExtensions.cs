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
        public static async Task ExpectExceptionAsync(Task task)
        {
            bool gotException = false;
            try
            {
                await task;
            }
            catch (Exception)
            {
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception");
        }

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


        public static Task<T> ExpectExceptionAsync<T>(Task task) where T : Exception
        {
            return ExpectException_HelperAsync<T>(task);
        }

        public static T ExpectException<T>(Action action) where T : Exception
        {
            return ExpectException_Helper<T>(action);
        }


        private static T ExpectException_Helper<T>(Action action) where T : Exception
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
                Assert.AreEqual(e.GetType(), exceptionType);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return (T)exception;
        }
        private static async Task<T> ExpectException_HelperAsync<T>(Task task) where T : Exception
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
                Assert.AreEqual(e.GetType(), exceptionType);
                gotException = true;
            }

            Assert.IsTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return (T)exception;
        }
    }
}
