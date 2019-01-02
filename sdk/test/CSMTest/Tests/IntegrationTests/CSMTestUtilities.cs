using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Xunit;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMTestUtilities
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
        public void Validate(MonitoringAPICallEvent monitoringAPICallEvent)
        {
            Assert.Equal(Service, monitoringAPICallEvent.Service);
            Assert.Equal(ApiCall, monitoringAPICallEvent.Api);
            Assert.Equal("ApiCall", monitoringAPICallEvent.Type);
            Assert.Equal(1, monitoringAPICallEvent.Version);
            Assert.Equal(AttemptCount, monitoringAPICallEvent.AttemptCount);
            Assert.Equal(ClientId, monitoringAPICallEvent.ClientId);
            Assert.Equal(MaxRetriesExceeded, monitoringAPICallEvent.MaxRetriesExceeded);
            Assert.Equal(Region, monitoringAPICallEvent.Region);
            Assert.Equal(HttpStatusCode, monitoringAPICallEvent.FinalHttpStatusCode);
            Assert.NotNull(monitoringAPICallEvent.UserAgent);
            if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalAWSException))
            {
                Assert.Contains(AWSException, monitoringAPICallEvent.FinalAWSException);
            }
            if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalAWSExceptionMessage))
            {
                Assert.Contains(AWSExceptionMessage, monitoringAPICallEvent.FinalAWSExceptionMessage);
            }
            if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalSdkException))
            {
                Assert.Contains(SdkException, monitoringAPICallEvent.FinalSdkException);
            }
            if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalSdkExceptionMessage))
            {
                Assert.Contains(SdkExceptionMessage, monitoringAPICallEvent.FinalSdkExceptionMessage);
            }
        }

        public void Validate(MonitoringAPICallAttempt monitoringAPICallAttempt)
        {
            Assert.Equal(Service, monitoringAPICallAttempt.Service);
            Assert.Equal(ApiCall, monitoringAPICallAttempt.Api);
            Assert.Equal("ApiCallAttempt", monitoringAPICallAttempt.Type);
            Assert.Equal(1, monitoringAPICallAttempt.Version);
            Assert.Equal(Domain, monitoringAPICallAttempt.Fqdn);
            Assert.Equal(Region, monitoringAPICallAttempt.Region);
            Assert.NotNull(monitoringAPICallAttempt.AccessKey);
            Assert.NotNull(monitoringAPICallAttempt.UserAgent);
            Assert.Equal(HttpStatusCode, monitoringAPICallAttempt.HttpStatusCode);
            Assert.Equal(ClientId, monitoringAPICallAttempt.ClientId);
            if (!string.IsNullOrEmpty(monitoringAPICallAttempt.AWSException))
            {
                Assert.Contains(AWSException, monitoringAPICallAttempt.AWSException);
            }
            if (!string.IsNullOrEmpty(monitoringAPICallAttempt.AWSExceptionMessage))
            {
                Assert.Contains(AWSExceptionMessage, monitoringAPICallAttempt.AWSExceptionMessage);
            }
            if (!string.IsNullOrEmpty(monitoringAPICallAttempt.SdkException))
            {
                Assert.Contains(SdkException, monitoringAPICallAttempt.SdkException);
            }
            if (!string.IsNullOrEmpty(monitoringAPICallAttempt.SdkExceptionMessage))
            {
                Assert.Contains(SdkExceptionMessage, monitoringAPICallAttempt.SdkExceptionMessage);
            }
        }
        public void Validate(IList<string> stash)
        {
            Assert.Equal(StashCount, stash.Count);
            foreach (var value in stash)
            {
                if (!value.Equals("Exit"))
                {
                    try
                    {
                        Validate(JsonConvert.DeserializeObject<MonitoringAPICallEvent>(value));
                    }
                    catch (Exception e)
                    {
                        Validate(JsonConvert.DeserializeObject<MonitoringAPICallAttempt>(value));
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public void EndTest()
        {
            using (var udpClient = new UdpClient())
            {
                udpClient.Send(Encoding.UTF8.GetBytes(EndUDPMessage),
                        Encoding.UTF8.GetBytes(EndUDPMessage).Length, Hostname, 31000);
                Thread.Sleep(10);
            }
        }

        public List<string> UDPListener()
        {
            List<string> stash = new List<string>();
            using (var udpClient = new UdpClient())
            {
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Port));
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
