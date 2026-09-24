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

using Amazon.Signer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSigningJobs Request Marshaller
    /// </summary>
    public partial class ListSigningJobsRequestMarshaller : IMarshaller<IRequest, ListSigningJobsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSigningJobsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListSigningJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Signer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-25";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetIsRevoked())
            {
                request.Parameters.Add("isRevoked", StringUtils.FromBool(publicRequest.IsRevoked.Value));
            }

            if (publicRequest.IsSetJobInvoker())
            {
                request.Parameters.Add("jobInvoker", StringUtils.FromString(publicRequest.JobInvoker));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetPlatformId())
            {
                request.Parameters.Add("platformId", StringUtils.FromString(publicRequest.PlatformId));
            }

            if (publicRequest.IsSetRequestedBy())
            {
                request.Parameters.Add("requestedBy", StringUtils.FromString(publicRequest.RequestedBy));
            }

            if (publicRequest.IsSetSignatureExpiresAfter())
            {
                request.Parameters.Add("signatureExpiresAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.SignatureExpiresAfter));
            }

            if (publicRequest.IsSetSignatureExpiresBefore())
            {
                request.Parameters.Add("signatureExpiresBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.SignatureExpiresBefore));
            }

            if (publicRequest.IsSetStatus())
            {
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            }

            request.ResourcePath = "/signing-jobs";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListSigningJobsRequestMarshaller _instance = new();

        internal static ListSigningJobsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListSigningJobsRequestMarshaller Instance => _instance;
    }
}
