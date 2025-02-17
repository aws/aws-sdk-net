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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFlowMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartQueryMonitorTopContributors Request Marshaller
    /// </summary>       
    public class StartQueryMonitorTopContributorsRequestMarshaller : IMarshaller<IRequest, StartQueryMonitorTopContributorsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartQueryMonitorTopContributorsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartQueryMonitorTopContributorsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{monitorName}", StringUtils.FromString(publicRequest.MonitorName));
            request.ResourcePath = "/monitors/{monitorName}/topContributorsQueries";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinationCategory())
                {
                    context.Writer.WritePropertyName("destinationCategory");
                    context.Writer.Write(publicRequest.DestinationCategory);
                }

                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("endTime");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
                }

                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetMetricName())
                {
                    context.Writer.WritePropertyName("metricName");
                    context.Writer.Write(publicRequest.MetricName);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("startTime");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartQueryMonitorTopContributorsRequestMarshaller _instance = new StartQueryMonitorTopContributorsRequestMarshaller();        

        internal static StartQueryMonitorTopContributorsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartQueryMonitorTopContributorsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}