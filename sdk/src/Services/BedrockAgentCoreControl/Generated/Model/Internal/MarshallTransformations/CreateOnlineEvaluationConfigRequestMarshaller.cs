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
    /// CreateOnlineEvaluationConfig Request Marshaller
    /// </summary>       
    public class CreateOnlineEvaluationConfigRequestMarshaller : IMarshaller<IRequest, CreateOnlineEvaluationConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOnlineEvaluationConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOnlineEvaluationConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/online-evaluation-configs/create";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
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
            if(publicRequest.IsSetDataSourceConfig())
            {
                context.Writer.WritePropertyName("dataSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSourceConfig, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetEvaluationExecutionRoleArn())
            {
                context.Writer.WritePropertyName("evaluationExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.EvaluationExecutionRoleArn);
            }

            if(publicRequest.IsSetEvaluators())
            {
                context.Writer.WritePropertyName("evaluators");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEvaluatorsListValue in publicRequest.Evaluators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EvaluatorReferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequestEvaluatorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOnlineEvaluationConfigName())
            {
                context.Writer.WritePropertyName("onlineEvaluationConfigName");
                context.Writer.WriteStringValue(publicRequest.OnlineEvaluationConfigName);
            }

            if(publicRequest.IsSetRule())
            {
                context.Writer.WritePropertyName("rule");
                context.Writer.WriteStartObject();

                var marshaller = RuleMarshaller.Instance;
                marshaller.Marshall(publicRequest.Rule, context);

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
        private static CreateOnlineEvaluationConfigRequestMarshaller _instance = new CreateOnlineEvaluationConfigRequestMarshaller();        

        internal static CreateOnlineEvaluationConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOnlineEvaluationConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}