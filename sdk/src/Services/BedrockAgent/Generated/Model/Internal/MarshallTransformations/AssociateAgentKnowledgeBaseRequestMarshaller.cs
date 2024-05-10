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
    /// AssociateAgentKnowledgeBase Request Marshaller
    /// </summary>       
    public class AssociateAgentKnowledgeBaseRequestMarshaller : IMarshaller<IRequest, AssociateAgentKnowledgeBaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateAgentKnowledgeBaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateAgentKnowledgeBaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAgentId())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentId set");
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));
            if (!publicRequest.IsSetAgentVersion())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentVersion set");
            request.AddPathResource("{agentVersion}", StringUtils.FromString(publicRequest.AgentVersion));
            request.ResourcePath = "/agents/{agentId}/agentversions/{agentVersion}/knowledgebases/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetKnowledgeBaseId())
                {
                    context.Writer.WritePropertyName("knowledgeBaseId");
                    context.Writer.Write(publicRequest.KnowledgeBaseId);
                }

                if(publicRequest.IsSetKnowledgeBaseState())
                {
                    context.Writer.WritePropertyName("knowledgeBaseState");
                    context.Writer.Write(publicRequest.KnowledgeBaseState);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static AssociateAgentKnowledgeBaseRequestMarshaller _instance = new AssociateAgentKnowledgeBaseRequestMarshaller();        

        internal static AssociateAgentKnowledgeBaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateAgentKnowledgeBaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}