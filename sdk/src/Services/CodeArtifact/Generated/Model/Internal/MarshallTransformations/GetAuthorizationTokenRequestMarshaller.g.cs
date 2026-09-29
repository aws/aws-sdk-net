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

using Amazon.CodeArtifact.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAuthorizationToken Request Marshaller
    /// </summary>
    public partial class GetAuthorizationTokenRequestMarshaller : IMarshaller<IRequest, GetAuthorizationTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAuthorizationTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetAuthorizationTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeArtifact");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-22";
            request.HttpMethod = "POST";

            if (string.IsNullOrEmpty(publicRequest.Domain))
            {
                throw new AmazonCodeArtifactException("Request object does not have required field Domain set");
            }

            if (publicRequest.IsSetDomain())
            {
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            }

            if (publicRequest.IsSetDomainOwner())
            {
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            }

            if (publicRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("duration", StringUtils.FromLong(publicRequest.DurationSeconds.Value));
            }

            request.ResourcePath = "/v1/authorization-token";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetAuthorizationTokenRequestMarshaller _instance = new();

        internal static GetAuthorizationTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetAuthorizationTokenRequestMarshaller Instance => _instance;
    }
}
