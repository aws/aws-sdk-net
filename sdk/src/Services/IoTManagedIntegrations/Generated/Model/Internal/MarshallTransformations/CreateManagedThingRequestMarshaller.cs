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
    /// CreateManagedThing Request Marshaller
    /// </summary>       
    public class CreateManagedThingRequestMarshaller : IMarshaller<IRequest, CreateManagedThingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateManagedThingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateManagedThingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/managed-things";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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

            if(publicRequest.IsSetBrand())
            {
                context.Writer.WritePropertyName("Brand");
                context.Writer.WriteStringValue(publicRequest.Brand);
            }

            if(publicRequest.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("Capabilities");
                context.Writer.WriteStringValue(publicRequest.Capabilities);
            }

            if(publicRequest.IsSetCapabilityReport())
            {
                context.Writer.WritePropertyName("CapabilityReport");
                context.Writer.WriteStartObject();

                var marshaller = CapabilityReportMarshaller.Instance;
                marshaller.Marshall(publicRequest.CapabilityReport, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCapabilitySchemas())
            {
                context.Writer.WritePropertyName("CapabilitySchemas");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCapabilitySchemasListValue in publicRequest.CapabilitySchemas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CapabilitySchemaItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestCapabilitySchemasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClassification())
            {
                context.Writer.WritePropertyName("Classification");
                context.Writer.WriteStringValue(publicRequest.Classification);
            }

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
            if(publicRequest.IsSetCredentialLockerId())
            {
                context.Writer.WritePropertyName("CredentialLockerId");
                context.Writer.WriteStringValue(publicRequest.CredentialLockerId);
            }

            if(publicRequest.IsSetMetaData())
            {
                context.Writer.WritePropertyName("MetaData");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMetaDataKvp in publicRequest.MetaData)
                {
                    context.Writer.WritePropertyName(publicRequestMetaDataKvp.Key);
                    var publicRequestMetaDataValue = publicRequestMetaDataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestMetaDataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModel())
            {
                context.Writer.WritePropertyName("Model");
                context.Writer.WriteStringValue(publicRequest.Model);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOwner())
            {
                context.Writer.WritePropertyName("Owner");
                context.Writer.WriteStringValue(publicRequest.Owner);
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetSerialNumber())
            {
                context.Writer.WritePropertyName("SerialNumber");
                context.Writer.WriteStringValue(publicRequest.SerialNumber);
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
        private static CreateManagedThingRequestMarshaller _instance = new CreateManagedThingRequestMarshaller();        

        internal static CreateManagedThingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateManagedThingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}