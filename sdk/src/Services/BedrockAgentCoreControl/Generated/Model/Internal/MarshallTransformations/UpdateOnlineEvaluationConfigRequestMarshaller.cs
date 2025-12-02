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
    /// UpdateOnlineEvaluationConfig Request Marshaller
    /// </summary>       
    public class UpdateOnlineEvaluationConfigRequestMarshaller : IMarshaller<IRequest, UpdateOnlineEvaluationConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOnlineEvaluationConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOnlineEvaluationConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetOnlineEvaluationConfigId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field OnlineEvaluationConfigId set");
            request.AddPathResource("{onlineEvaluationConfigId}", StringUtils.FromString(publicRequest.OnlineEvaluationConfigId));
            request.ResourcePath = "/online-evaluation-configs/{onlineEvaluationConfigId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetDataSourceConfig())
                {
                    context.Writer.WritePropertyName("dataSourceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSourceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEvaluationExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("evaluationExecutionRoleArn");
                    context.Writer.Write(publicRequest.EvaluationExecutionRoleArn);
                }

                if(publicRequest.IsSetEvaluators())
                {
                    context.Writer.WritePropertyName("evaluators");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEvaluatorsListValue in publicRequest.Evaluators)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EvaluatorReferenceMarshaller.Instance;
                        marshaller.Marshall(publicRequestEvaluatorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetExecutionStatus())
                {
                    context.Writer.WritePropertyName("executionStatus");
                    context.Writer.Write(publicRequest.ExecutionStatus);
                }

                if(publicRequest.IsSetRule())
                {
                    context.Writer.WritePropertyName("rule");
                    context.Writer.WriteObjectStart();

                    var marshaller = RuleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Rule, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateOnlineEvaluationConfigRequestMarshaller _instance = new UpdateOnlineEvaluationConfigRequestMarshaller();        

        internal static UpdateOnlineEvaluationConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOnlineEvaluationConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}