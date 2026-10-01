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

using Amazon.Omics.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRunsInBatch Request Marshaller
    /// </summary>
    public partial class ListRunsInBatchRequestMarshaller : IMarshaller<IRequest, ListRunsInBatchRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRunsInBatchRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListRunsInBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxItems())
            {
                request.Parameters.Add("maxItems", StringUtils.FromInt(publicRequest.MaxItems.Value));
            }

            if (publicRequest.IsSetRunId())
            {
                request.Parameters.Add("runId", StringUtils.FromString(publicRequest.RunId));
            }

            if (publicRequest.IsSetRunSettingId())
            {
                request.Parameters.Add("runSettingId", StringUtils.FromString(publicRequest.RunSettingId));
            }

            if (publicRequest.IsSetStartingToken())
            {
                request.Parameters.Add("startingToken", StringUtils.FromString(publicRequest.StartingToken));
            }

            if (publicRequest.IsSetSubmissionStatus())
            {
                request.Parameters.Add("submissionStatus", StringUtils.FromString(publicRequest.SubmissionStatus));
            }

            if (!publicRequest.IsSetBatchId())
            {
                throw new AmazonOmicsException("Request object does not have required field BatchId set");
            }
            request.AddPathResource("{batchId}", StringUtils.FromString(publicRequest.BatchId));

            request.ResourcePath = "/runBatch/{batchId}/run";

            request.UseQueryString = true;

            request.HostPrefix = $"workflows-";

            return request;
        }

        private static readonly ListRunsInBatchRequestMarshaller _instance = new();

        internal static ListRunsInBatchRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListRunsInBatchRequestMarshaller Instance => _instance;
    }
}
