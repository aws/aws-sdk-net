#if NETFRAMEWORK
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    [TestClass]
    public class CSMS3NameMappingTests
    {
        [TestInitialize]
        public void Setup()
        {
            AWSConfigs.CSMConfig.CSMEnabled = true;
            DeterminedCSMConfiguration.Instance.CSMConfiguration = new CSMFallbackConfigChain().GetCSMConfig();
        }

        [TestCleanup]
        public void Cleanup()
        {
            AWSConfigs.CSMConfig.CSMEnabled = null;
            DeterminedCSMConfiguration.Instance.CSMConfiguration = new CSMFallbackConfigChain().GetCSMConfig();
        }

        [TestMethod]
        [TestCategory("CSM")]
        public async Task S3PutBucketMapsToCreateBucketInCSM()
        {
            AmazonS3Config config = new AmazonS3Config
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2,
                ForcePathStyle = true
            };
            CSMMonitoringValidator validator = new CSMMonitoringValidator
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
            var ready = new ManualResetEventSlim(false);
            var task = Task.Run(() => validator.UDPListener(ready));
            Assert.IsTrue(ready.Wait(TimeSpan.FromSeconds(5)), "UDP listener failed to bind within timeout.");

            AmazonS3Client client = new MockS3Client(config);

            await Assert.ThrowsExactlyAsync<IOException>(async () => await client.PutBucketAsync(new PutBucketRequest
            {
                BucketName = "TestBucket"
            }));

            Thread.Sleep(10);
            validator.EndTest();
            task.Wait();
            validator.Validate(task.Result);
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
#endif
