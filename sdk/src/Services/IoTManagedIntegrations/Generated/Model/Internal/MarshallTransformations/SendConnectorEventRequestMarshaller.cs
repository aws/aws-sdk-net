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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendConnectorEvent Request Marshaller
    /// </summary>       
    public class SendConnectorEventRequestMarshaller : IMarshaller<IRequest, SendConnectorEventRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendConnectorEventRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendConnectorEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetConnectorId())
                throw new AmazonIoTManagedIntegrationsException("Request object does not have required field ConnectorId set");
            request.AddPathResource("{ConnectorId}", StringUtils.FromString(publicRequest.ConnectorId));
            request.ResourcePath = "/connector-event/{ConnectorId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConnectorDeviceId())
                {
                    context.Writer.WritePropertyName("ConnectorDeviceId");
                    context.Writer.Write(publicRequest.ConnectorDeviceId);
                }

                if(publicRequest.IsSetDeviceDiscoveryId())
                {
                    context.Writer.WritePropertyName("DeviceDiscoveryId");
                    context.Writer.Write(publicRequest.DeviceDiscoveryId);
                }

                if(publicRequest.IsSetDevices())
                {
                    context.Writer.WritePropertyName("Devices");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDevicesListValue in publicRequest.Devices)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DeviceMarshaller.Instance;
                        marshaller.Marshall(publicRequestDevicesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMatterEndpoint())
                {
                    context.Writer.WritePropertyName("MatterEndpoint");
                    context.Writer.WriteObjectStart();

                    var marshaller = MatterEndpointMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MatterEndpoint, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMessage())
                {
                    context.Writer.WritePropertyName("Message");
                    context.Writer.Write(publicRequest.Message);
                }

                if(publicRequest.IsSetOperation())
                {
                    context.Writer.WritePropertyName("Operation");
                    context.Writer.Write(publicRequest.Operation);
                }

                if(publicRequest.IsSetOperationVersion())
                {
                    context.Writer.WritePropertyName("OperationVersion");
                    context.Writer.Write(publicRequest.OperationVersion);
                }

                if(publicRequest.IsSetStatusCode())
                {
                    context.Writer.WritePropertyName("StatusCode");
                    context.Writer.Write(publicRequest.StatusCode);
                }

                if(publicRequest.IsSetTraceId())
                {
                    context.Writer.WritePropertyName("TraceId");
                    context.Writer.Write(publicRequest.TraceId);
                }

                if(publicRequest.IsSetUserId())
                {
                    context.Writer.WritePropertyName("UserId");
                    context.Writer.Write(publicRequest.UserId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendConnectorEventRequestMarshaller _instance = new SendConnectorEventRequestMarshaller();        

        internal static SendConnectorEventRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendConnectorEventRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}