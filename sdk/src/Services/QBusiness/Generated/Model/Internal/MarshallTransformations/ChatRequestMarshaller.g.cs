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

using Amazon.QBusiness.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Chat Request Marshaller
    /// </summary>
    public partial class ChatRequestMarshaller : IMarshaller<IRequest, ChatRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChatRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ChatRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
#if NET8_0_OR_GREATER
            request.HttpProtocolVersion = System.Net.HttpVersion.Version20;
#endif
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("clientToken", Guid.NewGuid().ToString());
            }

            if (publicRequest.IsSetConversationId())
            {
                request.Parameters.Add("conversationId", StringUtils.FromString(publicRequest.ConversationId));
            }

            if (publicRequest.IsSetParentMessageId())
            {
                request.Parameters.Add("parentMessageId", StringUtils.FromString(publicRequest.ParentMessageId));
            }

            if (publicRequest.IsSetUserGroups())
            {
                request.ParameterCollection.Add("userGroups", publicRequest.UserGroups);
            }

            if (publicRequest.IsSetUserId())
            {
                request.Parameters.Add("userId", StringUtils.FromString(publicRequest.UserId));
            }

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            request.ResourcePath = "/applications/{applicationId}/conversations";
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            request.EventStreamPublisher = new ChatInputStreamPublisherMarshaller(publicRequest.InputStreamPublisher);

            request.UseQueryString = true;

            return request;
        }

        private static readonly ChatRequestMarshaller _instance = new();

        internal static ChatRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ChatRequestMarshaller Instance => _instance;
    }
}
