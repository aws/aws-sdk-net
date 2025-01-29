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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChannelMessages Request Marshaller
    /// </summary>       
    public class ListChannelMessagesRequestMarshaller : IMarshaller<IRequest, ListChannelMessagesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListChannelMessagesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListChannelMessagesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetChannelArn())
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelArn set");
            request.AddPathResource("{channelArn}", StringUtils.FromString(publicRequest.ChannelArn));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetNotAfter())
                request.Parameters.Add("not-after", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.NotAfter));
            
            if (publicRequest.IsSetNotBefore())
                request.Parameters.Add("not-before", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.NotBefore));
            
            if (publicRequest.IsSetSortOrder())
                request.Parameters.Add("sort-order", StringUtils.FromString(publicRequest.SortOrder));
            
            if (publicRequest.IsSetSubChannelId())
                request.Parameters.Add("sub-channel-id", StringUtils.FromString(publicRequest.SubChannelId));
            request.ResourcePath = "/channels/{channelArn}/messages";
        
            if (publicRequest.IsSetChimeBearer()) 
            {
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;
            }
            request.UseQueryString = true;

            return request;
        }
        private static ListChannelMessagesRequestMarshaller _instance = new ListChannelMessagesRequestMarshaller();        

        internal static ListChannelMessagesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListChannelMessagesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}