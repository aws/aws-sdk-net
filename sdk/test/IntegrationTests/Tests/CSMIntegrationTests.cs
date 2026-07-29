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
        private readonly string _clientId = Guid.NewGuid().ToString("N");

        public CSMIntegrationTests()
        {
            AWSConfigs.CSMConfig.CSMEnabled = true;
            AWSConfigs.CSMConfig.CSMClientId = _clientId;
            DeterminedCSMConfiguration.Instance.CSMConfiguration = new CSMFallbackConfigChain().GetCSMConfig();
        }

        public void Dispose()
        {
            AWSConfigs.CSMConfig.CSMEnabled = null;
            AWSConfigs.CSMConfig.CSMClientId = null;
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

            ValidateCall(messages, "ListTables", 200, domain: "dynamodb.us-east-1.amazonaws.com", clientId: _clientId);
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

            ValidateCall(messages, "DeleteTable", 400, domain: "dynamodb.us-east-1.amazonaws.com", clientId: _clientId);
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

            ValidateCall(stash, "ListTables", 200, domain: "dynamodb.us-east-1.amazonaws.com", clientId: _clientId);
        }
#endif

        // Validates CSM output for a single call by keying off the per-test ClientId rather than
        // the raw datagram count. A single SDK call can emit multiple attempt events if it retries.
        private static void ValidateCall(IEnumerable<string> messages, string api, int httpStatusCode, string domain, string clientId)
        {
            var relevant = messages.Where(m => m != "Exit" && HasCsmIdentity(m, api, clientId)).ToList();

            var summary = Assert.Single(relevant.Where(m => IsType(m, "ApiCall")));
            ValidateMessage(summary, "ApiCall", "DynamoDB", api, "us-east-1", httpStatusCode);

            var attempts = relevant.Where(m => IsType(m, "ApiCallAttempt")).ToList();
            Assert.NotEmpty(attempts);
            foreach (var attempt in attempts)
            {
                ValidateMessage(attempt, "ApiCallAttempt", "DynamoDB", api, "us-east-1", domain: domain);
            }
        }

        private static bool HasCsmIdentity(string json, string api, string clientId)
        {
            using (var doc = JsonDocument.Parse(json))
            {
                var root = doc.RootElement;
                return root.TryGetProperty("Api", out var apiProperty) &&
                       root.TryGetProperty("ClientId", out var clientIdProperty) &&
                       apiProperty.GetString() == api &&
                       clientIdProperty.GetString() == clientId;
            }
        }

        private static bool IsType(string json, string type)
        {
            using (var doc = JsonDocument.Parse(json))
            {
                return doc.RootElement.GetProperty("Type").GetString() == type;
            }
        }

        private static void ValidateMessage(string json, string expectedType, string service, string api, string region, int? httpStatusCode = null, string domain = null)
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
                    if (httpStatusCode.HasValue)
                    {
                        Assert.Equal(httpStatusCode.Value, root.GetProperty("FinalHttpStatusCode").GetInt32());
                    }
                }
                else
                {
                    if (httpStatusCode.HasValue)
                    {
                        Assert.Equal(httpStatusCode.Value, root.GetProperty("HttpStatusCode").GetInt32());
                    }
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
