using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using NUnit.Framework;
using CommonTests.Framework;

using Amazon.EC2;
using Amazon.EC2.Model;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestFixture]
    public class BasicDescribes : TestBase<AmazonEC2Client>
    {
        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("EC2")]
        public void TestDescribeAmazonImages()
        {
            // perform a filtered query to (a) test parameter marshalling
            // and (b) cut down the time to run -- an unfiltered request
            // yields a lot of images
            var request = new DescribeImagesRequest();
            request.Owners.Add("amazon");
            var response = Client.DescribeImagesAsync(request).Result;

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Images);
        }

        //[Test]
        [Category("EC2")]
        public async System.Threading.Tasks.Task TestDescribeAmazonImagesCancellationTest()
        {
            // perform a filtered query to (a) test parameter marshalling
            // and (b) cut down the time to run -- an unfiltered request
            // yields a lot of images
            var request = new DescribeImagesRequest();
            request.Owners.Add("amazon");

            var cts = new CancellationTokenSource();
            cts.CancelAfter(1000);
            var token = cts.Token;
            try
            {
                var response = await Client.DescribeImagesAsync(request, token);
            }
            catch (OperationCanceledException exception)
            {
                Assert.AreEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
                return;
            }
            Assert.Fail("An OperationCanceledException was not thrown");
        }
    }
}
