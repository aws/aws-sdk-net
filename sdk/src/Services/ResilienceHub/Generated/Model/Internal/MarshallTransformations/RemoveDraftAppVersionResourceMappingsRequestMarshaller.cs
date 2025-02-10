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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
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
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveDraftAppVersionResourceMappings Request Marshaller
    /// </summary>       
    public class RemoveDraftAppVersionResourceMappingsRequestMarshaller : IMarshaller<IRequest, RemoveDraftAppVersionResourceMappingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveDraftAppVersionResourceMappingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveDraftAppVersionResourceMappingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/remove-draft-app-version-resource-mappings";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppArn())
            {
                context.Writer.WritePropertyName("appArn");
                context.Writer.WriteStringValue(publicRequest.AppArn);
            }

            if(publicRequest.IsSetAppRegistryAppNames())
            {
                context.Writer.WritePropertyName("appRegistryAppNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAppRegistryAppNamesListValue in publicRequest.AppRegistryAppNames)
                {
                        context.Writer.WriteStringValue(publicRequestAppRegistryAppNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEksSourceNames())
            {
                context.Writer.WritePropertyName("eksSourceNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEksSourceNamesListValue in publicRequest.EksSourceNames)
                {
                        context.Writer.WriteStringValue(publicRequestEksSourceNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLogicalStackNames())
            {
                context.Writer.WritePropertyName("logicalStackNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLogicalStackNamesListValue in publicRequest.LogicalStackNames)
                {
                        context.Writer.WriteStringValue(publicRequestLogicalStackNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceGroupNames())
            {
                context.Writer.WritePropertyName("resourceGroupNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceGroupNamesListValue in publicRequest.ResourceGroupNames)
                {
                        context.Writer.WriteStringValue(publicRequestResourceGroupNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceNames())
            {
                context.Writer.WritePropertyName("resourceNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceNamesListValue in publicRequest.ResourceNames)
                {
                        context.Writer.WriteStringValue(publicRequestResourceNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTerraformSourceNames())
            {
                context.Writer.WritePropertyName("terraformSourceNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTerraformSourceNamesListValue in publicRequest.TerraformSourceNames)
                {
                        context.Writer.WriteStringValue(publicRequestTerraformSourceNamesListValue);
                }
                context.Writer.WriteEndArray();
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
        private static RemoveDraftAppVersionResourceMappingsRequestMarshaller _instance = new RemoveDraftAppVersionResourceMappingsRequestMarshaller();        

        internal static RemoveDraftAppVersionResourceMappingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveDraftAppVersionResourceMappingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}