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
    /// UpdateGateway Request Marshaller
    /// </summary>       
    public class UpdateGatewayRequestMarshaller : IMarshaller<IRequest, UpdateGatewayRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGatewayRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetGatewayIdentifier())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field GatewayIdentifier set");
            request.AddPathResource("{gatewayIdentifier}", StringUtils.FromString(publicRequest.GatewayIdentifier));
            request.ResourcePath = "/gateways/{gatewayIdentifier}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorizerConfiguration())
                {
                    context.Writer.WritePropertyName("authorizerConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthorizerConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuthorizerConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAuthorizerType())
                {
                    context.Writer.WritePropertyName("authorizerType");
                    context.Writer.Write(publicRequest.AuthorizerType);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExceptionLevel())
                {
                    context.Writer.WritePropertyName("exceptionLevel");
                    context.Writer.Write(publicRequest.ExceptionLevel);
                }

                if(publicRequest.IsSetInterceptorConfigurations())
                {
                    context.Writer.WritePropertyName("interceptorConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInterceptorConfigurationsListValue in publicRequest.InterceptorConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GatewayInterceptorConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestInterceptorConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKmsKeyArn())
                {
                    context.Writer.WritePropertyName("kmsKeyArn");
                    context.Writer.Write(publicRequest.KmsKeyArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProtocolConfiguration())
                {
                    context.Writer.WritePropertyName("protocolConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = GatewayProtocolConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProtocolConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProtocolType())
                {
                    context.Writer.WritePropertyName("protocolType");
                    context.Writer.Write(publicRequest.ProtocolType);
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
        private static UpdateGatewayRequestMarshaller _instance = new UpdateGatewayRequestMarshaller();        

        internal static UpdateGatewayRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGatewayRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}