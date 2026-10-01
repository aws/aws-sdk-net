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

using Amazon.AugmentedAIRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AugmentedAIRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListHumanLoops Request Marshaller
    /// </summary>
    public partial class ListHumanLoopsRequestMarshaller : IMarshaller<IRequest, ListHumanLoopsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListHumanLoopsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListHumanLoopsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AugmentedAIRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-07";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetCreationTimeAfter())
            {
                request.Parameters.Add("CreationTimeAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeAfter));
            }

            if (publicRequest.IsSetCreationTimeBefore())
            {
                request.Parameters.Add("CreationTimeBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreationTimeBefore));
            }

            if (string.IsNullOrEmpty(publicRequest.FlowDefinitionArn))
            {
                throw new AmazonAugmentedAIRuntimeException("Request object does not have required field FlowDefinitionArn set");
            }

            if (publicRequest.IsSetFlowDefinitionArn())
            {
                request.Parameters.Add("FlowDefinitionArn", StringUtils.FromString(publicRequest.FlowDefinitionArn));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetSortOrder())
            {
                request.Parameters.Add("SortOrder", StringUtils.FromString(publicRequest.SortOrder));
            }

            request.ResourcePath = "/human-loops";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListHumanLoopsRequestMarshaller _instance = new();

        internal static ListHumanLoopsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListHumanLoopsRequestMarshaller Instance => _instance;
    }
}
