using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace AWSSDK.CSM.IntegrationTests
{
    public class MonitoringAPICallAttempt
    {
        public string Fqdn { get; set; }
        public string UserAgent { get; set; }
        public string SessionToken { get; set; }
        public string Region { get; set; }
        public string AccessKey { get; set; }
        public int? HttpStatusCode { get; set; }
        public string SdkExceptionMessage { get; set; }
        public string SdkException { get; set; }
        public string AwsException { get; set; }
        public string AWSExceptionMessage { get; set; }
        public string XAmznRequestId { get; set; }
        public string XAmzRequestId { get; set; }
        public string XAmzId2 { get; set; }
        public long AttemptLatency { get; set; }
        public string Api { get; set; }
        public string Service { get; set; }
        public string ClientId { get; set; }
        public long Timestamp { get; set; }
        public string Type { get; set; }
        public int Version { get; set; }
        public string AWSException { get; set; }
    }
    public class MonitoringAPICallEvent
    {
        public int AttemptCount { get; set; }
        public long Latency { get; set; }
        public string Api { get; set; }
        public string Service { get; set; }
        public string ClientId { get; set; }
        public long Timestamp { get; set; }
        public string Type { get; set; }
        public int Version { get; set; }
        public int MaxRetriesExceeded { get; set; }
        public string Region { get; set; }
        public int? FinalHttpStatusCode { get; set; }
        public string UserAgent { get; set; }
        public string FinalAWSException { get; set; }
        public string FinalAWSExceptionMessage { get; set; }
        public string FinalSdkException { get; set; }
        public string FinalSdkExceptionMessage { get; set; }
    }

}
