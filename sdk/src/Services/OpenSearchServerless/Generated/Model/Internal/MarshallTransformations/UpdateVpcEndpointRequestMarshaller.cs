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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchServerless.Model;
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
namespace Amazon.OpenSearchServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateVpcEndpoint Request Marshaller
    /// </summary>       
    public class UpdateVpcEndpointRequestMarshaller : IMarshaller<IRequest, UpdateVpcEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateVpcEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateVpcEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchServerless");
            string target = "OpenSearchServerless.UpdateVpcEndpoint";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAddSecurityGroupIds())
            {
                context.Writer.WritePropertyName("addSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddSecurityGroupIdsListValue in publicRequest.AddSecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestAddSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAddSubnetIds())
            {
                context.Writer.WritePropertyName("addSubnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddSubnetIdsListValue in publicRequest.AddSubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestAddSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(publicRequest.Id);
            }

            if(publicRequest.IsSetRemoveSecurityGroupIds())
            {
                context.Writer.WritePropertyName("removeSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRemoveSecurityGroupIdsListValue in publicRequest.RemoveSecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestRemoveSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRemoveSubnetIds())
            {
                context.Writer.WritePropertyName("removeSubnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRemoveSubnetIdsListValue in publicRequest.RemoveSubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestRemoveSubnetIdsListValue);
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
        private static UpdateVpcEndpointRequestMarshaller _instance = new UpdateVpcEndpointRequestMarshaller();        

        internal static UpdateVpcEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateVpcEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}