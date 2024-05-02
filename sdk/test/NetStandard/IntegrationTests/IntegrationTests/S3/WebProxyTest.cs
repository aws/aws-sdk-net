using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Amazon.Runtime.Internal.Util;
using WebProxy = Amazon.Runtime.Internal.Util.WebProxy;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    //Test cases have been commented out as they require a proxy to be set.
    public class WebProxyTest 
    {
        public AmazonS3Client client = null;

        //[Fact]
        public void CreateClientUsingProxy()
        {
            var config = new AmazonS3Config
            {
                ProxyCredentials = new NetworkCredential("1", "1"),
                RegionEndpoint = RegionEndpoint.USEast1
            };
            config.SetWebProxy(new WebProxy("http://localhost:8888/"));
            client = new AmazonS3Client(config);
            ListBuckets();
        }

        //[Fact]
        public void CreateClientUsingProxyHostandPort()
        {
            client = new AmazonS3Client(new AmazonS3Config
            {
                ProxyHost = "127.0.0.1",
                ProxyPort = 8888,
                ProxyCredentials = new NetworkCredential("1", "1"),
                RegionEndpoint = RegionEndpoint.USEast1
            });
            ListBuckets();
        }

        //Fact]
        public void WebProxyPrecedenceSetting()
        {
            var config = new AmazonS3Config
            {
                ProxyHost = "127.0.0.1",
                ProxyPort = 0,
                ProxyCredentials = new NetworkCredential("1", "1"),
                RegionEndpoint = RegionEndpoint.USEast1,
                UseHttp = true
            };
            var customProxy = new WebProxy("http://localhost:8888/");
            config.SetWebProxy(customProxy);
            Assert.Equal(customProxy, config.GetWebProxy()); 
        }

        //[Fact]
        public void HostPortPrecedenceSetting()
        {
            var customProxy = new WebProxy("http://localhost:8889/");
            var config = new AmazonS3Config();
            config.SetWebProxy(customProxy);
            config.ProxyHost = "127.0.0.1";
            config.ProxyPort = 8888;
            config.ProxyCredentials = new NetworkCredential("1", "1");
            config.RegionEndpoint = RegionEndpoint.USEast1;
            
            var setProxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            config.SetWebProxy(setProxy);
            var c = config.GetWebProxy();
            Assert.Equal(setProxy, config.GetWebProxy());
        }

        public void ListBuckets()
        {
            var list = client.ListBucketsAsync().Result;
        }
    }
}
