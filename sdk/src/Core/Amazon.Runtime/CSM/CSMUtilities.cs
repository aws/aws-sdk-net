/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Utility class for CSM.
    /// Contains logic to serialize CSM events to Json.
    /// </summary>
    public static class CSMUtilities
    {
        private const string requestKey = "Request";

        public static Task SerializetoJsonAndPostOverUDPAsync(MonitoringAPICall monitoringAPICall)
        {
            var monitoringAPICallAttempt = monitoringAPICall as MonitoringAPICallAttempt;
            if (monitoringAPICallAttempt != null)
            {
                if (CreateUDPMessage(monitoringAPICallAttempt, out string response))
                {
                    return MonitoringListener.Instance.PostMessagesOverUDPAsync(response);
                }
            }
            else
            {
                if (CreateUDPMessage((MonitoringAPICallEvent)monitoringAPICall, out string response))
                {
                    return MonitoringListener.Instance.PostMessagesOverUDPAsync(response);
                }
            }
            return Task.FromResult(0);
        }

        public static void SerializetoJsonAndPostOverUDP(MonitoringAPICall monitoringAPICall)
        {
            string response = string.Empty;
            var monitoringAPICallAttempt = monitoringAPICall as MonitoringAPICallAttempt;
            if (monitoringAPICallAttempt != null)
            {
                if (CreateUDPMessage(monitoringAPICallAttempt, out response))
                {
                    MonitoringListener.Instance.PostMessagesOverUDP(response);
                }
            }
            else
            {
                if (CreateUDPMessage((MonitoringAPICallEvent)monitoringAPICall, out response))
                {
                    MonitoringListener.Instance.PostMessagesOverUDP(response);
                }
            }
        }

        /// <summary>
        /// Method to retrieve the API name from the request name.
        /// </summary>
        public static string GetApiNameFromRequest(string requestName, IDictionary<string, string> serviceApiNameMapping, string serviceName)
        {
            var logger = Logger.GetLogger(typeof(CSMUtilities));
            // Verify that the requestName has the requestKey(Request) as a suffix.
            if (requestName.EndsWith(requestKey, StringComparison.Ordinal))
            {
                // The API name is extracted from the requestName like so -
                // PutObjectRequest is converted PutObject by removing the
                // 'Request' keyword.
                var apiName = requestName.Substring(0, requestName.Length - requestKey.Length);
                if (serviceApiNameMapping.Count > 0)
                {
                    string actualApiName;
                    if(serviceApiNameMapping.TryGetValue(apiName, out actualApiName))
                    {
                        apiName = actualApiName;
                    }
                }
                return apiName;
            }
            else
            {
                logger.InfoFormat(string.Format(CultureInfo.InvariantCulture, "Invalid request name: Request {0} does not end with the keyword '{1}'. Investigate possible generator bug for service:{2} and operation name:{3}", requestName, requestKey, serviceName, requestName));
                return string.Empty;
            }
        }

        /// <summary>
        /// Method to serialize MonitoringAPICallAttempt CSM event to json.
        /// </summary>
        private static bool CreateUDPMessage(MonitoringAPICallAttempt monitoringAPICallAttempt, out string response)
        {
            using (var memoryStream = new MemoryStream())
            using (Utf8JsonWriter jw = new Utf8JsonWriter(memoryStream))
            {
                jw.WriteStartObject();

                CreateUDPMessage(monitoringAPICallAttempt, jw);

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.AccessKey))
                {
                    jw.WritePropertyName("AccessKey");
                    jw.WriteStringValue(monitoringAPICallAttempt.AccessKey);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.AWSException))
                {
                    jw.WritePropertyName("AWSException");
                    jw.WriteStringValue(monitoringAPICallAttempt.AWSException);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.Fqdn))
                {
                    jw.WritePropertyName("Fqdn");
                    jw.WriteStringValue(monitoringAPICallAttempt.Fqdn);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.SdkException))
                {
                    jw.WritePropertyName("SdkException");
                    jw.WriteStringValue(monitoringAPICallAttempt.SdkException);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.AWSExceptionMessage))
                {
                    jw.WritePropertyName("AWSExceptionMessage");
                    jw.WriteStringValue(monitoringAPICallAttempt.AWSExceptionMessage);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.SdkExceptionMessage))
                {
                    jw.WritePropertyName("SdkExceptionMessage");
                    jw.WriteStringValue(monitoringAPICallAttempt.SdkExceptionMessage);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.SessionToken))
                {
                    jw.WritePropertyName("SessionToken");
                    jw.WriteStringValue(monitoringAPICallAttempt.SessionToken);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.XAmzId2))
                {
                    jw.WritePropertyName("XAmzId2");
                    jw.WriteStringValue(monitoringAPICallAttempt.XAmzId2);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.XAmznRequestId))
                {
                    jw.WritePropertyName("XAmznRequestId");
                    jw.WriteStringValue(monitoringAPICallAttempt.XAmznRequestId);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallAttempt.XAmzRequestId))
                {
                    jw.WritePropertyName("XAmzRequestId");
                    jw.WriteStringValue(monitoringAPICallAttempt.XAmzRequestId);
                }

                if (monitoringAPICallAttempt.HttpStatusCode != null)
                {
                    jw.WritePropertyName("HttpStatusCode");
                    jw.WriteNumberValue((int)monitoringAPICallAttempt.HttpStatusCode);
                }

                jw.WritePropertyName("AttemptLatency");
                jw.WriteNumberValue(monitoringAPICallAttempt.AttemptLatency);

                jw.WriteEndObject();
                jw.Flush();
                response = Encoding.UTF8.GetString(memoryStream.ToArray());

                return ASCIIEncoding.Unicode.GetByteCount(response) <= (8 * 1024);
            }
        }

        /// <summary>
        /// Method to serialize MonitoringAPICallEvent CSM event to json.
        /// </summary>
        private static bool CreateUDPMessage(MonitoringAPICallEvent monitoringAPICallEvent, out string response)
        {
            using (var memoryStream = new MemoryStream())
            using (Utf8JsonWriter jw = new Utf8JsonWriter(memoryStream))
            {
                jw.WriteStartObject();

                CreateUDPMessage(monitoringAPICallEvent, jw);

                jw.WritePropertyName("Latency");
                jw.WriteNumberValue(monitoringAPICallEvent.Latency);

                jw.WritePropertyName("AttemptCount");
                jw.WriteNumberValue(monitoringAPICallEvent.AttemptCount);

                jw.WritePropertyName("MaxRetriesExceeded");
                int maxRetriesValue = 0;
                if (monitoringAPICallEvent.IsLastExceptionRetryable)
                {
                    maxRetriesValue = 1;
                }
                jw.WriteNumberValue(maxRetriesValue);

                if (monitoringAPICallEvent.FinalHttpStatusCode != null)
                {
                    jw.WritePropertyName("FinalHttpStatusCode");
                    jw.WriteNumberValue((int)monitoringAPICallEvent.FinalHttpStatusCode);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalAWSException))
                {
                    jw.WritePropertyName("FinalAWSException");
                    jw.WriteStringValue(monitoringAPICallEvent.FinalAWSException);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalSdkException))
                {
                    jw.WritePropertyName("FinalSdkException");
                    jw.WriteStringValue(monitoringAPICallEvent.FinalSdkException);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalAWSExceptionMessage))
                {
                    jw.WritePropertyName("FinalAWSExceptionMessage");
                    jw.WriteStringValue(monitoringAPICallEvent.FinalAWSExceptionMessage);
                }

                if (!string.IsNullOrEmpty(monitoringAPICallEvent.FinalSdkExceptionMessage))
                {
                    jw.WritePropertyName("FinalSdkExceptionMessage");
                    jw.WriteStringValue(monitoringAPICallEvent.FinalSdkExceptionMessage);
                }

                jw.WriteEndObject();
                jw.Flush();
                response = Encoding.UTF8.GetString(memoryStream.ToArray());

                return ASCIIEncoding.Unicode.GetByteCount(response) <= (8 * 1024);
            }
        }

        /// <summary>
        /// Method to serialize MonitoringAPICall CSM event to json.
        /// </summary>
        private static void CreateUDPMessage(MonitoringAPICall monitoringAPICall, Utf8JsonWriter jw)
        {
            string response = string.Empty;

            if (!string.IsNullOrEmpty(monitoringAPICall.Api))
            {
                jw.WritePropertyName("Api");
                jw.WriteStringValue(monitoringAPICall.Api);
            }

            if (!string.IsNullOrEmpty(monitoringAPICall.Service))
            {
                jw.WritePropertyName("Service");
                jw.WriteStringValue(monitoringAPICall.Service);
            }

            if (!string.IsNullOrEmpty(monitoringAPICall.ClientId))
            {
                jw.WritePropertyName("ClientId");
                jw.WriteStringValue(monitoringAPICall.ClientId);
            }

            jw.WritePropertyName("Version");
            jw.WriteNumberValue(monitoringAPICall.Version);


            if (!string.IsNullOrEmpty(monitoringAPICall.Type))
            {
                jw.WritePropertyName("Type");
                jw.WriteStringValue(monitoringAPICall.Type);
            }

            jw.WritePropertyName("Timestamp");
            jw.WriteNumberValue(monitoringAPICall.Timestamp);

            if (!string.IsNullOrEmpty(monitoringAPICall.Region))
            {
                jw.WritePropertyName("Region");
                jw.WriteStringValue(monitoringAPICall.Region);
            }

            if (!string.IsNullOrEmpty(monitoringAPICall.UserAgent))
            {
                jw.WritePropertyName("UserAgent");
                jw.WriteStringValue(monitoringAPICall.UserAgent);
            }
        }
    }
}
