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

using Amazon.ApiGatewayV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetIntegration Request Marshaller
    /// </summary>
    public partial class GetIntegrationRequestMarshaller : IMarshaller<IRequest, GetIntegrationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetIntegrationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApiId())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            }
            request.AddPathResource("{ApiId}", StringUtils.FromString(publicRequest.ApiId));

            if (!publicRequest.IsSetIntegrationId())
            {
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationId set");
            }
            request.AddPathResource("{IntegrationId}", StringUtils.FromString(publicRequest.IntegrationId));

            request.ResourcePath = "/v2/apis/{ApiId}/integrations/{IntegrationId}";

            return request;
        }

        private static readonly GetIntegrationRequestMarshaller _instance = new();

        internal static GetIntegrationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetIntegrationRequestMarshaller Instance => _instance;
    }
}
