using UnityEngine;
using System.Collections;
using Amazon;
using Amazon.Runtime;
using System;

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

    public abstract class TestBase<T> : TestBase where T : AmazonServiceClient
    {
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

        public static void RunAsSync(Action action)
        {
            
        }
    }
}
