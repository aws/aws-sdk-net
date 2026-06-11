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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
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
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateABTest Request Marshaller
    /// </summary>       
    public class CreateABTestRequestMarshaller : IMarshaller<IRequest, CreateABTestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateABTestRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateABTestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ab-tests";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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

            if(publicRequest.IsSetEnableOnCreate())
            {
                context.Writer.WritePropertyName("enableOnCreate");
                context.Writer.WriteBooleanValue(publicRequest.EnableOnCreate.Value);
            }

            if(publicRequest.IsSetEvaluationConfig())
            {
                context.Writer.WritePropertyName("evaluationConfig");
                context.Writer.WriteStartObject();

                var marshaller = ABTestEvaluationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.EvaluationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGatewayArn())
            {
                context.Writer.WritePropertyName("gatewayArn");
                context.Writer.WriteStringValue(publicRequest.GatewayArn);
            }

            if(publicRequest.IsSetGatewayFilter())
            {
                context.Writer.WritePropertyName("gatewayFilter");
                context.Writer.WriteStartObject();

                var marshaller = GatewayFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.GatewayFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetVariants())
            {
                context.Writer.WritePropertyName("variants");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVariantsListValue in publicRequest.Variants)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VariantMarshaller.Instance;
                    marshaller.Marshall(publicRequestVariantsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateABTestRequestMarshaller _instance = new CreateABTestRequestMarshaller();        

        internal static CreateABTestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateABTestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}