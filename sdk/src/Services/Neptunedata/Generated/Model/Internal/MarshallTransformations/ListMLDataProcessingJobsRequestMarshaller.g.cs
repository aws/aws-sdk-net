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

using Amazon.Neptunedata.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListMLDataProcessingJobs Request Marshaller
    /// </summary>
    public partial class ListMLDataProcessingJobsRequestMarshaller : IMarshaller<IRequest, ListMLDataProcessingJobsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListMLDataProcessingJobsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListMLDataProcessingJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptunedata");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetMaxItems())
            {
                request.Parameters.Add("maxItems", StringUtils.FromInt(publicRequest.MaxItems.Value));
            }

            if (publicRequest.IsSetNeptuneIamRoleArn())
            {
                request.Parameters.Add("neptuneIamRoleArn", StringUtils.FromString(publicRequest.NeptuneIamRoleArn));
            }

            request.ResourcePath = "/ml/dataprocessing";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListMLDataProcessingJobsRequestMarshaller _instance = new();

        internal static ListMLDataProcessingJobsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListMLDataProcessingJobsRequestMarshaller Instance => _instance;
    }
}
