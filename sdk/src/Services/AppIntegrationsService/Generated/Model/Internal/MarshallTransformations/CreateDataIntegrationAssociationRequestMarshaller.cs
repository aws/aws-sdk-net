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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppIntegrationsService.Model;
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
namespace Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataIntegrationAssociation Request Marshaller
    /// </summary>       
    public class CreateDataIntegrationAssociationRequestMarshaller : IMarshaller<IRequest, CreateDataIntegrationAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataIntegrationAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataIntegrationAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppIntegrationsService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDataIntegrationIdentifier())
                throw new AmazonAppIntegrationsServiceException("Request object does not have required field DataIntegrationIdentifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.DataIntegrationIdentifier));
            request.ResourcePath = "/dataIntegrations/{Identifier}/associations";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientAssociationMetadata())
            {
                context.Writer.WritePropertyName("ClientAssociationMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestClientAssociationMetadataKvp in publicRequest.ClientAssociationMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestClientAssociationMetadataKvp.Key);
                    var publicRequestClientAssociationMetadataValue = publicRequestClientAssociationMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestClientAssociationMetadataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(publicRequest.ClientId);
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
            if(publicRequest.IsSetDestinationURI())
            {
                context.Writer.WritePropertyName("DestinationURI");
                context.Writer.WriteStringValue(publicRequest.DestinationURI);
            }

            if(publicRequest.IsSetExecutionConfiguration())
            {
                context.Writer.WritePropertyName("ExecutionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ExecutionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExecutionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetObjectConfiguration())
            {
                context.Writer.WritePropertyName("ObjectConfiguration");
                context.Writer.WriteStartObject();
                foreach (var publicRequestObjectConfigurationKvp in publicRequest.ObjectConfiguration)
                {
                    context.Writer.WritePropertyName(publicRequestObjectConfigurationKvp.Key);
                    var publicRequestObjectConfigurationValue = publicRequestObjectConfigurationKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var publicRequestObjectConfigurationValueKvp in publicRequestObjectConfigurationValue)
                    {
                        context.Writer.WritePropertyName(publicRequestObjectConfigurationValueKvp.Key);
                        var publicRequestObjectConfigurationValueValue = publicRequestObjectConfigurationValueKvp.Value;

                        context.Writer.WriteStartArray();
                        foreach(var publicRequestObjectConfigurationValueValueListValue in publicRequestObjectConfigurationValueValue)
                        {
                                context.Writer.WriteStringValue(publicRequestObjectConfigurationValueValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndObject();
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
        private static CreateDataIntegrationAssociationRequestMarshaller _instance = new CreateDataIntegrationAssociationRequestMarshaller();        

        internal static CreateDataIntegrationAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataIntegrationAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}