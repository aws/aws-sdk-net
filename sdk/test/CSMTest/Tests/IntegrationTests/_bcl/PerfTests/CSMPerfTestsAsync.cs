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
using Amazon.Runtime.Internal.Transform;
using Xunit;
using System.Diagnostics;
using AWSSDK.UnitTests;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMPerfTestsAsync
    {
        public int TestRequestExecution { get; set; }
        public Stopwatch TestTimer { get; set; } = new Stopwatch();

        [Fact(Skip = "Running performance tests as part of a regular build is expensive.")]
        [Trait("Category", "CSM")]
        [Trait("Category", "bcl")]
        [Trait("Category", "Async")]
        [Trait("Category", "perfTests")]
        public async Task MultipleSuccessfulRequestsTestAsync()
        {
            var task = Task.Run(() => UDPListener());
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            AmazonDynamoDBClient client = new MockDDBClient(config);
            Random generator = new Random();
            TestTimer.Start();
            while(TestTimer.ElapsedMilliseconds <= 60000)
            {
                // Define item attributes
                Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
                attributes["TestAttribute"] = new AttributeValue { S = generator.Next(0, 999999).ToString("D6") };
                PutItemRequest request = new PutItemRequest
                {
                    TableName = "TestTable",
                    Item = attributes
                };
                var response = await client.PutItemAsync(request);
                TestRequestExecution++;
                Thread.Sleep(10);
            }
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                        Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                Thread.Sleep(10);
            }
            task.Wait();
            TestTimer.Stop();
            Assert.Equal(TestRequestExecution*2+1, task.Result.Count);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "PutItem",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                HttpStatusCode = 200
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
#if BCL
        class MockDDBClient : AmazonDynamoDBClient
        {
            public Mock<IHttpRequestFactory<Stream>> MockFactory { get; private set; }
            public Uri LastRequestUri { get; private set; }

            public MockDDBClient(AmazonDynamoDBConfig config) : base(config)
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
                            .Returns(Task.FromResult<IWebResponseData>(new HttpWebRequestResponseData(MockWebResponse.CreateFromResource("PutItemResponse.txt"))));
                        return request.Object;
                    })
                    .Callback((Uri uri) => this.LastRequestUri = uri);
                pipeline.ReplaceHandler<HttpHandler<Stream>>(new HttpHandler<Stream>(this.MockFactory.Object, this));
            }
        }
#endif
    }
}