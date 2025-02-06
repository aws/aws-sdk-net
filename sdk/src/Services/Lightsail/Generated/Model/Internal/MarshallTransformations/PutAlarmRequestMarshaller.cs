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

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAlarm Request Marshaller
    /// </summary>       
    public class PutAlarmRequestMarshaller : IMarshaller<IRequest, PutAlarmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAlarmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAlarmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.PutAlarm";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAlarmName())
            {
                context.Writer.WritePropertyName("alarmName");
                context.Writer.WriteStringValue(publicRequest.AlarmName);
            }

            if(publicRequest.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("comparisonOperator");
                context.Writer.WriteStringValue(publicRequest.ComparisonOperator);
            }

            if(publicRequest.IsSetContactProtocols())
            {
                context.Writer.WritePropertyName("contactProtocols");
                context.Writer.WriteStartArray();
                foreach(var publicRequestContactProtocolsListValue in publicRequest.ContactProtocols)
                {
                        context.Writer.WriteStringValue(publicRequestContactProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDatapointsToAlarm())
            {
                context.Writer.WritePropertyName("datapointsToAlarm");
                context.Writer.WriteNumberValue(publicRequest.DatapointsToAlarm.Value);
            }

            if(publicRequest.IsSetEvaluationPeriods())
            {
                context.Writer.WritePropertyName("evaluationPeriods");
                context.Writer.WriteNumberValue(publicRequest.EvaluationPeriods.Value);
            }

            if(publicRequest.IsSetMetricName())
            {
                context.Writer.WritePropertyName("metricName");
                context.Writer.WriteStringValue(publicRequest.MetricName);
            }

            if(publicRequest.IsSetMonitoredResourceName())
            {
                context.Writer.WritePropertyName("monitoredResourceName");
                context.Writer.WriteStringValue(publicRequest.MonitoredResourceName);
            }

            if(publicRequest.IsSetNotificationEnabled())
            {
                context.Writer.WritePropertyName("notificationEnabled");
                context.Writer.WriteBooleanValue(publicRequest.NotificationEnabled.Value);
            }

            if(publicRequest.IsSetNotificationTriggers())
            {
                context.Writer.WritePropertyName("notificationTriggers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotificationTriggersListValue in publicRequest.NotificationTriggers)
                {
                        context.Writer.WriteStringValue(publicRequestNotificationTriggersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetThreshold())
            {
                context.Writer.WritePropertyName("threshold");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.Threshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.Threshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.Threshold.Value);
                }
            }

            if(publicRequest.IsSetTreatMissingData())
            {
                context.Writer.WritePropertyName("treatMissingData");
                context.Writer.WriteStringValue(publicRequest.TreatMissingData);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static PutAlarmRequestMarshaller _instance = new PutAlarmRequestMarshaller();        

        internal static PutAlarmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAlarmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}