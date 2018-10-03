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

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMIntegrationTestsAsync
    {
        Exception exceptionType;

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl45")]
        [Trait("Category", "Async")]
        [Trait("Category", "EndtoEndTests")]
        public void IoExceptionRetryableRequestsTest()
        {
            var task = Task.Run(() => UDPListener());
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2,
            };

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
            try
            {
                client.PutItemAsync(request).Wait();
            }
            catch(Exception e)
            {

            }
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                        Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                Thread.Sleep(10);
            }

            Assert.Equal(5, task.Result.Count);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AttemptCount = 3,
                SdkException = "IOException",
                SdkExceptionMessage = "I/O"
            };
            foreach (var value in task.Result)
            {
                if (!value.Equals("Exit"))
                {
                    try
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallEvent>(value));
                    }
                    catch (Exception e)
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallAttempt>(value));
                    }
                }
                else
                {
                    break;
                }
            }
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl45")]
        [Trait("Category", "Async")]
        [Trait("Category", "EndtoEndTests")]
        public void WebExceptionRetryableRequestsWithHttpStatusCodeTest()
        {
            var task = Task.Run(() => UDPListener());
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };
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
            try
            {
                client.PutItemAsync(request).Wait();
            }
            catch (Exception e)
            {

            }
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                        Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                Thread.Sleep(10);
            }

            Assert.Equal(5, task.Result.Count);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AttemptCount = 3,
                SdkException = "AmazonServiceException",
                SdkExceptionMessage = "WebException",
                HttpStatusCode = 400
            };
            foreach (var value in task.Result)
            {
                if (!value.Equals("Exit"))
                {
                    try
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallEvent>(value));
                    }
                    catch (Exception e)
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallAttempt>(value));
                    }
                }
                else
                {
                    break;
                }
            }
        }

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl45")]
        [Trait("Category", "Async")]
        [Trait("Category", "EndtoEndTests")]
        public void WebExceptionNonRetryableRequestsTest()
        {
            var task = Task.Run(() => UDPListener());
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };
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
            try
            {
                client.PutItemAsync(request).Wait();
            }
            catch (Exception e)
            {

            }
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                        Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                Thread.Sleep(10);
            }

            Assert.Equal(3, task.Result.Count);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                AttemptCount = 1,
                SdkException = "AmazonServiceException",
                SdkExceptionMessage = "WebException"
            };
            foreach (var value in task.Result)
            {
                if (!value.Equals("Exit"))
                {
                    try
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallEvent>(value));
                    }
                    catch (Exception e)
                    {
                        testUtils.Validate(JsonConvert.DeserializeObject<MonitoringAPICallAttempt>(value));
                    }
                }
                else
                {
                    break;
                }
            }
        }
        private List<string> UDPListener()
        {
            List<string> stash = new List<string>();
            using (var udpClient = new UdpClient())
            {
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 31000));
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                do
                {
                    stash.Add(Encoding.UTF8.GetString(udpClient.Receive(ref RemoteIpEndPoint)));
                }
                while (!stash.Last().Equals("Exit"));
            }
            return stash;
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