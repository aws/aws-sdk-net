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

using Amazon.AccountAccess.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AccountAccess.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEntitlement Request Marshaller
    /// </summary>
    public partial class GetEntitlementRequestMarshaller : IMarshaller<IRequest, GetEntitlementRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEntitlementRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEntitlementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccountAccess");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.ApplicationArn))
            {
                throw new AmazonAccountAccessException("Request object does not have required field ApplicationArn set");
            }

            if (publicRequest.IsSetApplicationArn())
            {
                request.Parameters.Add("applicationArn", StringUtils.FromString(publicRequest.ApplicationArn));
            }

            if (!publicRequest.IsSetEntitlementId())
            {
                throw new AmazonAccountAccessException("Request object does not have required field EntitlementId set");
            }
            request.AddPathResource("{entitlementId}", StringUtils.FromString(publicRequest.EntitlementId));

            request.ResourcePath = "/entitlements/{entitlementId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetEntitlementRequestMarshaller _instance = new();

        internal static GetEntitlementRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEntitlementRequestMarshaller Instance => _instance;
    }
}
