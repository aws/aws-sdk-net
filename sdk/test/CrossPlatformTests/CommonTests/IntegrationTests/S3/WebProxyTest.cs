using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Amazon.S3;
using PCLStorage;
using CommonTests.Framework;
using Amazon.S3.Model;
using System.Net;
using System.Threading;
using System.IO;
using Amazon;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime;
namespace CommonTests.IntegrationTests.S3
{
    [TestFixture]
    //Test cases have been commented out as they require a proxy to be set.
    //These test cases would be commented out, when the proxy support for PCL is shipped out
    public class WebProxyTest : TestBase<AmazonS3Client>
    {

        //private static string basePath = @"c:\temp\test\transferutility\";
        //private static string bucketName;
        //private static string fullPath;
        private const string testContent = "This is the content body!";
        private const string testFile = "PutObjectFile.txt";
        public AmazonS3Client client = null;
        
        //In this test a S3ListBucket operation is executed over a Proxy URL
        //[Test]
        //[Category("S3PCLProxy")]
        public void CreateClientUsingProxy()
        {
            var config = new AmazonS3Config
            {
                ProxyCredentials = new NetworkCredential("1", "1"),
                RegionEndpoint = RegionEndpoint.USEast1
            };
            
            config.SetWebProxy(new WebProxy("http://localhost:8888/"));
            client = new AmazonS3Client("access key", "access Password", config);
            ListBuckets();
        }

        //In this test a S3ListBucket operation is executed over a ProxyHost and a ProxyPort
        //[Test]
        //[Category("S3PCLProxy")]
        public void CreateClientUsingProxyHostandPort()
        {
            client = new AmazonS3Client("access key", "access Password", new AmazonS3Config
            {
                ProxyHost = "127.0.0.1",
                ProxyPort = 8888,
                ProxyCredentials = new NetworkCredential("1", "1"),
                RegionEndpoint = RegionEndpoint.USEast1
            });
            ListBuckets();
        }

        //In this test we check if the proxy setting set last persists.
        //In this test case it is the Proxy URL
        //[Test]
        //[Category("S3PCLProxy")]
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
            Assert.AreEqual(customProxy, config.GetWebProxy());
        }

        //In this test we check if the proxy setting set last persists.
        //In this test case it is the ProxyPort and ProxyHost.
        //[Test]
        //[Category("S3PCLProxy")]
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
            Assert.AreEqual(setProxy, config.GetWebProxy());
        }

        public void ListBuckets()
        {
            var list = client.ListBucketsAsync().Result;
        }
    }
}
