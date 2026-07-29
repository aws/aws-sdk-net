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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
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
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDocumentContent Request Marshaller
    /// </summary>       
    public class GetDocumentContentRequestMarshaller : IMarshaller<IRequest, GetDocumentContentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDocumentContentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDocumentContentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDataSourceId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field DataSourceId set");
            request.AddPathResource("{dataSourceId}", StringUtils.FromString(publicRequest.DataSourceId));
            if (!publicRequest.IsSetDocumentId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field DocumentId set");
            request.AddPathResource("{documentId}", StringUtils.FromString(publicRequest.DocumentId));
            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/knowledgebases/{knowledgeBaseId}/datasources/{dataSourceId}/documents/{documentId}/content";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetOutputFormat())
            {
                context.Writer.WritePropertyName("outputFormat");
                context.Writer.WriteStringValue(publicRequest.OutputFormat);
            }

            if(publicRequest.IsSetUserContext())
            {
                context.Writer.WritePropertyName("userContext");
                context.Writer.WriteStartObject();

                var marshaller = UserContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserContext, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static GetDocumentContentRequestMarshaller _instance = new GetDocumentContentRequestMarshaller();        

        internal static GetDocumentContentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDocumentContentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}