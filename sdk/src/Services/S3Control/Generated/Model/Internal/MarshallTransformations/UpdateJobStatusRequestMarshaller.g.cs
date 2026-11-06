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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateJobStatus Request Marshaller
    /// </summary>
    public partial class UpdateJobStatusRequestMarshaller : IMarshaller<IRequest, UpdateJobStatusRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobStatusRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateJobStatusRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";

            if (publicRequest.IsSetAccountId())
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }

            if (!publicRequest.IsSetJobId())
            {
                throw new AmazonS3ControlException("Request object does not have required field JobId set");
            }
            request.AddPathResource("{JobId}", StringUtils.FromString(publicRequest.JobId));

            request.ResourcePath = "/v20180820/jobs/{JobId}/status";

            if (string.IsNullOrEmpty(publicRequest.RequestedJobStatus))
            {
                throw new AmazonS3ControlException("Request object does not have required field RequestedJobStatus set");
            }

            if (publicRequest.IsSetRequestedJobStatus())
            {
                request.Parameters.Add("requestedJobStatus", StringUtils.FromString(publicRequest.RequestedJobStatus));
            }

            if (publicRequest.IsSetStatusUpdateReason())
            {
                request.Parameters.Add("statusUpdateReason", StringUtils.FromString(publicRequest.StatusUpdateReason));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly UpdateJobStatusRequestMarshaller _instance = new();

        internal static UpdateJobStatusRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateJobStatusRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, UpdateJobStatusRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, UpdateJobStatusRequest publicRequest);
    }
}
