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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Repostspace.Model;
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
namespace Amazon.Repostspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchRemoveChannelRoleFromAccessors Request Marshaller
    /// </summary>       
    public class BatchRemoveChannelRoleFromAccessorsRequestMarshaller : IMarshaller<IRequest, BatchRemoveChannelRoleFromAccessorsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchRemoveChannelRoleFromAccessorsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchRemoveChannelRoleFromAccessorsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Repostspace");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-05-13";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetChannelId())
                throw new AmazonRepostspaceException("Request object does not have required field ChannelId set");
            request.AddPathResource("{channelId}", StringUtils.FromString(publicRequest.ChannelId));
            if (!publicRequest.IsSetSpaceId())
                throw new AmazonRepostspaceException("Request object does not have required field SpaceId set");
            request.AddPathResource("{spaceId}", StringUtils.FromString(publicRequest.SpaceId));
            request.ResourcePath = "/spaces/{spaceId}/channels/{channelId}/roles";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccessorIds())
            {
                context.Writer.WritePropertyName("accessorIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAccessorIdsListValue in publicRequest.AccessorIds)
                {
                        context.Writer.WriteStringValue(publicRequestAccessorIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetChannelRole())
            {
                context.Writer.WritePropertyName("channelRole");
                context.Writer.WriteStringValue(publicRequest.ChannelRole);
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
        private static BatchRemoveChannelRoleFromAccessorsRequestMarshaller _instance = new BatchRemoveChannelRoleFromAccessorsRequestMarshaller();        

        internal static BatchRemoveChannelRoleFromAccessorsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchRemoveChannelRoleFromAccessorsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}