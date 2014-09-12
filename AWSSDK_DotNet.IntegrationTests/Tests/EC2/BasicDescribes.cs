using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.EC2;
using Amazon.EC2.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    public class BasicDescribes : TestBase<AmazonEC2Client>
    {
        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("EC2")]
        public void TestDescribeAmazonImages()
        {
            // perform a filtered query to (a) test parameter marshalling
            // and (b) cut down the time to run -- an unfiltered request
            // yields a lot of images
            var request = new DescribeImagesRequest();
            request.Owners.Add("amazon");
            var response = Client.DescribeImages();

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Images);
        }
    }
}
