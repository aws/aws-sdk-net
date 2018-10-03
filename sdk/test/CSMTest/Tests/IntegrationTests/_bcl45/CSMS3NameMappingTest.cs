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
        public void IoExceptionRetryableRequestsTest()
        {
            var task = Task.Run(() => UDPListener());
            AmazonS3Config config = new AmazonS3Config
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1,
                MaxErrorRetry = 2
            };

            AmazonS3Client client = new MockS3Client(config);
            
            try
            {
                client.PutBucketAsync(new PutBucketRequest
                {
                    BucketName = "TestBucket"
                }).Wait();
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
                Service = "S3",
                ApiCall = "CreateBucket",
                Domain = "s3.amazonaws.com",
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