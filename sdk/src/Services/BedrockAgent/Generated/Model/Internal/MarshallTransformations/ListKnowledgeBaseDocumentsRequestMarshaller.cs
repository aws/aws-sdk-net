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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListKnowledgeBaseDocuments Request Marshaller
    /// </summary>       
    public class ListKnowledgeBaseDocumentsRequestMarshaller : IMarshaller<IRequest, ListKnowledgeBaseDocumentsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListKnowledgeBaseDocumentsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListKnowledgeBaseDocumentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDataSourceId())
                throw new AmazonBedrockAgentException("Request object does not have required field DataSourceId set");
            request.AddPathResource("{dataSourceId}", StringUtils.FromString(publicRequest.DataSourceId));
            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonBedrockAgentException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/knowledgebases/{knowledgeBaseId}/datasources/{dataSourceId}/documents";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListKnowledgeBaseDocumentsRequestMarshaller _instance = new ListKnowledgeBaseDocumentsRequestMarshaller();        

        internal static ListKnowledgeBaseDocumentsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListKnowledgeBaseDocumentsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}