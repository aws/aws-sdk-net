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

using Amazon.RTBFabric.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteOutboundExternalLink Request Marshaller
    /// </summary>
    public partial class DeleteOutboundExternalLinkRequestMarshaller : IMarshaller<IRequest, DeleteOutboundExternalLinkRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteOutboundExternalLinkRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteOutboundExternalLinkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RTBFabric");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-15";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetGatewayId())
            {
                throw new AmazonRTBFabricException("Request object does not have required field GatewayId set");
            }
            request.AddPathResource("{gatewayId}", StringUtils.FromString(publicRequest.GatewayId));

            if (!publicRequest.IsSetLinkId())
            {
                throw new AmazonRTBFabricException("Request object does not have required field LinkId set");
            }
            request.AddPathResource("{linkId}", StringUtils.FromString(publicRequest.LinkId));

            request.ResourcePath = "/requester-gateway/{gatewayId}/outbound-external-link/{linkId}";

            return request;
        }

        private static readonly DeleteOutboundExternalLinkRequestMarshaller _instance = new();

        internal static DeleteOutboundExternalLinkRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteOutboundExternalLinkRequestMarshaller Instance => _instance;
    }
}
