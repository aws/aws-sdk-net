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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.OpenSearchServerless.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.OpenSearchServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateVpcEndpoint Request Marshaller
    /// </summary>
    public partial class UpdateVpcEndpointRequestMarshaller : IMarshaller<IRequest, UpdateVpcEndpointRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateVpcEndpointRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
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
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAddSecurityGroupIds())
            {
                context.Writer.WritePropertyName("addSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAddSecurityGroupIdsListValue in publicRequest.AddSecurityGroupIds)
                {
                    context.Writer.WriteStringValue(publicRequestAddSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetAddSubnetIds())
            {
                context.Writer.WritePropertyName("addSubnetIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAddSubnetIdsListValue in publicRequest.AddSubnetIds)
                {
                    context.Writer.WriteStringValue(publicRequestAddSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(publicRequest.Id);
            }
            if (publicRequest.IsSetRemoveSecurityGroupIds())
            {
                context.Writer.WritePropertyName("removeSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRemoveSecurityGroupIdsListValue in publicRequest.RemoveSecurityGroupIds)
                {
                    context.Writer.WriteStringValue(publicRequestRemoveSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRemoveSubnetIds())
            {
                context.Writer.WritePropertyName("removeSubnetIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRemoveSubnetIdsListValue in publicRequest.RemoveSubnetIds)
                {
                    context.Writer.WriteStringValue(publicRequestRemoveSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateVpcEndpointRequestMarshaller _instance = new();

        internal static UpdateVpcEndpointRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateVpcEndpointRequestMarshaller Instance => _instance;
    }
}
