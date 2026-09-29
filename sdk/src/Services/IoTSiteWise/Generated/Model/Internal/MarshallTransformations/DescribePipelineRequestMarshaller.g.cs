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

using Amazon.IoTSiteWise.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribePipeline Request Marshaller
    /// </summary>
    public partial class DescribePipelineRequestMarshaller : IMarshaller<IRequest, DescribePipelineRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribePipelineRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetPipelineVersion())
            {
                request.Parameters.Add("version", StringUtils.FromString(publicRequest.PipelineVersion));
            }

            if (!publicRequest.IsSetPipelineName())
            {
                throw new AmazonIoTSiteWiseException("Request object does not have required field PipelineName set");
            }
            request.AddPathResource("{pipelineName}", StringUtils.FromString(publicRequest.PipelineName));

            if (!publicRequest.IsSetWorkspaceName())
            {
                throw new AmazonIoTSiteWiseException("Request object does not have required field WorkspaceName set");
            }
            request.AddPathResource("{workspaceName}", StringUtils.FromString(publicRequest.WorkspaceName));

            request.ResourcePath = "/workspaces/{workspaceName}/pipelines/{pipelineName}";

            request.UseQueryString = true;

            request.HostPrefix = $"api.";

            return request;
        }

        private static readonly DescribePipelineRequestMarshaller _instance = new();

        internal static DescribePipelineRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribePipelineRequestMarshaller Instance => _instance;
    }
}
