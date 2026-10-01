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
    /// GetChannelMessage Request Marshaller
    /// </summary>
    public partial class GetChannelMessageRequestMarshaller : IMarshaller<IRequest, GetChannelMessageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetChannelMessageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetChannelMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetSubChannelId())
            {
                request.Parameters.Add("sub-channel-id", StringUtils.FromString(publicRequest.SubChannelId));
            }

            if (publicRequest.IsSetChimeBearer())
            {
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;
            }

            if (!publicRequest.IsSetChannelArn())
            {
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelArn set");
            }
            request.AddPathResource("{ChannelArn}", StringUtils.FromString(publicRequest.ChannelArn));

            if (!publicRequest.IsSetMessageId())
            {
                throw new AmazonChimeSDKMessagingException("Request object does not have required field MessageId set");
            }
            request.AddPathResource("{MessageId}", StringUtils.FromString(publicRequest.MessageId));

            request.ResourcePath = "/channels/{ChannelArn}/messages/{MessageId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetChannelMessageRequestMarshaller _instance = new();

        internal static GetChannelMessageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetChannelMessageRequestMarshaller Instance => _instance;
    }
}
