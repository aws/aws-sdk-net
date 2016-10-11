using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
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
#endif
    }
}
                                                         