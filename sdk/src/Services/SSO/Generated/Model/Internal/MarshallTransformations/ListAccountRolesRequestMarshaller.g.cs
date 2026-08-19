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
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SSO.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAccountRoles Request Marshaller
    /// </summary>
    public partial class ListAccountRolesRequestMarshaller : IMarshaller<IRequest, ListAccountRolesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAccountRolesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAccountRolesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSO");
            request.Headers["Content-Type"] = "application/json";
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

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("max_result", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("next_token", StringUtils.FromString(publicRequest.NextToken));
            }

            if (publicRequest.IsSetAccessToken())
            {
                request.Headers["x-amz-sso_bearer_token"] = publicRequest.AccessToken;
            }

            request.ResourcePath = "/assignment/roles";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListAccountRolesRequestMarshaller _instance = new();

        internal static ListAccountRolesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAccountRolesRequestMarshaller Instance => _instance;
    }
}
