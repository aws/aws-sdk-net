using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public class TestBase<T>
        where T : AmazonServiceClient, new()
    {
        private static T client;
        public static T Client
        {
            get
            {
                if(client == null)
                {
                    client = CreateClient();
                    RetryUtilities.ConfigureClient(client);
                }
                return client;
            }
            set
            {
                client = value;
            }
        }

        public static void BaseClean()
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }
        }

        public static void SetEndpoint(AmazonServiceClient client, string serviceUrl, string region = null)
        {
            var clientConfig = client
                .GetType()
                .GetProperty("Config", BindingFlags.Instance | BindingFlags.Public)
                .GetValue(client, null) as ClientConfig;
            clientConfig.ServiceURL = serviceUrl;
            if (region != null)
                clientConfig.AuthenticationRegion = region;
        }

        public static T CreateClient()
        {
            return new T();
        }

        public static ServiceResponseCounter CountServiceResponses()
        {
            return CountServiceResponses(Client);
        }
        public static ServiceResponseCounter CountServiceResponses(AmazonServiceClient client)
        {
            return new ServiceResponseCounter(client);
        }

    }
}
