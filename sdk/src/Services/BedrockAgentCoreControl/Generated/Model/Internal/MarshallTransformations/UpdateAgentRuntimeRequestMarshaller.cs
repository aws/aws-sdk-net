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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAgentRuntime Request Marshaller
    /// </summary>       
    public class UpdateAgentRuntimeRequestMarshaller : IMarshaller<IRequest, UpdateAgentRuntimeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAgentRuntimeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAgentRuntimeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAgentRuntimeId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field AgentRuntimeId set");
            request.AddPathResource("{agentRuntimeId}", StringUtils.FromString(publicRequest.AgentRuntimeId));
            request.ResourcePath = "/runtimes/{agentRuntimeId}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentRuntimeArtifact())
                {
                    context.Writer.WritePropertyName("agentRuntimeArtifact");
                    context.Writer.WriteObjectStart();

                    var marshaller = AgentRuntimeArtifactMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AgentRuntimeArtifact, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAuthorizerConfiguration())
                {
                    context.Writer.WritePropertyName("authorizerConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthorizerConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuthorizerConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironmentVariables())
                {
                    context.Writer.WritePropertyName("environmentVariables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnvironmentVariablesKvp in publicRequest.EnvironmentVariables)
                    {
                        context.Writer.WritePropertyName(publicRequestEnvironmentVariablesKvp.Key);
                        var publicRequestEnvironmentVariablesValue = publicRequestEnvironmentVariablesKvp.Value;

                            context.Writer.Write(publicRequestEnvironmentVariablesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WritePropertyName("networkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProtocolConfiguration())
                {
                    context.Writer.WritePropertyName("protocolConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProtocolConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProtocolConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestHeaderConfiguration())
                {
                    context.Writer.WritePropertyName("requestHeaderConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RequestHeaderConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RequestHeaderConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAgentRuntimeRequestMarshaller _instance = new UpdateAgentRuntimeRequestMarshaller();        

        internal static UpdateAgentRuntimeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAgentRuntimeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}