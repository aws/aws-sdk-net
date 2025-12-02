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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Evaluate Request Marshaller
    /// </summary>       
    public class EvaluateRequestMarshaller : IMarshaller<IRequest, EvaluateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EvaluateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EvaluateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEvaluatorId())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field EvaluatorId set");
            request.AddPathResource("{evaluatorId}", StringUtils.FromString(publicRequest.EvaluatorId));
            request.ResourcePath = "/evaluations/evaluate/{evaluatorId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEvaluationInput())
                {
                    context.Writer.WritePropertyName("evaluationInput");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EvaluationInput, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEvaluationTarget())
                {
                    context.Writer.WritePropertyName("evaluationTarget");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationTargetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EvaluationTarget, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static EvaluateRequestMarshaller _instance = new EvaluateRequestMarshaller();        

        internal static EvaluateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}