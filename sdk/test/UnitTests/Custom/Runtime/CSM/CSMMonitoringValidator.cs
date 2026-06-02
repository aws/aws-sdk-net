#if NETFRAMEWORK
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace AWSSDK.UnitTests.Runtime.CSM
{
    public class CSMMonitoringValidator
    {
        private const string EndUDPMessage = "Exit";
        private const string Hostname = "127.0.0.1";
        private const int Port = 31000;

        public string Service { get; set; }
        public string ApiCall { get; set; }
        public string Domain { get; set; }
        public string Region { get; set; }
        public string AWSException { get; set; }
        public int? HttpStatusCode { get; set; }
        public string AWSExceptionMessage { get; set; }
        public int AttemptCount { get; set; } = 1;
        public string SdkException { get; set; }
        public string SdkExceptionMessage { get; set; }
        public string ClientId { get; set; }
        public int MaxRetriesExceeded { get; set; } = 0;
        public int StashCount { get; set; }

        public void Validate(IList<string> stash)
        {
            Assert.AreEqual(StashCount, stash.Count);
            foreach (var value in stash)
            {
                if (value.Equals("Exit"))
                    break;

                using (var doc = JsonDocument.Parse(value))
                {
                    var root = doc.RootElement;
                    var type = root.GetProperty("Type").GetString();
                    if (type == "ApiCall")
                        ValidateApiCallEvent(root);
                    else
                        ValidateApiCallAttempt(root);
                }
            }
        }

        private void ValidateApiCallEvent(JsonElement root)
        {
            Assert.AreEqual(Service, root.GetProperty("Service").GetString());
            Assert.AreEqual(ApiCall, root.GetProperty("Api").GetString());
            Assert.AreEqual("ApiCall", root.GetProperty("Type").GetString());
            Assert.AreEqual(1, root.GetProperty("Version").GetInt32());
            Assert.AreEqual(AttemptCount, root.GetProperty("AttemptCount").GetInt32());
            Assert.AreEqual(MaxRetriesExceeded, root.GetProperty("MaxRetriesExceeded").GetInt32());
            Assert.AreEqual(Region, root.GetProperty("Region").GetString());
            Assert.IsNotNull(root.GetProperty("UserAgent").GetString());

            if (HttpStatusCode.HasValue)
                Assert.AreEqual(HttpStatusCode.Value, root.GetProperty("FinalHttpStatusCode").GetInt32());

            if (ClientId != null)
            {
                Assert.IsTrue(root.TryGetProperty("ClientId", out var clientIdEl), "Expected ClientId property to be present in ApiCall event.");
                Assert.AreEqual(ClientId, clientIdEl.GetString());
            }

            AssertContainsIfPresent(root, "FinalAWSException", AWSException);
            AssertContainsIfPresent(root, "FinalAWSExceptionMessage", AWSExceptionMessage);
            AssertContainsIfPresent(root, "FinalSdkException", SdkException);
            AssertContainsIfPresent(root, "FinalSdkExceptionMessage", SdkExceptionMessage);
        }

        private void ValidateApiCallAttempt(JsonElement root)
        {
            Assert.AreEqual(Service, root.GetProperty("Service").GetString());
            Assert.AreEqual(ApiCall, root.GetProperty("Api").GetString());
            Assert.AreEqual("ApiCallAttempt", root.GetProperty("Type").GetString());
            Assert.AreEqual(1, root.GetProperty("Version").GetInt32());
            Assert.AreEqual(Domain, root.GetProperty("Fqdn").GetString());
            Assert.AreEqual(Region, root.GetProperty("Region").GetString());
            Assert.IsNotNull(root.GetProperty("AccessKey").GetString());
            Assert.IsNotNull(root.GetProperty("UserAgent").GetString());

            if (HttpStatusCode.HasValue)
                Assert.AreEqual(HttpStatusCode.Value, root.GetProperty("HttpStatusCode").GetInt32());

            if (ClientId != null)
            {
                Assert.IsTrue(root.TryGetProperty("ClientId", out var clientIdEl), "Expected ClientId property to be present in ApiCallAttempt event.");
                Assert.AreEqual(ClientId, clientIdEl.GetString());
            }

            AssertContainsIfPresent(root, "AWSException", AWSException);
            AssertContainsIfPresent(root, "AWSExceptionMessage", AWSExceptionMessage);
            AssertContainsIfPresent(root, "SdkException", SdkException);
            AssertContainsIfPresent(root, "SdkExceptionMessage", SdkExceptionMessage);
        }

        private static void AssertContainsIfPresent(JsonElement root, string propertyName, string expected)
        {
            if (string.IsNullOrEmpty(expected))
                return;
            if (root.TryGetProperty(propertyName, out var el))
            {
                var actual = el.GetString();
                if (!string.IsNullOrEmpty(actual))
                    StringAssert.Contains(actual, expected);
            }
        }

        public void EndTest()
        {
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes(EndUDPMessage),
                        Encoding.UTF8.GetBytes(EndUDPMessage).Length, Hostname, Port);
                Thread.Sleep(10);
            }
        }

        public List<string> UDPListener(ManualResetEventSlim ready = null)
        {
            List<string> stash = new List<string>();
            using (var udpClient = new UdpClient())
            {
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Port));
                ready?.Set();
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                do
                {
                    stash.Add(Encoding.UTF8.GetString(udpClient.Receive(ref RemoteIpEndPoint)));
                }
                while (!stash.Last().Equals(EndUDPMessage));
            }
            return stash;
        }
    }
}
#endif
