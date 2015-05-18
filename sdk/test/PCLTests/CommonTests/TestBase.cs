using Amazon;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests
{
    public static class TestSettings
    {
        public static AWSCredentials Credentials { get; set; }
        public static RegionEndpoint Endpoint { get; set; }
    }

    public class TestBase<TClient>
        where TClient : AmazonServiceClient
    {
        private TClient client;
        public TClient Client
        {
            get
            {
                if (client == null)
                {
                    client = Activator.CreateInstance(typeof(TClient),
                        TestSettings.Credentials, TestSettings.Endpoint) as TClient;
                }
                return client;
            }
            set
            {
                client = value;
            }
        }
    }
}
