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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
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
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutIntegration Request Marshaller
    /// </summary>       
    public class PutIntegrationRequestMarshaller : IMarshaller<IRequest, PutIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutIntegrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}/integrations";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEventTriggerNames())
            {
                context.Writer.WritePropertyName("EventTriggerNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEventTriggerNamesListValue in publicRequest.EventTriggerNames)
                {
                        context.Writer.WriteStringValue(publicRequestEventTriggerNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFlowDefinition())
            {
                context.Writer.WritePropertyName("FlowDefinition");
                context.Writer.WriteStartObject();

                var marshaller = FlowDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.FlowDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetObjectTypeName())
            {
                context.Writer.WritePropertyName("ObjectTypeName");
                context.Writer.WriteStringValue(publicRequest.ObjectTypeName);
            }

            if(publicRequest.IsSetObjectTypeNames())
            {
                context.Writer.WritePropertyName("ObjectTypeNames");
                context.Writer.WriteStartObject();
                foreach (var publicRequestObjectTypeNamesKvp in publicRequest.ObjectTypeNames)
                {
                    context.Writer.WritePropertyName(publicRequestObjectTypeNamesKvp.Key);
                    var publicRequestObjectTypeNamesValue = publicRequestObjectTypeNamesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestObjectTypeNamesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
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

            if(publicRequest.IsSetUri())
            {
                context.Writer.WritePropertyName("Uri");
                context.Writer.WriteStringValue(publicRequest.Uri);
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
        private static PutIntegrationRequestMarshaller _instance = new PutIntegrationRequestMarshaller();        

        internal static PutIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}