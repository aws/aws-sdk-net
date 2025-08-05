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
    /// GetAutomatedReasoningPolicyTestResult Request Marshaller
    /// </summary>       
    public class GetAutomatedReasoningPolicyTestResultRequestMarshaller : IMarshaller<IRequest, GetAutomatedReasoningPolicyTestResultRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAutomatedReasoningPolicyTestResultRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAutomatedReasoningPolicyTestResultRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBuildWorkflowId())
                throw new AmazonBedrockException("Request object does not have required field BuildWorkflowId set");
            request.AddPathResource("{buildWorkflowId}", StringUtils.FromString(publicRequest.BuildWorkflowId));
            if (!publicRequest.IsSetPolicyArn())
                throw new AmazonBedrockException("Request object does not have required field PolicyArn set");
            request.AddPathResource("{policyArn}", StringUtils.FromString(publicRequest.PolicyArn));
            if (!publicRequest.IsSetTestCaseId())
                throw new AmazonBedrockException("Request object does not have required field TestCaseId set");
            request.AddPathResource("{testCaseId}", StringUtils.FromString(publicRequest.TestCaseId));
            request.ResourcePath = "/automated-reasoning-policies/{policyArn}/build-workflows/{buildWorkflowId}/test-cases/{testCaseId}/test-results";

            return request;
        }
        private static GetAutomatedReasoningPolicyTestResultRequestMarshaller _instance = new GetAutomatedReasoningPolicyTestResultRequestMarshaller();        

        internal static GetAutomatedReasoningPolicyTestResultRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAutomatedReasoningPolicyTestResultRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}