using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Amazon.DNXCore.IntegrationTests
{    
    public static class AssertExtensions
    {
        public static void Fail()
        {
            throw new Exception("A test failed by invoking AssertExtensions.Fail().");
        }

        public static void Fail(string message)
        {
            throw new Exception(message);
        }

        public static T VerifyException<T>(AggregateException ae)
            where T : Exception
        {
            Assert.NotNull(ae);
            Assert.NotNull(ae.InnerExceptions);
            Assert.Single(ae.InnerExceptions);
            var inner = ae.InnerExceptions[0] as T;
            Assert.NotNull(inner);
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
                    Assert.Equal(message, e.Message);
            }

            Assert.True(gotException, "Failed to get expected exception");
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
                    Assert.Equal(message, e.Message);
            }

            Assert.True(gotException, "Failed to get expected exception");
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
                Assert.Equal(e.GetType(), exceptionType);
                if (!string.IsNullOrEmpty(message))
                    Assert.Equal(message, e.Message);
                gotException = true;
            }

            Assert.True(gotException, "Failed to get expected exception: " + exceptionType.FullName);
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
                Assert.Equal(e.GetType(), exceptionType);
                if (!string.IsNullOrEmpty(message))
                    Assert.Equal(message, e.Message);
                gotException = true;
            }

            Assert.True(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return (T)exception;
        }
    }
}
