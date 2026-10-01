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

using Amazon.Wickr.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetOidcInfo Request Marshaller
    /// </summary>
    public partial class GetOidcInfoRequestMarshaller : IMarshaller<IRequest, GetOidcInfoRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetOidcInfoRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetOidcInfoRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Wickr");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetCertificate())
            {
                request.Parameters.Add("certificate", StringUtils.FromString(publicRequest.Certificate));
            }

            if (publicRequest.IsSetClientId())
            {
                request.Parameters.Add("clientId", StringUtils.FromString(publicRequest.ClientId));
            }

            if (publicRequest.IsSetClientSecret())
            {
                request.Parameters.Add("clientSecret", StringUtils.FromString(publicRequest.ClientSecret));
            }

            if (publicRequest.IsSetCode())
            {
                request.Parameters.Add("code", StringUtils.FromString(publicRequest.Code));
            }

            if (publicRequest.IsSetCodeVerifier())
            {
                request.Parameters.Add("codeVerifier", StringUtils.FromString(publicRequest.CodeVerifier));
            }

            if (publicRequest.IsSetGrantType())
            {
                request.Parameters.Add("grantType", StringUtils.FromString(publicRequest.GrantType));
            }

            if (publicRequest.IsSetRedirectUri())
            {
                request.Parameters.Add("redirectUri", StringUtils.FromString(publicRequest.RedirectUri));
            }

            if (publicRequest.IsSetUrl())
            {
                request.Parameters.Add("url", StringUtils.FromString(publicRequest.Url));
            }

            if (!publicRequest.IsSetNetworkId())
            {
                throw new AmazonWickrException("Request object does not have required field NetworkId set");
            }
            request.AddPathResource("{networkId}", StringUtils.FromString(publicRequest.NetworkId));

            request.ResourcePath = "/networks/{networkId}/oidc";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetOidcInfoRequestMarshaller _instance = new();

        internal static GetOidcInfoRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetOidcInfoRequestMarshaller Instance => _instance;
    }
}
