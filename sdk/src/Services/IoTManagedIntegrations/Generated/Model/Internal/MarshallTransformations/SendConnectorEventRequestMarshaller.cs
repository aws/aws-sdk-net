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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConnectorDeviceId())
            {
                context.Writer.WritePropertyName("ConnectorDeviceId");
                context.Writer.WriteStringValue(publicRequest.ConnectorDeviceId);
            }

            if(publicRequest.IsSetDeviceDiscoveryId())
            {
                context.Writer.WritePropertyName("DeviceDiscoveryId");
                context.Writer.WriteStringValue(publicRequest.DeviceDiscoveryId);
            }

            if(publicRequest.IsSetDevices())
            {
                context.Writer.WritePropertyName("Devices");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDevicesListValue in publicRequest.Devices)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DeviceMarshaller.Instance;
                    marshaller.Marshall(publicRequestDevicesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMatterEndpoint())
            {
                context.Writer.WritePropertyName("MatterEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = MatterEndpointMarshaller.Instance;
                marshaller.Marshall(publicRequest.MatterEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMessage())
            {
                context.Writer.WritePropertyName("Message");
                context.Writer.WriteStringValue(publicRequest.Message);
            }

            if(publicRequest.IsSetOperation())
            {
                context.Writer.WritePropertyName("Operation");
                context.Writer.WriteStringValue(publicRequest.Operation);
            }

            if(publicRequest.IsSetOperationVersion())
            {
                context.Writer.WritePropertyName("OperationVersion");
                context.Writer.WriteStringValue(publicRequest.OperationVersion);
            }

            if(publicRequest.IsSetStatusCode())
            {
                context.Writer.WritePropertyName("StatusCode");
                context.Writer.WriteNumberValue(publicRequest.StatusCode.Value);
            }

            if(publicRequest.IsSetTraceId())
            {
                context.Writer.WritePropertyName("TraceId");
                context.Writer.WriteStringValue(publicRequest.TraceId);
            }

            if(publicRequest.IsSetUserId())
            {
                context.Writer.WritePropertyName("UserId");
                context.Writer.WriteStringValue(publicRequest.UserId);
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