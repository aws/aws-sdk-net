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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAgentActionGroup Request Marshaller
    /// </summary>       
    public class CreateAgentActionGroupRequestMarshaller : IMarshaller<IRequest, CreateAgentActionGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAgentActionGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAgentActionGroupRequest publicRequest)
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
            request.ResourcePath = "/agents/{agentId}/agentversions/{agentVersion}/actiongroups/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActionGroupExecutor())
            {
                context.Writer.WritePropertyName("actionGroupExecutor");
                context.Writer.WriteStartObject();

                var marshaller = ActionGroupExecutorMarshaller.Instance;
                marshaller.Marshall(publicRequest.ActionGroupExecutor, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetActionGroupName())
            {
                context.Writer.WritePropertyName("actionGroupName");
                context.Writer.WriteStringValue(publicRequest.ActionGroupName);
            }

            if(publicRequest.IsSetActionGroupState())
            {
                context.Writer.WritePropertyName("actionGroupState");
                context.Writer.WriteStringValue(publicRequest.ActionGroupState);
            }

            if(publicRequest.IsSetApiSchema())
            {
                context.Writer.WritePropertyName("apiSchema");
                context.Writer.WriteStartObject();

                var marshaller = APISchemaMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApiSchema, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFunctionSchema())
            {
                context.Writer.WritePropertyName("functionSchema");
                context.Writer.WriteStartObject();

                var marshaller = FunctionSchemaMarshaller.Instance;
                marshaller.Marshall(publicRequest.FunctionSchema, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParentActionGroupSignature())
            {
                context.Writer.WritePropertyName("parentActionGroupSignature");
                context.Writer.WriteStringValue(publicRequest.ParentActionGroupSignature);
            }

            if(publicRequest.IsSetParentActionGroupSignatureParams())
            {
                context.Writer.WritePropertyName("parentActionGroupSignatureParams");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParentActionGroupSignatureParamsKvp in publicRequest.ParentActionGroupSignatureParams)
                {
                    context.Writer.WritePropertyName(publicRequestParentActionGroupSignatureParamsKvp.Key);
                    var publicRequestParentActionGroupSignatureParamsValue = publicRequestParentActionGroupSignatureParamsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestParentActionGroupSignatureParamsValue);
                }
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
        private static CreateAgentActionGroupRequestMarshaller _instance = new CreateAgentActionGroupRequestMarshaller();        

        internal static CreateAgentActionGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAgentActionGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}