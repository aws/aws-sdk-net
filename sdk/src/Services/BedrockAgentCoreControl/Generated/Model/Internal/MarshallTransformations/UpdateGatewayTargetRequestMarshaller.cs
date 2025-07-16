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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGatewayTarget Request Marshaller
    /// </summary>       
    public class UpdateGatewayTargetRequestMarshaller : IMarshaller<IRequest, UpdateGatewayTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGatewayTargetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGatewayTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetGatewayIdentifier())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field GatewayIdentifier set");
            request.AddPathResource("{gatewayIdentifier}", StringUtils.FromString(publicRequest.GatewayIdentifier));
            if (!publicRequest.IsSetTargetId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field TargetId set");
            request.AddPathResource("{targetId}", StringUtils.FromString(publicRequest.TargetId));
            request.ResourcePath = "/gateways/{gatewayIdentifier}/targets/{targetId}/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCredentialProviderConfigurations())
            {
                context.Writer.WritePropertyName("credentialProviderConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCredentialProviderConfigurationsListValue in publicRequest.CredentialProviderConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CredentialProviderConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCredentialProviderConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetTargetConfiguration())
            {
                context.Writer.WritePropertyName("targetConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TargetConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetConfiguration, context);

                context.Writer.WriteEndObject();
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
        private static UpdateGatewayTargetRequestMarshaller _instance = new UpdateGatewayTargetRequestMarshaller();        

        internal static UpdateGatewayTargetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGatewayTargetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}