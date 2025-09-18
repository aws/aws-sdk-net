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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutomatedReasoningPolicyTestCase Request Marshaller
    /// </summary>       
    public class UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller : IMarshaller<IRequest, UpdateAutomatedReasoningPolicyTestCaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutomatedReasoningPolicyTestCaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAutomatedReasoningPolicyTestCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetPolicyArn())
                throw new AmazonBedrockException("Request object does not have required field PolicyArn set");
            request.AddPathResource("{policyArn}", StringUtils.FromString(publicRequest.PolicyArn));
            if (!publicRequest.IsSetTestCaseId())
                throw new AmazonBedrockException("Request object does not have required field TestCaseId set");
            request.AddPathResource("{testCaseId}", StringUtils.FromString(publicRequest.TestCaseId));
            request.ResourcePath = "/automated-reasoning-policies/{policyArn}/test-cases/{testCaseId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetConfidenceThreshold())
                {
                    context.Writer.WritePropertyName("confidenceThreshold");
                    if(StringUtils.IsSpecialDoubleValue(publicRequest.ConfidenceThreshold))
                    {
                        context.Writer.Write(StringUtils.FromSpecialDoubleValue(publicRequest.ConfidenceThreshold));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.ConfidenceThreshold);
                    }
                }

                if(publicRequest.IsSetExpectedAggregatedFindingsResult())
                {
                    context.Writer.WritePropertyName("expectedAggregatedFindingsResult");
                    context.Writer.Write(publicRequest.ExpectedAggregatedFindingsResult);
                }

                if(publicRequest.IsSetGuardContent())
                {
                    context.Writer.WritePropertyName("guardContent");
                    context.Writer.Write(publicRequest.GuardContent);
                }

                if(publicRequest.IsSetLastUpdatedAt())
                {
                    context.Writer.WritePropertyName("lastUpdatedAt");
                    context.Writer.Write(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.LastUpdatedAt));
                }

                if(publicRequest.IsSetQueryContent())
                {
                    context.Writer.WritePropertyName("queryContent");
                    context.Writer.Write(publicRequest.QueryContent);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller _instance = new UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller();        

        internal static UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}