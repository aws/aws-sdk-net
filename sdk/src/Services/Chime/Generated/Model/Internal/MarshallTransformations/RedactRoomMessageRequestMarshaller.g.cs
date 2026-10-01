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

using Amazon.Chime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedactRoomMessage Request Marshaller
    /// </summary>
    public partial class RedactRoomMessageRequestMarshaller : IMarshaller<IRequest, RedactRoomMessageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RedactRoomMessageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RedactRoomMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAccountId())
            {
                throw new AmazonChimeException("Request object does not have required field AccountId set");
            }
            request.AddPathResource("{AccountId}", StringUtils.FromString(publicRequest.AccountId));

            if (!publicRequest.IsSetMessageId())
            {
                throw new AmazonChimeException("Request object does not have required field MessageId set");
            }
            request.AddPathResource("{MessageId}", StringUtils.FromString(publicRequest.MessageId));

            if (!publicRequest.IsSetRoomId())
            {
                throw new AmazonChimeException("Request object does not have required field RoomId set");
            }
            request.AddPathResource("{RoomId}", StringUtils.FromString(publicRequest.RoomId));

            request.AddSubResource("operation", "redact");
            request.ResourcePath = "/accounts/{AccountId}/rooms/{RoomId}/messages/{MessageId}";

            return request;
        }

        private static readonly RedactRoomMessageRequestMarshaller _instance = new();

        internal static RedactRoomMessageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RedactRoomMessageRequestMarshaller Instance => _instance;
    }
}
