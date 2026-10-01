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

using Amazon.SocialMessaging.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListWhatsAppFlowAssets Request Marshaller
    /// </summary>
    public partial class ListWhatsAppFlowAssetsRequestMarshaller : IMarshaller<IRequest, ListWhatsAppFlowAssetsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListWhatsAppFlowAssetsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListWhatsAppFlowAssetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SocialMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.FlowId))
            {
                throw new AmazonSocialMessagingException("Request object does not have required field FlowId set");
            }

            if (publicRequest.IsSetFlowId())
            {
                request.Parameters.Add("flowId", StringUtils.FromString(publicRequest.FlowId));
            }

            if (string.IsNullOrEmpty(publicRequest.Id))
            {
                throw new AmazonSocialMessagingException("Request object does not have required field Id set");
            }

            if (publicRequest.IsSetId())
            {
                request.Parameters.Add("id", StringUtils.FromString(publicRequest.Id));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            }

            request.ResourcePath = "/v1/whatsapp/flow/assets";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListWhatsAppFlowAssetsRequestMarshaller _instance = new();

        internal static ListWhatsAppFlowAssetsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListWhatsAppFlowAssetsRequestMarshaller Instance => _instance;
    }
}
