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
    /// GetDataAccess Request Marshaller
    /// </summary>
    public partial class GetDataAccessRequestMarshaller : IMarshaller<IRequest, GetDataAccessRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDataAccessRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetDataAccessRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3Control");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAccountId())
            {
                request.Headers["x-amz-account-id"] = publicRequest.AccountId;
            }

            request.ResourcePath = "/v20180820/accessgrantsinstance/dataaccess";

            if (publicRequest.IsSetAuditContext())
            {
                request.Parameters.Add("auditContext", StringUtils.FromString(publicRequest.AuditContext));
            }

            if (publicRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("durationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds.Value));
            }

            if (string.IsNullOrEmpty(publicRequest.Permission))
            {
                throw new AmazonS3ControlException("Request object does not have required field Permission set");
            }

            if (publicRequest.IsSetPermission())
            {
                request.Parameters.Add("permission", StringUtils.FromString(publicRequest.Permission));
            }

            if (publicRequest.IsSetPrivilege())
            {
                request.Parameters.Add("privilege", StringUtils.FromString(publicRequest.Privilege));
            }

            if (string.IsNullOrEmpty(publicRequest.Target))
            {
                throw new AmazonS3ControlException("Request object does not have required field Target set");
            }

            if (publicRequest.IsSetTarget())
            {
                request.Parameters.Add("target", StringUtils.FromString(publicRequest.Target));
            }

            if (publicRequest.IsSetTargetType())
            {
                request.Parameters.Add("targetType", StringUtils.FromString(publicRequest.TargetType));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly GetDataAccessRequestMarshaller _instance = new();

        internal static GetDataAccessRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDataAccessRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetDataAccessRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, GetDataAccessRequest publicRequest);
    }
}
