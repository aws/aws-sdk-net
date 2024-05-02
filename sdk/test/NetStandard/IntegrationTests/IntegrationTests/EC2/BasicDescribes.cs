using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;


using Amazon.EC2;
using Amazon.EC2.Model;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.EC2
{
    public class BasicDescribes : TestBase<AmazonEC2Client>
    {
        [Fact]
        public async Task TestDescribeAmazonImages()
        {
            // perform a filtered query to (a) test parameter marshalling
            // and (b) cut down the time to run -- an unfiltered request
            // yields a lot of images
            var request = new DescribeImagesRequest()
            {
                Owners = new List<string> { "amazon" }
            };
            var response = await Client.DescribeImagesAsync(request);

            Assert.NotNull(response);
            Assert.NotNull(response.Images);
        }
                
        [Fact]
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

            var exception = await Assert.ThrowsAsync<TaskCanceledException>(() =>
            {
                return Client.DescribeImagesAsync(request, token);
            });

            //Assert.Equal(token, exception.CancellationToken);
            Assert.True(exception.CancellationToken.IsCancellationRequested);

        }
    }
}
