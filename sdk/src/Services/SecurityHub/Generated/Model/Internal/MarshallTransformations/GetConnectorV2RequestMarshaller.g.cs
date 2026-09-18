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

using Amazon.SecurityHub.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConnectorV2 Request Marshaller
    /// </summary>
    public partial class GetConnectorV2RequestMarshaller : IMarshaller<IRequest, GetConnectorV2Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConnectorV2Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetConnectorV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetConnectorId())
            {
                throw new AmazonSecurityHubException("Request object does not have required field ConnectorId set");
            }
            request.AddPathResource("{ConnectorId+}", StringUtils.FromString(publicRequest.ConnectorId.TrimStart('/')));

            request.ResourcePath = "/connectorsv2/{ConnectorId+}";

            return request;
        }

        private static readonly GetConnectorV2RequestMarshaller _instance = new();

        internal static GetConnectorV2RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetConnectorV2RequestMarshaller Instance => _instance;
    }
}
