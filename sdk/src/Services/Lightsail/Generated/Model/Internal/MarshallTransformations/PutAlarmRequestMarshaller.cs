/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlarmName())
                {
                    context.Writer.WritePropertyName("alarmName");
                    context.Writer.Write(publicRequest.AlarmName);
                }

                if(publicRequest.IsSetComparisonOperator())
                {
                    context.Writer.WritePropertyName("comparisonOperator");
                    context.Writer.Write(publicRequest.ComparisonOperator);
                }

                if(publicRequest.IsSetContactProtocols())
                {
                    context.Writer.WritePropertyName("contactProtocols");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContactProtocolsListValue in publicRequest.ContactProtocols)
                    {
                            context.Writer.Write(publicRequestContactProtocolsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDatapointsToAlarm())
                {
                    context.Writer.WritePropertyName("datapointsToAlarm");
                    context.Writer.Write(publicRequest.DatapointsToAlarm);
                }

                if(publicRequest.IsSetEvaluationPeriods())
                {
                    context.Writer.WritePropertyName("evaluationPeriods");
                    context.Writer.Write(publicRequest.EvaluationPeriods);
                }

                if(publicRequest.IsSetMetricName())
                {
                    context.Writer.WritePropertyName("metricName");
                    context.Writer.Write(publicRequest.MetricName);
                }

                if(publicRequest.IsSetMonitoredResourceName())
                {
                    context.Writer.WritePropertyName("monitoredResourceName");
                    context.Writer.Write(publicRequest.MonitoredResourceName);
                }

                if(publicRequest.IsSetNotificationEnabled())
                {
                    context.Writer.WritePropertyName("notificationEnabled");
                    context.Writer.Write(publicRequest.NotificationEnabled);
                }

                if(publicRequest.IsSetNotificationTriggers())
                {
                    context.Writer.WritePropertyName("notificationTriggers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotificationTriggersListValue in publicRequest.NotificationTriggers)
                    {
                            context.Writer.Write(publicRequestNotificationTriggersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetThreshold())
                {
                    context.Writer.WritePropertyName("threshold");
                    context.Writer.Write(publicRequest.Threshold);
                }

                if(publicRequest.IsSetTreatMissingData())
                {
                    context.Writer.WritePropertyName("treatMissingData");
                    context.Writer.Write(publicRequest.TreatMissingData);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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