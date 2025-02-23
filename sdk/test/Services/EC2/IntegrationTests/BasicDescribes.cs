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
using System.Net;

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
            var request = new DescribeImagesRequest()
            {
                Owners = new List<string> { "amazon" }
            };
            var response = Client.DescribeImages(request);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Images);
        }

        [TestMethod]
        [TestCategory("EC2")]
        public void TestDescribeAmazonImagesWithDryRun()
        {
            var request = new DescribeImagesRequest()
            {
                DryRun = true,
                Owners = new List<string> { "amazon" },
            };
            
            var assertedException = Assert.ThrowsException<AmazonEC2Exception>( () => {
                Client.DescribeImages(request);
            });
            
            Assert.AreEqual(HttpStatusCode.PreconditionFailed, assertedException.StatusCode);
            Assert.AreEqual("DryRunOperation", assertedException.ErrorCode);
        }

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("EC2")]
        public async System.Threading.Tasks.Task TestDescribeAmazonImagesCancellationTest()
        {
            // perform a filtered query to (a) test parameter marshalling
            // and (b) cut down the time to run -- an unfiltered request
            // yields a lot of images
            var request = new DescribeImagesRequest()
            {
                Owners = new List<string> { "amazon" }
            };

            var cts = new CancellationTokenSource();
            cts.CancelAfter(1000);
            var token = cts.Token;
            try
            {
                var response = await Client.DescribeImagesAsync(request,token);
            }
            catch (OperationCanceledException exception)
            {
                Assert.AreEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
                return;
            }            
            Assert.Fail("An OperationCanceledException was not thrown");
        }
#endif
    }
}
