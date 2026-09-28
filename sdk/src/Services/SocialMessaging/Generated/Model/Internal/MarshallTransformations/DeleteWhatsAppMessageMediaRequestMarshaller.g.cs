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
    /// DeleteWhatsAppMessageMedia Request Marshaller
    /// </summary>
    public partial class DeleteWhatsAppMessageMediaRequestMarshaller : IMarshaller<IRequest, DeleteWhatsAppMessageMediaRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteWhatsAppMessageMediaRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteWhatsAppMessageMediaRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SocialMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(publicRequest.MediaId))
            {
                throw new AmazonSocialMessagingException("Request object does not have required field MediaId set");
            }

            if (publicRequest.IsSetMediaId())
            {
                request.Parameters.Add("mediaId", StringUtils.FromString(publicRequest.MediaId));
            }

            if (string.IsNullOrEmpty(publicRequest.OriginationPhoneNumberId))
            {
                throw new AmazonSocialMessagingException("Request object does not have required field OriginationPhoneNumberId set");
            }

            if (publicRequest.IsSetOriginationPhoneNumberId())
            {
                request.Parameters.Add("originationPhoneNumberId", StringUtils.FromString(publicRequest.OriginationPhoneNumberId));
            }

            request.ResourcePath = "/v1/whatsapp/media";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteWhatsAppMessageMediaRequestMarshaller _instance = new();

        internal static DeleteWhatsAppMessageMediaRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteWhatsAppMessageMediaRequestMarshaller Instance => _instance;
    }
}
