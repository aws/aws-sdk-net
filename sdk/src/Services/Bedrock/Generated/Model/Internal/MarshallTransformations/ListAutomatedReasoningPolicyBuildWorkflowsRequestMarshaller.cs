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
    /// ListAutomatedReasoningPolicyBuildWorkflows Request Marshaller
    /// </summary>       
    public class ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller : IMarshaller<IRequest, ListAutomatedReasoningPolicyBuildWorkflowsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAutomatedReasoningPolicyBuildWorkflowsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAutomatedReasoningPolicyBuildWorkflowsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetPolicyArn())
                throw new AmazonBedrockException("Request object does not have required field PolicyArn set");
            request.AddPathResource("{policyArn}", StringUtils.FromString(publicRequest.PolicyArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/automated-reasoning-policies/{policyArn}/build-workflows";
            request.UseQueryString = true;

            return request;
        }
        private static ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller _instance = new ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller();        

        internal static ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}