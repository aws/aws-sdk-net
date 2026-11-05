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

using Amazon.Connect.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartOutboundEmailContact Request Marshaller
    /// </summary>
    public partial class StartOutboundEmailContactRequestMarshaller : IMarshaller<IRequest, StartOutboundEmailContactRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartOutboundEmailContactRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartOutboundEmailContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/contact/outbound-email";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAdditionalRecipients())
            {
                context.Writer.WritePropertyName("AdditionalRecipients");
                context.Writer.WriteStartObject();

                var marshaller = OutboundAdditionalRecipientsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdditionalRecipients, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetContactId())
            {
                context.Writer.WritePropertyName("ContactId");
                context.Writer.WriteStringValue(publicRequest.ContactId);
            }
            if (publicRequest.IsSetDestinationEmailAddress())
            {
                context.Writer.WritePropertyName("DestinationEmailAddress");
                context.Writer.WriteStartObject();

                var marshaller = EmailAddressInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationEmailAddress, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetEmailMessage())
            {
                context.Writer.WritePropertyName("EmailMessage");
                context.Writer.WriteStartObject();

                var marshaller = OutboundEmailContentMarshaller.Instance;
                marshaller.Marshall(publicRequest.EmailMessage, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFromEmailAddress())
            {
                context.Writer.WritePropertyName("FromEmailAddress");
                context.Writer.WriteStartObject();

                var marshaller = EmailAddressInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.FromEmailAddress, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(publicRequest.InstanceId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartOutboundEmailContactRequestMarshaller _instance = new();

        internal static StartOutboundEmailContactRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartOutboundEmailContactRequestMarshaller Instance => _instance;
    }
}
