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

using Amazon.ChimeSDKMessaging.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChannelsAssociatedWithChannelFlow Request Marshaller
    /// </summary>
    public partial class ListChannelsAssociatedWithChannelFlowRequestMarshaller : IMarshaller<IRequest, ListChannelsAssociatedWithChannelFlowRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListChannelsAssociatedWithChannelFlowRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListChannelsAssociatedWithChannelFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.ChannelFlowArn))
            {
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelFlowArn set");
            }

            if (publicRequest.IsSetChannelFlowArn())
            {
                request.Parameters.Add("channel-flow-arn", StringUtils.FromString(publicRequest.ChannelFlowArn));
            }

            if (publicRequest.IsSetMaxResults())
            {
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults.Value));
            }

            if (publicRequest.IsSetNextToken())
            {
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            }

            request.AddSubResource("scope", "channel-flow-associations");
            request.ResourcePath = "/channels";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListChannelsAssociatedWithChannelFlowRequestMarshaller _instance = new();

        internal static ListChannelsAssociatedWithChannelFlowRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListChannelsAssociatedWithChannelFlowRequestMarshaller Instance => _instance;
    }
}
