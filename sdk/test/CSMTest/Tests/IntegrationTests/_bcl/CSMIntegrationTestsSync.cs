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
    public class CSMIntegrationTestsSync
    {
        private IList<string> stash { get; set; } = new List<string>();

        [Fact]
        [Trait("Category", "CSM")]
        [Trait("Category", "Sync")]
        [Trait("Category", "bcl")]
        public void SingleSuccessfulRequest()
        {
            ThreadPool.QueueUserWorkItem(UDPListener);
            CSMTestUtilities testUtils = new CSMTestUtilities
            {
                Service = "DynamoDB",
                ApiCall = "ListTables",
                AttemptCount = 1,
                Domain = "dynamodb.us-east-1.amazonaws.com",
                Region = "us-east-1",
                HttpStatusCode = 200,
                MaxRetriesExceeded = 0,
                StashCount = 3
            };
            AmazonDynamoDBConfig config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1
            };
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            client.ListTables(new ListTablesRequest { });
            Thread.Sleep(10);
            testUtils.EndTest();
            testUtils.Validate(stash);
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
