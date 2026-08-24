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

using Amazon.SSO.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SSO.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSO");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-10";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.AccountId))
            {
                throw new AmazonSSOException("Request object does not have required field AccountId set");
            }

            if (publicRequest.IsSetAccountId())
            {
                request.Parameters.Add("account_id", StringUtils.FromString(publicRequest.AccountId));
            }

            if (string.IsNullOrEmpty(publicRequest.RoleName))
            {
                throw new AmazonSSOException("Request object does not have required field RoleName set");
            }

            if (publicRequest.IsSetRoleName())
            {
                request.Parameters.Add("role_name", StringUtils.FromString(publicRequest.RoleName));
            }

            if (publicRequest.IsSetAccessToken())
            {
                request.Headers["x-amz-sso_bearer_token"] = publicRequest.AccessToken;
            }

            request.ResourcePath = "/federation/credentials";

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
