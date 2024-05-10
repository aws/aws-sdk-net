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
    /// UpdateAgentAlias Request Marshaller
    /// </summary>       
    public class UpdateAgentAliasRequestMarshaller : IMarshaller<IRequest, UpdateAgentAliasRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgentAliasRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAgentAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAgentAliasId())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentAliasId set");
            request.AddPathResource("{agentAliasId}", StringUtils.FromString(publicRequest.AgentAliasId));
            if (!publicRequest.IsSetAgentId())
                throw new AmazonBedrockAgentException("Request object does not have required field AgentId set");
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));
            request.ResourcePath = "/agents/{agentId}/agentaliases/{agentAliasId}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentAliasName())
                {
                    context.Writer.WritePropertyName("agentAliasName");
                    context.Writer.Write(publicRequest.AgentAliasName);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetRoutingConfiguration())
                {
                    context.Writer.WritePropertyName("routingConfiguration");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRoutingConfigurationListValue in publicRequest.RoutingConfiguration)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AgentAliasRoutingConfigurationListItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestRoutingConfigurationListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAgentAliasRequestMarshaller _instance = new UpdateAgentAliasRequestMarshaller();        

        internal static UpdateAgentAliasRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAgentAliasRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}