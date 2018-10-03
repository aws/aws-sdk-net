using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using Amazon.Runtime;
using System.IO;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Xunit;
using System.Reflection;
using System.Diagnostics;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMIntegrationTestsAsync
    {
        private IList<string> stash { get; set; } = new List<string>();

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "Async")]
        [Trait("Category", "bcl35")]
        public void SingleSuccessfulRequest()
        {
            ThreadPool.QueueUserWorkItem(UDPListener);
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            var result = client.BeginListTables(new ListTablesRequest(), null, null);
            client.EndListTables(result);
            
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes("Exit"),
                        Encoding.UTF8.GetBytes("Exit").Length, "127.0.0.1", 31000);
                Thread.Sleep(10);
            }
            Assert.Equal(3, stash.Count);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "ListTables",
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                HttpStatusCode = 200
            };
            foreach (var value in stash)
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

        private void UDPListener(Object state)
        {
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
        }
    }
}
