using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using Moq;
using Amazon.Runtime;
using System.IO;
using Amazon.Runtime.Internal;
using Xunit;
using Amazon;
using Record = Xunit.Record;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMExceptionIntegrationTestsAsync
    {
        Exception exceptionType;

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl")]
        [Trait("Category", "Async")]
        [Trait("Category", "EndtoEndTests")]
        public async Task IoExceptionRetryableRequestsTestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 0
            };
            CSMTestUtilities testUtils = new CSMTestUtilities
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
            var task = Task.Run(() => testUtils.UDPListener());
            exceptionType = new IOException();
            AmazonDynamoDBClient client = new MockDDBClient(config, exceptionType);
            Random generator = new Random();
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["TestAttribute"] = new AttributeValue { S = generator.Next(0, 999999).ToString("D6") };
            PutItemRequest request = new PutItemRequest
            {
                TableName = "TestTable",
                Item = attributes
            };
            var exception = await Record.ExceptionAsync(async () => await client.PutItemAsync(request));
            Assert.NotNull(exception);
            Assert.IsType<IOException>(exception);
            Thread.Sleep(10);
            testUtils.EndTest();
            task.Wait();
            testUtils.Validate(task.Result);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl")]
        [Trait("Category", "Async")]
        [Trait("Category", "EndtoEndTests")]
        public async Task WebExceptionRetryableRequestsWithHttpStatusCodeTestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };
            CSMTestUtilities testUtils = new CSMTestUtilities
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
            var task = Task.Run(() => testUtils.UDPListener());
            var errorResponse = new Mock<HttpWebResponse>();
            exceptionType = new WebException("Test exception", null, WebExceptionStatus.ConnectFailure, errorResponse.Object);
            errorResponse.SetupGet(foo => foo.StatusCode).Returns(HttpStatusCode.BadRequest);
            AmazonDynamoDBClient client = new MockDDBClient(config, exceptionType);
            Random generator = new Random();
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["TestAttribute"] = new AttributeValue { S = generator.Next(0, 999999).ToString("D6") };
            PutItemRequest request = new PutItemRequest
            {
                TableName = "TestTable",
                Item = attributes
            };
            var exception = await Record.ExceptionAsync(async () => await client.PutItemAsync(request));
            Assert.NotNull(exception);
            Assert.IsType<AmazonServiceException>(exception);
            Assert.IsType<WebException>(exception.InnerException);
            Thread.Sleep(10);
            testUtils.EndTest();
            task.Wait();
            testUtils.Validate(task.Result);
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl")]
        [Trait("Category", "Async")]
        [Trait("Category", "EndtoEndTests")]
        public async Task WebExceptionNonRetryableRequestsTestAsync()
        {
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };
            CSMTestUtilities testUtils = new CSMTestUtilities
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
            var task = Task.Run(() => testUtils.UDPListener());
            exceptionType = new WebException();
            AmazonDynamoDBClient client = new MockDDBClient(config, exceptionType);
            Random generator = new Random();
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["TestAttribute"] = new AttributeValue { S = generator.Next(0, 999999).ToString("D6") };
            PutItemRequest request = new PutItemRequest
            {
                TableName = "TestTable",
                Item = attributes
            };
            var exception = await Record.ExceptionAsync(async () => await client.PutItemAsync(request));
            Assert.NotNull(exception);
            Assert.IsType<AmazonServiceException>(exception);
            Assert.IsType<WebException>(exception.InnerException);
            Thread.Sleep(10);
            testUtils.EndTest();
            task.Wait();
            testUtils.Validate(task.Result);
        }

        class MockDDBClient : AmazonDynamoDBClient
        {
            public Mock<IHttpRequestFactory<Stream>> MockFactory { get; private set; }
            public Uri LastRequestUri { get; private set; }
            private Exception exception { get ; set; }
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