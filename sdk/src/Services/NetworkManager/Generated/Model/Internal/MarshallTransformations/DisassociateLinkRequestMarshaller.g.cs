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

using Amazon.NetworkManager.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateLink Request Marshaller
    /// </summary>
    public partial class DisassociateLinkRequestMarshaller : IMarshaller<IRequest, DisassociateLinkRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateLinkRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DisassociateLinkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(publicRequest.DeviceId))
            {
                throw new AmazonNetworkManagerException("Request object does not have required field DeviceId set");
            }

            if (publicRequest.IsSetDeviceId())
            {
                request.Parameters.Add("deviceId", StringUtils.FromString(publicRequest.DeviceId));
            }

            if (string.IsNullOrEmpty(publicRequest.LinkId))
            {
                throw new AmazonNetworkManagerException("Request object does not have required field LinkId set");
            }

            if (publicRequest.IsSetLinkId())
            {
                request.Parameters.Add("linkId", StringUtils.FromString(publicRequest.LinkId));
            }

            if (!publicRequest.IsSetGlobalNetworkId())
            {
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            }
            request.AddPathResource("{GlobalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));

            request.ResourcePath = "/global-networks/{GlobalNetworkId}/link-associations";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DisassociateLinkRequestMarshaller _instance = new();

        internal static DisassociateLinkRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DisassociateLinkRequestMarshaller Instance => _instance;
    }
}
