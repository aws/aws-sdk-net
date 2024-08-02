using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal;
using Amazon.Util;

using Amazon.EC2;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class ProxyTests
    {
        readonly string EnvironmentVariableUrl = "http://user:pass@10.0.0.2:21/proxy";
        readonly string EnvironmentVariableUrlWithoutHttp = "user:pass@10.0.0.2:21/proxy";
        readonly string Host = "10.0.0.1";
        readonly int Port = 20;
        readonly List<string> BypassList = new List<string>
        {
            "test.domain.com",
            "other.domain.com"
        };

#if BCL
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestProxySetupHostAndPortOnly()
        {
            var dummyConfig = new AmazonEC2Config();

            dummyConfig.ProxyHost = Host;
            dummyConfig.ProxyPort = Port;

            WebProxy proxy = dummyConfig.GetWebProxy();
            var address = proxy.Address;
            Assert.AreEqual(address.Host, Host);
            Assert.AreEqual(address.Port, Port);
            Assert.AreEqual(0, proxy.BypassList.Length);
            Assert.IsFalse(proxy.BypassProxyOnLocal);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestProxySetupWithBypass()
        {
            var dummyConfig = new AmazonEC2Config();

            dummyConfig.ProxyHost = Host;
            dummyConfig.ProxyPort = Port;

            dummyConfig.ProxyBypassList = new List<string>(BypassList);
            dummyConfig.ProxyBypassOnLocal = true;

            WebProxy proxy = dummyConfig.GetWebProxy();
            Assert.AreEqual(BypassList.Count, proxy.BypassList.Length);
            // making assumption here that order is retained on assignment 
            // inside WebProxy - seems to be the case
            for (int i = 0; i < BypassList.Count; i++)
            {
                Assert.AreEqual(BypassList[i], proxy.BypassList[i]);
            }

            Assert.IsTrue(proxy.BypassProxyOnLocal);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestProxySetupWithSchemedHost()
        {
            // verifies bug fix that the http:// scheme is not doubled 
            // up in the proxy address if the user specifies it when setting
            // proxy host (the bug yielded an address like http://http/host)

            var dummyConfig = new AmazonEC2Config();

            var host = string.Concat("http://", Host);
            dummyConfig.ProxyHost = host;
            dummyConfig.ProxyPort = Port;

            WebProxy proxy = dummyConfig.GetWebProxy();
            Assert.IsTrue(proxy.Address.ToString().StartsWith(host, StringComparison.OrdinalIgnoreCase));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestParsingCredentialsOverEnvironmentVariable()
        {
            var cachedHttpProxy = Environment.GetEnvironmentVariable("http_proxy");

            try
            {
                Environment.SetEnvironmentVariable("http_proxy", EnvironmentVariableUrl);

                var dummyConfig = new AmazonEC2Config();
                IWebProxy proxy = dummyConfig.GetHttpProxy();

                var address = proxy.GetProxy(new Uri("https://ec2.us-west-2.aws.amazon.com"));
                Assert.AreEqual(address.Host, "10.0.0.2");
                Assert.AreEqual(address.Port, 21);
                Assert.IsNotNull(proxy.Credentials);
            }
            finally
            {
                Environment.SetEnvironmentVariable("http_proxy", cachedHttpProxy);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestParsingCredentialsOverEnvironmentVariableWithoutHttp()
        {
            var cachedHttpProxy = Environment.GetEnvironmentVariable("http_proxy");

            try
            {
                Environment.SetEnvironmentVariable("http_proxy", EnvironmentVariableUrlWithoutHttp);

                var dummyConfig = new AmazonEC2Config();
                IWebProxy proxy = dummyConfig.GetHttpProxy();

                var address = proxy.GetProxy(new Uri("https://ec2.us-west-2.aws.amazon.com"));
                Assert.AreEqual(address.Scheme, "http");
                Assert.AreEqual(address.Host, "10.0.0.2");
                Assert.AreEqual(address.Port, 21);
                Assert.IsNotNull(proxy.Credentials);
            }
            finally
            {
                Environment.SetEnvironmentVariable("http_proxy", cachedHttpProxy);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestProxyOverridingEnvironmentVariables()
        {
            var cachedHttpProxy = Environment.GetEnvironmentVariable("http_proxy");
            var cachedHttpsProxy = Environment.GetEnvironmentVariable("https_proxy");

            try
            {
                Environment.SetEnvironmentVariable("http_proxy", EnvironmentVariableUrl);
                Environment.SetEnvironmentVariable("https_proxy", EnvironmentVariableUrl);

                var dummyConfig = new AmazonEC2Config();
                dummyConfig.ProxyHost = Host;
                dummyConfig.ProxyPort = Port;

                IWebProxy httpProxy = dummyConfig.GetHttpProxy();
                var httpAddress = httpProxy.GetProxy(new Uri("https://ec2.us-west-2.aws.amazon.com"));
                Assert.AreEqual(httpAddress.Host, Host);
                Assert.AreEqual(httpAddress.Port, Port);

                IWebProxy httpsProxy = dummyConfig.GetHttpsProxy();
                var httpsAddress = httpsProxy.GetProxy(new Uri("https://ec2.us-west-2.aws.amazon.com"));
                Assert.AreEqual(httpsAddress.Host, Host);
                Assert.AreEqual(httpsAddress.Port, Port);
            }
            finally
            {
                Environment.SetEnvironmentVariable("http_proxy", cachedHttpProxy);
                Environment.SetEnvironmentVariable("https_proxy", cachedHttpsProxy);
            }
        }
#endif
    }
}
                                                         