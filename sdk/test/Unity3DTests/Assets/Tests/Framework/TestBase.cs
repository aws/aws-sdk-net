using UnityEngine;
using System.Collections;
using Amazon;
using Amazon.Runtime;
using System;
using System.Threading;
using NUnit.Framework;

namespace AWSSDK.Tests.Framework
{
    public abstract class TestBase
    {
        public TestBase()
        {
        }

        public static TClient CreateClient<TClient>(AWSCredentials credentials = null, RegionEndpoint endpoint = null)
            where TClient : AmazonServiceClient
        {
            credentials = credentials ?? TestRunner.Credentials;
            endpoint = endpoint ?? TestRunner.RegionEndpoint;

            return (TClient)Activator.CreateInstance(typeof(TClient),
                    new object[] { TestRunner.Credentials, endpoint });
        }
    }

    public abstract class TestBase<T> : TestBase where T : AmazonServiceClient, IDisposable
    {
        private bool _disposed = false;
        protected static AsyncOptions options = new AsyncOptions() { ExecuteCallbackOnMainThread = false };

        private T _client = null;
        public T Client
        {
            get
            {
                if (_client == null)
                {
                    _client = CreateClient<T>(endpoint: ActualEndpoint);
                }
                return _client;
            }
        }

        protected virtual RegionEndpoint AlternateEndpoint
        {
            get
            {
                return null;
            }
        }

        protected RegionEndpoint ActualEndpoint
        {
            get
            {
                return (AlternateEndpoint ?? TestRunner.RegionEndpoint);
            }
        }

        public static void WaitUntil(Func<bool> matchFunction, int sleepSeconds = 5, int maxWaitSeconds = 300)
        {
            if (sleepSeconds < 0) throw new ArgumentOutOfRangeException("sleepSeconds");
            if (maxWaitSeconds < 0) throw new ArgumentOutOfRangeException("maxWaitSeconds");

            var sleepTime = TimeSpan.FromSeconds(sleepSeconds);
            var maxTime = TimeSpan.FromSeconds(maxWaitSeconds);
            var endTime = DateTime.Now + maxTime;

            while (DateTime.Now < endTime)
            {
                if (matchFunction())
                    return;
                Thread.Sleep(sleepTime);
            }

            throw new TimeoutException(string.Format("Wait condition was not satisfied for {0} seconds", maxWaitSeconds));
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

            Utils.AssertTrue(gotException, "Failed to get expected exception: " + exceptionType.FullName);
            return (T)exception;
        }
        #region IDispose implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _disposed = true;
            }
        }

        #endregion
    }
}
