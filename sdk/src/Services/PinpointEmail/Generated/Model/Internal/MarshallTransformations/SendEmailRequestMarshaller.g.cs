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

using Amazon.PinpointEmail.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendEmail Request Marshaller
    /// </summary>
    public partial class SendEmailRequestMarshaller : IMarshaller<IRequest, SendEmailRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendEmailRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointEmail");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/email/outbound-emails";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetConfigurationSetName())
            {
                context.Writer.WritePropertyName("ConfigurationSetName");
                context.Writer.WriteStringValue(publicRequest.ConfigurationSetName);
            }
            if (publicRequest.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteStartObject();

                var marshaller = EmailContentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Content, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStartObject();

                var marshaller = DestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Destination, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetEmailTags())
            {
                context.Writer.WritePropertyName("EmailTags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestEmailTagsListValue in publicRequest.EmailTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageTagMarshaller.Instance;
                    marshaller.Marshall(publicRequestEmailTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetFeedbackForwardingEmailAddress())
            {
                context.Writer.WritePropertyName("FeedbackForwardingEmailAddress");
                context.Writer.WriteStringValue(publicRequest.FeedbackForwardingEmailAddress);
            }
            if (publicRequest.IsSetFromEmailAddress())
            {
                context.Writer.WritePropertyName("FromEmailAddress");
                context.Writer.WriteStringValue(publicRequest.FromEmailAddress);
            }
            if (publicRequest.IsSetReplyToAddresses())
            {
                context.Writer.WritePropertyName("ReplyToAddresses");
                context.Writer.WriteStartArray();
                foreach (var publicRequestReplyToAddressesListValue in publicRequest.ReplyToAddresses)
                {
                    context.Writer.WriteStringValue(publicRequestReplyToAddressesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly SendEmailRequestMarshaller _instance = new();

        internal static SendEmailRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendEmailRequestMarshaller Instance => _instance;
    }
}
