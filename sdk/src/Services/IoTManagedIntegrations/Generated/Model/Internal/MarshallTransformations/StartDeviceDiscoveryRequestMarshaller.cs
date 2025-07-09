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
    /// StartDeviceDiscovery Request Marshaller
    /// </summary>       
    public class StartDeviceDiscoveryRequestMarshaller : IMarshaller<IRequest, StartDeviceDiscoveryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDeviceDiscoveryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDeviceDiscoveryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/device-discoveries";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountAssociationId())
            {
                context.Writer.WritePropertyName("AccountAssociationId");
                context.Writer.WriteStringValue(publicRequest.AccountAssociationId);
            }

            if(publicRequest.IsSetAuthenticationMaterial())
            {
                context.Writer.WritePropertyName("AuthenticationMaterial");
                context.Writer.WriteStringValue(publicRequest.AuthenticationMaterial);
            }

            if(publicRequest.IsSetAuthenticationMaterialType())
            {
                context.Writer.WritePropertyName("AuthenticationMaterialType");
                context.Writer.WriteStringValue(publicRequest.AuthenticationMaterialType);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetConnectorAssociationIdentifier())
            {
                context.Writer.WritePropertyName("ConnectorAssociationIdentifier");
                context.Writer.WriteStringValue(publicRequest.ConnectorAssociationIdentifier);
            }

            if(publicRequest.IsSetControllerIdentifier())
            {
                context.Writer.WritePropertyName("ControllerIdentifier");
                context.Writer.WriteStringValue(publicRequest.ControllerIdentifier);
            }

            if(publicRequest.IsSetCustomProtocolDetail())
            {
                context.Writer.WritePropertyName("CustomProtocolDetail");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCustomProtocolDetailKvp in publicRequest.CustomProtocolDetail)
                {
                    context.Writer.WritePropertyName(publicRequestCustomProtocolDetailKvp.Key);
                    var publicRequestCustomProtocolDetailValue = publicRequestCustomProtocolDetailKvp.Value;

                        context.Writer.WriteStringValue(publicRequestCustomProtocolDetailValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDiscoveryType())
            {
                context.Writer.WritePropertyName("DiscoveryType");
                context.Writer.WriteStringValue(publicRequest.DiscoveryType);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
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
        private static StartDeviceDiscoveryRequestMarshaller _instance = new StartDeviceDiscoveryRequestMarshaller();        

        internal static StartDeviceDiscoveryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDeviceDiscoveryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}