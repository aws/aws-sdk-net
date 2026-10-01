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
    /// DisassociateCustomerGateway Request Marshaller
    /// </summary>
    public partial class DisassociateCustomerGatewayRequestMarshaller : IMarshaller<IRequest, DisassociateCustomerGatewayRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateCustomerGatewayRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DisassociateCustomerGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkManager");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-05";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetCustomerGatewayArn())
            {
                throw new AmazonNetworkManagerException("Request object does not have required field CustomerGatewayArn set");
            }
            request.AddPathResource("{CustomerGatewayArn}", StringUtils.FromString(publicRequest.CustomerGatewayArn));

            if (!publicRequest.IsSetGlobalNetworkId())
            {
                throw new AmazonNetworkManagerException("Request object does not have required field GlobalNetworkId set");
            }
            request.AddPathResource("{GlobalNetworkId}", StringUtils.FromString(publicRequest.GlobalNetworkId));

            request.ResourcePath = "/global-networks/{GlobalNetworkId}/customer-gateway-associations/{CustomerGatewayArn}";

            return request;
        }

        private static readonly DisassociateCustomerGatewayRequestMarshaller _instance = new();

        internal static DisassociateCustomerGatewayRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DisassociateCustomerGatewayRequestMarshaller Instance => _instance;
    }
}
