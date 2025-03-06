using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class RegionEndpointTests
    {

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Util")]
        [DataRow("https://helloworld.com/", "https://helloworld.com/")]
        [DataRow("https://helloworld.com", "https://helloworld.com/")]
        [DataRow("https://helloworld.com/Prod", "https://helloworld.com/Prod")]
        [DataRow("https://helloworld.com/Prod/", "https://helloworld.com/Prod/")]
        [DataRow(null, null)]
        public void CorrectTrailingSlashesForServiceUrl(string given, string expected)
        {
            var config = new Amazon.DynamoDBv2.AmazonDynamoDBConfig();

            config.ServiceURL = given;

            var actual = config.ServiceURL;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidSeviceUrl()
        {
            var config = new Amazon.DynamoDBv2.AmazonDynamoDBConfig();

            var exception = Assert.ThrowsException<Amazon.Runtime.AmazonClientException>(() => config.ServiceURL = "fnoeiw;gh903ht9034gnofn");
            Assert.AreEqual("Value for ServiceURL is not a valid URL: fnoeiw;gh903ht9034gnofn", exception.Message);
        }
    }
}
