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

using Amazon.MediaConnect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevokeFlowEntitlement Request Marshaller
    /// </summary>
    public partial class RevokeFlowEntitlementRequestMarshaller : IMarshaller<IRequest, RevokeFlowEntitlementRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RevokeFlowEntitlementRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RevokeFlowEntitlementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetEntitlementArn())
            {
                throw new AmazonMediaConnectException("Request object does not have required field EntitlementArn set");
            }
            request.AddPathResource("{EntitlementArn}", StringUtils.FromString(publicRequest.EntitlementArn));

            if (!publicRequest.IsSetFlowArn())
            {
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            }
            request.AddPathResource("{FlowArn}", StringUtils.FromString(publicRequest.FlowArn));

            request.ResourcePath = "/v1/flows/{FlowArn}/entitlements/{EntitlementArn}";

            return request;
        }

        private static readonly RevokeFlowEntitlementRequestMarshaller _instance = new();

        internal static RevokeFlowEntitlementRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RevokeFlowEntitlementRequestMarshaller Instance => _instance;
    }
}
