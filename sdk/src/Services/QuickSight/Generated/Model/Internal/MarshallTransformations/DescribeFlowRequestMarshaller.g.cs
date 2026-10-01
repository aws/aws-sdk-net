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

using Amazon.QuickSight.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeFlow Request Marshaller
    /// </summary>
    public partial class DescribeFlowRequestMarshaller : IMarshaller<IRequest, DescribeFlowRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeFlowRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.PublishState))
            {
                throw new AmazonQuickSightException("Request object does not have required field PublishState set");
            }

            if (publicRequest.IsSetPublishState())
            {
                request.Parameters.Add("publish-state", StringUtils.FromString(publicRequest.PublishState));
            }

            if (!publicRequest.IsSetAwsAccountId())
            {
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            }
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));

            if (!publicRequest.IsSetFlowId())
            {
                throw new AmazonQuickSightException("Request object does not have required field FlowId set");
            }
            request.AddPathResource("{FlowId}", StringUtils.FromString(publicRequest.FlowId));

            request.ResourcePath = "/accounts/{AwsAccountId}/flows/{FlowId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeFlowRequestMarshaller _instance = new();

        internal static DescribeFlowRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeFlowRequestMarshaller Instance => _instance;
    }
}
