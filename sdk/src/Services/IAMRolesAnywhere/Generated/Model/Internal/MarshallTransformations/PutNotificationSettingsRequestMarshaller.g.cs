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

using Amazon.IAMRolesAnywhere.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IAMRolesAnywhere.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutNotificationSettings Request Marshaller
    /// </summary>
    public partial class PutNotificationSettingsRequestMarshaller : IMarshaller<IRequest, PutNotificationSettingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutNotificationSettingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutNotificationSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IAMRolesAnywhere");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/put-notifications-settings";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetNotificationSettings())
            {
                context.Writer.WritePropertyName("notificationSettings");
                context.Writer.WriteStartArray();
                foreach (var publicRequestNotificationSettingsListValue in publicRequest.NotificationSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NotificationSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequestNotificationSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTrustAnchorId())
            {
                context.Writer.WritePropertyName("trustAnchorId");
                context.Writer.WriteStringValue(publicRequest.TrustAnchorId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutNotificationSettingsRequestMarshaller _instance = new();

        internal static PutNotificationSettingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutNotificationSettingsRequestMarshaller Instance => _instance;
    }
}
