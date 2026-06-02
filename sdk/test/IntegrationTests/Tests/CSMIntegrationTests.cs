using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.CSM
{
    [Collection("Serial")]
    [Trait("Category", "CSM")]
    public class CSMIntegrationTests : IDisposable
    {
        private const int CSMPort = 31000;

        public CSMIntegrationTests()
        {
            AWSConfigs.CSMConfig.CSMEnabled = true;
            DeterminedCSMConfiguration.Instance.CSMConfiguration = new CSMFallbackConfigChain().GetCSMConfig();
        }

        public void Dispose()
        {
            AWSConfigs.CSMConfig.CSMEnabled = null;
            DeterminedCSMConfiguration.Instance.CSMConfiguration = new CSMFallbackConfigChain().GetCSMConfig();
        }

        [Fact]
        [Trait("Category", "Async")]
        public async Task SingleSuccessfulRequestAsync()
        {
            var ready = new ManualResetEventSlim(false);
            var task = Task.Run(() => ListenForUdpMessages(ready));
            Assert.True(ready.Wait(TimeSpan.FromSeconds(5)), "UDP listener failed to bind within timeout.");
            var client = new AmazonDynamoDBClient(new AmazonDynamoDBConfig { RegionEndpoint = RegionEndpoint.USEast1 });
            await client.ListTablesAsync(new ListTablesRequest { });
            Thread.Sleep(10);
            SendEndMessage();
            var messages = task.Result;

            // Filter out the "Exit" sentinel and any stale messages from prior tests
            var relevant = messages.Where(m => m != "Exit" && m.Contains("ListTables")).ToList();
            Assert.Equal(2, relevant.Count);
            ValidateMessage(relevant[0], "ApiCallAttempt", "DynamoDB", "ListTables", "us-east-1", 200, domain: "dynamodb.us-east-1.amazonaws.com");
            ValidateMessage(relevant[1], "ApiCall", "DynamoDB", "ListTables", "us-east-1", 200, attemptCount: 1);
        }

        [Fact]
        [Trait("Category", "Async")]
        public async Task SingleInvalidRequestAsync()
        {
            var ready = new ManualResetEventSlim(false);
            var task = Task.Run(() => ListenForUdpMessages(ready));
            Assert.True(ready.Wait(TimeSpan.FromSeconds(5)), "UDP listener failed to bind within timeout.");
            var client = new AmazonDynamoDBClient(new AmazonDynamoDBConfig { RegionEndpoint = RegionEndpoint.USEast1 });
            var tableName = $"nonexistent-{Guid.NewGuid():N}";
            await Assert.ThrowsAsync<ResourceNotFoundException>(
                async () => await client.DeleteTableAsync(new DeleteTableRequest { TableName = tableName }));
            Thread.Sleep(10);
            SendEndMessage();
            var messages = task.Result;

            // Filter out the "Exit" sentinel and any stale messages from prior tests
            var relevant = messages.Where(m => m != "Exit" && m.Contains("DeleteTable")).ToList();
            Assert.Equal(2, relevant.Count);
            ValidateMessage(relevant[0], "ApiCallAttempt", "DynamoDB", "DeleteTable", "us-east-1", 400, domain: "dynamodb.us-east-1.amazonaws.com");
            ValidateMessage(relevant[1], "ApiCall", "DynamoDB", "DeleteTable", "us-east-1", 400, attemptCount: 1);
        }

#if NETFRAMEWORK
        [Fact]
        [Trait("Category", "Sync")]
        public void SingleSuccessfulRequestSync()
        {
            var stash = new List<string>();
            var ready = new ManualResetEventSlim(false);
            ThreadPool.QueueUserWorkItem(_ =>
            {
                using (var udpClient = new UdpClient())
                {
                    udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, CSMPort));
                    ready.Set();
                    var ep = new IPEndPoint(IPAddress.Any, 0);
                    do { stash.Add(Encoding.UTF8.GetString(udpClient.Receive(ref ep))); }
                    while (stash.Last() != "Exit");
                }
            });
            Assert.True(ready.Wait(TimeSpan.FromSeconds(5)), "UDP listener failed to bind within timeout.");

            var client = new AmazonDynamoDBClient(new AmazonDynamoDBConfig { RegionEndpoint = RegionEndpoint.USEast1 });
            client.ListTables(new ListTablesRequest { });
            Thread.Sleep(10);
            SendEndMessage();
            Thread.Sleep(50);

            // Filter out the "Exit" sentinel and any stale messages from prior tests
            var relevant = stash.Where(m => m != "Exit" && m.Contains("ListTables")).ToList();
            Assert.Equal(2, relevant.Count);
            ValidateMessage(relevant[0], "ApiCallAttempt", "DynamoDB", "ListTables", "us-east-1", 200, domain: "dynamodb.us-east-1.amazonaws.com");
            ValidateMessage(relevant[1], "ApiCall", "DynamoDB", "ListTables", "us-east-1", 200, attemptCount: 1);
        }
#endif

        private static void ValidateMessage(string json, string expectedType, string service, string api, string region, int httpStatusCode, string domain = null, int? attemptCount = null)
        {
            using (var doc = JsonDocument.Parse(json))
            {
                var root = doc.RootElement;
                Assert.Equal(expectedType, root.GetProperty("Type").GetString());
                Assert.Equal(service, root.GetProperty("Service").GetString());
                Assert.Equal(api, root.GetProperty("Api").GetString());
                Assert.Equal(region, root.GetProperty("Region").GetString());

                if (expectedType == "ApiCall")
                {
                    Assert.Equal(httpStatusCode, root.GetProperty("FinalHttpStatusCode").GetInt32());
                    if (attemptCount.HasValue)
                    {
                        Assert.Equal(attemptCount.Value, root.GetProperty("AttemptCount").GetInt32());
                    }
                }
                else
                {
                    Assert.Equal(httpStatusCode, root.GetProperty("HttpStatusCode").GetInt32());
                    if (domain != null)
                    {
                        Assert.Equal(domain, root.GetProperty("Fqdn").GetString());
                    }
                }
            }
        }

        private static List<string> ListenForUdpMessages(ManualResetEventSlim ready = null)
        {
            var stash = new List<string>();
            using (var udpClient = new UdpClient())
            {
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, CSMPort));
                ready?.Set();
                var ep = new IPEndPoint(IPAddress.Any, 0);
                do { stash.Add(Encoding.UTF8.GetString(udpClient.Receive(ref ep))); }
                while (stash.Last() != "Exit");
            }
            return stash;
        }

        private static void SendEndMessage()
        {
            using (var udpClient = new UdpClient())
            {
                var bytes = Encoding.UTF8.GetBytes("Exit");
                udpClient.Send(bytes, bytes.Length, "127.0.0.1", CSMPort);
            }
        }
    }
}
