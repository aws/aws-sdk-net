using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using Amazon.S3.Model;
using Moq;
using Newtonsoft.Json;
using Xunit;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMS3NameMappingTest
    {
        [Fact]
        public async Task IoExceptionRetryableRequestsTestAsync()
        {
            AmazonS3Config config = new AmazonS3Config
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2,
                ForcePathStyle = true
            };
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "S3",
                ApiCall = "CreateBucket",
                Domain = "s3.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AttemptCount = config.MaxErrorRetry + 1,
                SdkException = "IOException",
                SdkExceptionMessage = "I/O",
                MaxRetriesExceeded = 1,
                StashCount = config.MaxErrorRetry + 3
            };
            var task = Task.Run(() => testUtils.UDPListener());

            AmazonS3Client client = new MockS3Client(config);

            var exception = await Record.ExceptionAsync(async () => await client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = "TestBucket"
            }));
            Assert.NotNull(exception);
            Assert.IsType<IOException>(exception);
            Thread.Sleep(10);
            testUtils.EndTest();
            task.Wait();
            testUtils.Validate(task.Result);
        }
        class MockS3Client : AmazonS3Client
        {
            public Mock<IHttpRequestFactory<Stream>> MockFactory { get; private set; }
            public Uri LastRequestUri { get; private set; }

            public MockS3Client(AmazonS3Config config) : base(config)
            {
            }

            protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
            {
                base.CustomizeRuntimePipeline(pipeline);

                this.MockFactory = new Mock<IHttpRequestFactory<Stream>>();
                this.MockFactory.Setup(foo => foo.CreateHttpRequest(It.IsAny<Uri>()))
                    .Returns((Uri uri) =>
                    {
                        var request = new Mock<IHttpRequest<Stream>>();
                        request.Setup(foo => foo.GetResponseAsync(new CancellationToken()))
                        .Throws(new IOException());
                        return request.Object;
                    })
                    .Callback((Uri uri) => this.LastRequestUri = uri);
                pipeline.ReplaceHandler<HttpHandler<Stream>>(new HttpHandler<Stream>(this.MockFactory.Object, this));
            }
        }
    }
}