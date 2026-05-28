#if NETFRAMEWORK
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    [TestClass]
    public class CSMExceptionTests
    {
        Exception exceptionType;

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
        public async Task IoExceptionRetryableRequestsTestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 0
            };
            CSMMonitoringValidator validator = new CSMMonitoringValidator
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
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
            exceptionType = new IOException();
            AmazonDynamoDBClient client = new MockDDBClient(config, exceptionType);
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["TestAttribute"] = new AttributeValue { S = "TestValue" };
            PutItemRequest request = new PutItemRequest
            {
                TableName = "TestTable",
                Item = attributes
            };

            await Assert.ThrowsExactlyAsync<IOException>(async () => await client.PutItemAsync(request));

            Thread.Sleep(10);
            validator.EndTest();
            task.Wait();
            validator.Validate(task.Result);
        }

        [TestMethod]
        [TestCategory("CSM")]
        public async Task WebExceptionRetryableRequestsWithHttpStatusCodeTestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };
            CSMMonitoringValidator validator = new CSMMonitoringValidator
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AttemptCount = config.MaxErrorRetry + 1,
                SdkException = "AmazonServiceException",
                SdkExceptionMessage = "WebException",
                HttpStatusCode = 400,
                MaxRetriesExceeded = 1,
                StashCount = config.MaxErrorRetry + 3
            };
            var ready = new ManualResetEventSlim(false);
            var task = Task.Run(() => validator.UDPListener(ready));
            Assert.IsTrue(ready.Wait(TimeSpan.FromSeconds(5)), "UDP listener failed to bind within timeout.");
            var errorResponse = new Mock<HttpWebResponse>();
            exceptionType = new WebException("Test exception", null, WebExceptionStatus.ConnectFailure, errorResponse.Object);
            errorResponse.SetupGet(foo => foo.StatusCode).Returns(System.Net.HttpStatusCode.BadRequest);
            AmazonDynamoDBClient client = new MockDDBClient(config, exceptionType);
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["TestAttribute"] = new AttributeValue { S = "TestValue" };
            PutItemRequest request = new PutItemRequest
            {
                TableName = "TestTable",
                Item = attributes
            };

            var exception = await Assert.ThrowsExactlyAsync<AmazonServiceException>(async () => await client.PutItemAsync(request));
            Assert.IsInstanceOfType(exception.InnerException, typeof(WebException));

            Thread.Sleep(10);
            validator.EndTest();
            task.Wait();
            validator.Validate(task.Result);
        }

        [TestMethod]
        [TestCategory("CSM")]
        public async Task WebExceptionNonRetryableRequestsTestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };
            CSMMonitoringValidator validator = new CSMMonitoringValidator
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AttemptCount = 1,
                SdkException = "AmazonServiceException",
                SdkExceptionMessage = "WebException",
                MaxRetriesExceeded = 0,
                StashCount = 3
            };
            var ready = new ManualResetEventSlim(false);
            var task = Task.Run(() => validator.UDPListener(ready));
            Assert.IsTrue(ready.Wait(TimeSpan.FromSeconds(5)), "UDP listener failed to bind within timeout.");
            exceptionType = new WebException();
            AmazonDynamoDBClient client = new MockDDBClient(config, exceptionType);
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["TestAttribute"] = new AttributeValue { S = "TestValue" };
            PutItemRequest request = new PutItemRequest
            {
                TableName = "TestTable",
                Item = attributes
            };

            var exception = await Assert.ThrowsExactlyAsync<AmazonServiceException>(async () => await client.PutItemAsync(request));
            Assert.IsInstanceOfType(exception.InnerException, typeof(WebException));

            Thread.Sleep(10);
            validator.EndTest();
            task.Wait();
            validator.Validate(task.Result);
        }

        class MockDDBClient : AmazonDynamoDBClient
        {
            public Mock<IHttpRequestFactory<Stream>> MockFactory { get; private set; }
            public Uri LastRequestUri { get; private set; }
            private Exception exception { get; set; }

            public MockDDBClient(AmazonDynamoDBConfig config, Exception exceptionType) : base(config)
            {
                exception = exceptionType;
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
                            .Throws(exception);
                        return request.Object;
                    })
                    .Callback((Uri uri) => this.LastRequestUri = uri);
                pipeline.ReplaceHandler<HttpHandler<Stream>>(new HttpHandler<Stream>(this.MockFactory.Object, this));
            }
        }
    }
}
#endif
