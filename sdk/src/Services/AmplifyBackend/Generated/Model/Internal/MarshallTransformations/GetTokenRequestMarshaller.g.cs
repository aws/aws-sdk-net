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

using Amazon.AmplifyBackend.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetToken Request Marshaller
    /// </summary>
    public partial class GetTokenRequestMarshaller : IMarshaller<IRequest, GetTokenRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTokenRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetTokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AmplifyBackend");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-11";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAppId())
            {
                throw new AmazonAmplifyBackendException("Request object does not have required field AppId set");
            }
            request.AddPathResource("{AppId}", StringUtils.FromString(publicRequest.AppId));

            if (!publicRequest.IsSetSessionId())
            {
                throw new AmazonAmplifyBackendException("Request object does not have required field SessionId set");
            }
            request.AddPathResource("{SessionId}", StringUtils.FromString(publicRequest.SessionId));

            request.ResourcePath = "/backend/{AppId}/challenge/{SessionId}";

            return request;
        }

        private static readonly GetTokenRequestMarshaller _instance = new();

        internal static GetTokenRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetTokenRequestMarshaller Instance => _instance;
    }
}
