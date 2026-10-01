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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.Bedrock.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAutomatedReasoningPolicyTestCase Request Marshaller
    /// </summary>
    public partial class DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller : IMarshaller<IRequest, DeleteAutomatedReasoningPolicyTestCaseRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAutomatedReasoningPolicyTestCaseRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAutomatedReasoningPolicyTestCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "DELETE";

            if (publicRequest.LastUpdatedAt == null)
            {
                throw new AmazonBedrockException("Request object does not have required field LastUpdatedAt set");
            }

            if (publicRequest.IsSetLastUpdatedAt())
            {
                request.Parameters.Add("updatedAt", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.LastUpdatedAt));
            }

            if (!publicRequest.IsSetPolicyArn())
            {
                throw new AmazonBedrockException("Request object does not have required field PolicyArn set");
            }
            request.AddPathResource("{policyArn}", StringUtils.FromString(publicRequest.PolicyArn));

            if (!publicRequest.IsSetTestCaseId())
            {
                throw new AmazonBedrockException("Request object does not have required field TestCaseId set");
            }
            request.AddPathResource("{testCaseId}", StringUtils.FromString(publicRequest.TestCaseId));

            request.ResourcePath = "/automated-reasoning-policies/{policyArn}/test-cases/{testCaseId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller _instance = new();

        internal static DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller Instance => _instance;
    }
}
