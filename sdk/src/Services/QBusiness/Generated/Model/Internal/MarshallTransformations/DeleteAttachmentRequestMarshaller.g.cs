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
    /// DeleteAttachment Request Marshaller
    /// </summary>
    public partial class DeleteAttachmentRequestMarshaller : IMarshaller<IRequest, DeleteAttachmentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAttachmentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAttachmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetUserId())
            {
                request.Parameters.Add("userId", StringUtils.FromString(publicRequest.UserId));
            }

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetAttachmentId())
            {
                throw new AmazonQBusinessException("Request object does not have required field AttachmentId set");
            }
            request.AddPathResource("{attachmentId}", StringUtils.FromString(publicRequest.AttachmentId));

            if (!publicRequest.IsSetConversationId())
            {
                throw new AmazonQBusinessException("Request object does not have required field ConversationId set");
            }
            request.AddPathResource("{conversationId}", StringUtils.FromString(publicRequest.ConversationId));

            request.ResourcePath = "/applications/{applicationId}/conversations/{conversationId}/attachments/{attachmentId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteAttachmentRequestMarshaller _instance = new();

        internal static DeleteAttachmentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAttachmentRequestMarshaller Instance => _instance;
    }
}
