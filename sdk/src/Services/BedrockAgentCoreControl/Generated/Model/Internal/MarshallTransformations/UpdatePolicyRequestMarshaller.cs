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
    /// UpdatePolicy Request Marshaller
    /// </summary>       
    public class UpdatePolicyRequestMarshaller : IMarshaller<IRequest, UpdatePolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetPolicyEngineId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field PolicyEngineId set");
            request.AddPathResource("{policyEngineId}", StringUtils.FromString(publicRequest.PolicyEngineId));
            if (!publicRequest.IsSetPolicyId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field PolicyId set");
            request.AddPathResource("{policyId}", StringUtils.FromString(publicRequest.PolicyId));
            request.ResourcePath = "/policy-engines/{policyEngineId}/policies/{policyId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefinition())
                {
                    context.Writer.WritePropertyName("definition");
                    context.Writer.WriteObjectStart();

                    var marshaller = PolicyDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Definition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetValidationMode())
                {
                    context.Writer.WritePropertyName("validationMode");
                    context.Writer.Write(publicRequest.ValidationMode);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdatePolicyRequestMarshaller _instance = new UpdatePolicyRequestMarshaller();        

        internal static UpdatePolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}