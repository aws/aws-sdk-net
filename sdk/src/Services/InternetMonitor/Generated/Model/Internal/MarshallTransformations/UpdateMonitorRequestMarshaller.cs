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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.InternetMonitor.Model;
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
namespace Amazon.InternetMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMonitor Request Marshaller
    /// </summary>       
    public class UpdateMonitorRequestMarshaller : IMarshaller<IRequest, UpdateMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.InternetMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-03";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonInternetMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{MonitorName}", StringUtils.FromString(publicRequest.MonitorName));
            request.ResourcePath = "/v20210603/Monitors/{MonitorName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetHealthEventsConfig())
            {
                context.Writer.WritePropertyName("HealthEventsConfig");
                context.Writer.WriteStartObject();

                var marshaller = HealthEventsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.HealthEventsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInternetMeasurementsLogDelivery())
            {
                context.Writer.WritePropertyName("InternetMeasurementsLogDelivery");
                context.Writer.WriteStartObject();

                var marshaller = InternetMeasurementsLogDeliveryMarshaller.Instance;
                marshaller.Marshall(publicRequest.InternetMeasurementsLogDelivery, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxCityNetworksToMonitor())
            {
                context.Writer.WritePropertyName("MaxCityNetworksToMonitor");
                context.Writer.WriteNumberValue(publicRequest.MaxCityNetworksToMonitor.Value);
            }

            if(publicRequest.IsSetResourcesToAdd())
            {
                context.Writer.WritePropertyName("ResourcesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourcesToAddListValue in publicRequest.ResourcesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestResourcesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourcesToRemove())
            {
                context.Writer.WritePropertyName("ResourcesToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourcesToRemoveListValue in publicRequest.ResourcesToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestResourcesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            if(publicRequest.IsSetTrafficPercentageToMonitor())
            {
                context.Writer.WritePropertyName("TrafficPercentageToMonitor");
                context.Writer.WriteNumberValue(publicRequest.TrafficPercentageToMonitor.Value);
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
        private static UpdateMonitorRequestMarshaller _instance = new UpdateMonitorRequestMarshaller();        

        internal static UpdateMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}