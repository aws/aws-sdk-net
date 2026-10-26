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

using Amazon.BedrockAgentCoreControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEvaluator Request Marshaller
    /// </summary>
    public partial class GetEvaluatorRequestMarshaller : IMarshaller<IRequest, GetEvaluatorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEvaluatorRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEvaluatorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetIncludedData())
            {
                request.Parameters.Add("includedData", StringUtils.FromString(publicRequest.IncludedData));
            }

            if (!publicRequest.IsSetEvaluatorId())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field EvaluatorId set");
            }
            request.AddPathResource("{evaluatorId}", StringUtils.FromString(publicRequest.EvaluatorId));

            request.ResourcePath = "/evaluators/{evaluatorId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetEvaluatorRequestMarshaller _instance = new();

        internal static GetEvaluatorRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEvaluatorRequestMarshaller Instance => _instance;
    }
}
