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

using Amazon.MainframeModernization.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBatchJobRestartPoints Request Marshaller
    /// </summary>
    public partial class ListBatchJobRestartPointsRequestMarshaller : IMarshaller<IRequest, ListBatchJobRestartPointsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBatchJobRestartPointsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListBatchJobRestartPointsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MainframeModernization");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-28";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAuthSecretsManagerArn())
            {
                request.Parameters.Add("authSecretsManagerArn", StringUtils.FromString(publicRequest.AuthSecretsManagerArn));
            }

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonMainframeModernizationException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetExecutionId())
            {
                throw new AmazonMainframeModernizationException("Request object does not have required field ExecutionId set");
            }
            request.AddPathResource("{executionId}", StringUtils.FromString(publicRequest.ExecutionId));

            request.ResourcePath = "/applications/{applicationId}/batch-job-executions/{executionId}/steps";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListBatchJobRestartPointsRequestMarshaller _instance = new();

        internal static ListBatchJobRestartPointsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListBatchJobRestartPointsRequestMarshaller Instance => _instance;
    }
}
