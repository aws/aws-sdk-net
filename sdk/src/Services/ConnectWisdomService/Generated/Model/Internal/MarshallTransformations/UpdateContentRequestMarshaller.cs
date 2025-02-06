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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectWisdomService.Model;
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
namespace Amazon.ConnectWisdomService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateContent Request Marshaller
    /// </summary>       
    public class UpdateContentRequestMarshaller : IMarshaller<IRequest, UpdateContentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateContentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateContentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectWisdomService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetContentId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field ContentId set");
            request.AddPathResource("{contentId}", StringUtils.FromString(publicRequest.ContentId));
            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/knowledgeBases/{knowledgeBaseId}/contents/{contentId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetMetadata())
            {
                context.Writer.WritePropertyName("metadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMetadataKvp in publicRequest.Metadata)
                {
                    context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);
                    var publicRequestMetadataValue = publicRequestMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestMetadataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOverrideLinkOutUri())
            {
                context.Writer.WritePropertyName("overrideLinkOutUri");
                context.Writer.WriteStringValue(publicRequest.OverrideLinkOutUri);
            }

            if(publicRequest.IsSetRemoveOverrideLinkOutUri())
            {
                context.Writer.WritePropertyName("removeOverrideLinkOutUri");
                context.Writer.WriteBooleanValue(publicRequest.RemoveOverrideLinkOutUri.Value);
            }

            if(publicRequest.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("revisionId");
                context.Writer.WriteStringValue(publicRequest.RevisionId);
            }

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            if(publicRequest.IsSetUploadId())
            {
                context.Writer.WritePropertyName("uploadId");
                context.Writer.WriteStringValue(publicRequest.UploadId);
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
        private static UpdateContentRequestMarshaller _instance = new UpdateContentRequestMarshaller();        

        internal static UpdateContentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateContentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}