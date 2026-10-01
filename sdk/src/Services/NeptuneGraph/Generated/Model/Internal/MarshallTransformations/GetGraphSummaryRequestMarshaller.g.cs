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

using Amazon.NeptuneGraph.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGraphSummary Request Marshaller
    /// </summary>
    public partial class GetGraphSummaryRequestMarshaller : IMarshaller<IRequest, GetGraphSummaryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGraphSummaryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetGraphSummaryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMode())
            {
                request.Parameters.Add("mode", StringUtils.FromString(publicRequest.Mode));
            }

            if (publicRequest.IsSetGraphIdentifier())
            {
                request.Headers["graphIdentifier"] = publicRequest.GraphIdentifier;
            }

            request.ResourcePath = "/summary";

            request.UseQueryString = true;

            var hostPrefixLabels = new
            {
                graphIdentifier = StringUtils.FromString(publicRequest.GraphIdentifier),
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.graphIdentifier))
            {
                throw new AmazonNeptuneGraphException("graphIdentifier can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");
            }

            request.HostPrefix = $"{hostPrefixLabels.graphIdentifier}.";

            return request;
        }

        private static readonly GetGraphSummaryRequestMarshaller _instance = new();

        internal static GetGraphSummaryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetGraphSummaryRequestMarshaller Instance => _instance;
    }
}
