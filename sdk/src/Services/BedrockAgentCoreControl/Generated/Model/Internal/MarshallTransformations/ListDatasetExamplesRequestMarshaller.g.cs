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
    /// ListDatasetExamples Request Marshaller
    /// </summary>
    public partial class ListDatasetExamplesRequestMarshaller : IMarshaller<IRequest, ListDatasetExamplesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDatasetExamplesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListDatasetExamplesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetDatasetVersion())
            {
                request.Parameters.Add("datasetVersion", StringUtils.FromString(publicRequest.DatasetVersion));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (!publicRequest.IsSetDatasetId())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field DatasetId set");
            }
            request.AddPathResource("{datasetId}", StringUtils.FromString(publicRequest.DatasetId));

            request.ResourcePath = "/datasets/{datasetId}/examples";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListDatasetExamplesRequestMarshaller _instance = new();

        internal static ListDatasetExamplesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListDatasetExamplesRequestMarshaller Instance => _instance;
    }
}
