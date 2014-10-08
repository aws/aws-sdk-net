using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                    client = new T();
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
    }
}
