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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryAssistant Request Marshaller
    /// </summary>       
    public class QueryAssistantRequestMarshaller : IMarshaller<IRequest, QueryAssistantRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryAssistantRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryAssistantRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssistantId())
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));
            request.ResourcePath = "/assistants/{assistantId}/query";
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

                if(publicRequest.IsSetOverrideKnowledgeBaseSearchType())
                {
                    context.Writer.WritePropertyName("overrideKnowledgeBaseSearchType");
                    context.Writer.Write(publicRequest.OverrideKnowledgeBaseSearchType);
                }

                if(publicRequest.IsSetQueryCondition())
                {
                    context.Writer.WritePropertyName("queryCondition");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestQueryConditionListValue in publicRequest.QueryCondition)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = QueryConditionMarshaller.Instance;
                        marshaller.Marshall(publicRequestQueryConditionListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetQueryInputData())
                {
                    context.Writer.WritePropertyName("queryInputData");
                    context.Writer.WriteObjectStart();

                    var marshaller = QueryInputDataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.QueryInputData, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetQueryText())
                {
                    context.Writer.WritePropertyName("queryText");
                    context.Writer.Write(publicRequest.QueryText);
                }

                if(publicRequest.IsSetSessionId())
                {
                    context.Writer.WritePropertyName("sessionId");
                    context.Writer.Write(publicRequest.SessionId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static QueryAssistantRequestMarshaller _instance = new QueryAssistantRequestMarshaller();        

        internal static QueryAssistantRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryAssistantRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}