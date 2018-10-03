using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AWSSDK.CSM.IntegrationTests
{
    public class CSMTestUtilities
    {
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
        public void Validate(MonitoringAPICallEvent monitoringAPICallEvent)
        {
            Assert.Equal(Service, monitoringAPICallEvent.Service);
            Assert.Equal(ApiCall, monitoringAPICallEvent.Api);
            Assert.Equal("ApiCall", monitoringAPICallEvent.Type);
            Assert.Equal(1, monitoringAPICallEvent.Version);
            Assert.Equal(AttemptCount, monitoringAPICallEvent.AttemptCount);
            Assert.Equal(ClientId, monitoringAPICallEvent.ClientId);
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
    }
}
