using Amazon.EC2;
using Amazon.EC2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    [TestClass]
    [TestCategory("EC2")]
    public class BasicDescribes : TestBase<AmazonEC2Client>
    {
        [TestMethod]
        public async Task TestDescribeAmazonImages()
        {
            // perform a filtered query to cut down the time to run -- an unfiltered request
            // yields a lot of images.
            var request = new DescribeImagesRequest
            {
                Owners = new List<string> { "amazon" },
                MaxResults = 10,
            };

            var response = await Client.DescribeImagesAsync(request);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Images);
        }

        [TestMethod]
        public async Task TestDescribeAmazonImagesWithDryRun()
        {
            var request = new DescribeImagesRequest
            {
                DryRun = true,
                Owners = new List<string> { "amazon" },
            };

            var assertedException = await Assert.ThrowsExceptionAsync<AmazonEC2Exception>(() => Client.DescribeImagesAsync(request));
            Assert.AreEqual(HttpStatusCode.PreconditionFailed, assertedException.StatusCode);
            Assert.AreEqual("DryRunOperation", assertedException.ErrorCode);
        }

        [TestMethod]
        public async Task TestDescribeAmazonImagesCancellationTest()
        {
            // perform a filtered query to cut down the time to run -- an unfiltered request
            // yields a lot of images.
            var request = new DescribeImagesRequest
            {
                Owners = new List<string> { "amazon" }
            };

            var cts = new CancellationTokenSource();
            cts.CancelAfter(1000);
            var token = cts.Token;
            try
            {
                await Client.DescribeImagesAsync(request, token);
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
