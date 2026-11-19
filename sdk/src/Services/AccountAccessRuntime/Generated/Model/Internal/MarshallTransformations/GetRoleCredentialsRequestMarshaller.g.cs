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

using Amazon.AccountAccessRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AccountAccessRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRoleCredentials Request Marshaller
    /// </summary>
    public partial class GetRoleCredentialsRequestMarshaller : IMarshaller<IRequest, GetRoleCredentialsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRoleCredentialsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetRoleCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccountAccessRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.AccessType))
            {
                throw new AmazonAccountAccessRuntimeException("Request object does not have required field AccessType set");
            }

            if (publicRequest.IsSetAccessType())
            {
                request.Parameters.Add("accessType", StringUtils.FromString(publicRequest.AccessType));
            }

            if (string.IsNullOrEmpty(publicRequest.RoleArn))
            {
                throw new AmazonAccountAccessRuntimeException("Request object does not have required field RoleArn set");
            }

            if (publicRequest.IsSetRoleArn())
            {
                request.Parameters.Add("roleArn", StringUtils.FromString(publicRequest.RoleArn));
            }

            if (publicRequest.IsSetSessionDuration())
            {
                request.Parameters.Add("sessionDuration", StringUtils.FromInt(publicRequest.SessionDuration.Value));
            }

            if (publicRequest.IsSetSessionName())
            {
                request.Parameters.Add("sessionName", StringUtils.FromString(publicRequest.SessionName));
            }

            if (string.IsNullOrEmpty(publicRequest.TenantId))
            {
                throw new AmazonAccountAccessRuntimeException("Request object does not have required field TenantId set");
            }

            if (publicRequest.IsSetTenantId())
            {
                request.Parameters.Add("tenantId", StringUtils.FromString(publicRequest.TenantId));
            }

            request.ResourcePath = "/access/credentials";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetRoleCredentialsRequestMarshaller _instance = new();

        internal static GetRoleCredentialsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetRoleCredentialsRequestMarshaller Instance => _instance;
    }
}
