using Amazon.EC2;
using Amazon.EC2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.EC2
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonEC2Client"/> for the lifetime
    /// of the EC2 test classes.
    /// </summary>
    public class EC2ClientFixture : IAsyncLifetime
    {
        public AmazonEC2Client Client { get; private set; }

        public ValueTask InitializeAsync()
        {
            Client = new AmazonEC2Client();
            RetryUtilities.ConfigureClient(Client);
            return default;
        }

        public ValueTask DisposeAsync()
        {
            Client?.Dispose();
            return default;
        }
    }

    [Trait("Category", "EC2")]
    public class BasicDescribes : IClassFixture<EC2ClientFixture>
    {
        private readonly AmazonEC2Client _client;

        public BasicDescribes(EC2ClientFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task TestDescribeAmazonImages()
        {
            // perform a filtered query to cut down the time to run -- an unfiltered request
            // yields a lot of images.
            var request = new DescribeImagesRequest
            {
                Owners = new List<string> { "amazon" },
                MaxResults = 10,
            };

            var response = await _client.DescribeImagesAsync(request);
            Assert.NotNull(response);
            Assert.NotNull(response.Images);
        }

        [Fact]
        public async Task TestDescribeAmazonImagesWithDryRun()
        {
            var request = new DescribeImagesRequest
            {
                DryRun = true,
                Owners = new List<string> { "amazon" },
            };

            var assertedException = await Assert.ThrowsAsync<AmazonEC2Exception>(() => _client.DescribeImagesAsync(request));
            Assert.Equal(HttpStatusCode.PreconditionFailed, assertedException.StatusCode);
            Assert.Equal("DryRunOperation", assertedException.ErrorCode);
        }

        [Fact]
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
                await _client.DescribeImagesAsync(request, token);
            }
            catch (OperationCanceledException exception)
            {
                Assert.Equal(token, exception.CancellationToken);
                Assert.True(exception.CancellationToken.IsCancellationRequested);
                return;
            }
            Assert.Fail("An OperationCanceledException was not thrown");
        }
    }
}
