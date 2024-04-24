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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProbe Request Marshaller
    /// </summary>       
    public class UpdateProbeRequestMarshaller : IMarshaller<IRequest, UpdateProbeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProbeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProbeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonNetworkMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{monitorName}", StringUtils.FromString(publicRequest.MonitorName));
            if (!publicRequest.IsSetProbeId())
                throw new AmazonNetworkMonitorException("Request object does not have required field ProbeId set");
            request.AddPathResource("{probeId}", StringUtils.FromString(publicRequest.ProbeId));
            request.ResourcePath = "/monitors/{monitorName}/probes/{probeId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestination())
                {
                    context.Writer.WritePropertyName("destination");
                    context.Writer.Write(publicRequest.Destination);
                }

                if(publicRequest.IsSetDestinationPort())
                {
                    context.Writer.WritePropertyName("destinationPort");
                    context.Writer.Write(publicRequest.DestinationPort);
                }

                if(publicRequest.IsSetPacketSize())
                {
                    context.Writer.WritePropertyName("packetSize");
                    context.Writer.Write(publicRequest.PacketSize);
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("state");
                    context.Writer.Write(publicRequest.State);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateProbeRequestMarshaller _instance = new UpdateProbeRequestMarshaller();        

        internal static UpdateProbeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProbeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}