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

using Amazon.CodeStarNotifications.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeStarNotifications.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNotificationRule Request Marshaller
    /// </summary>
    public partial class UpdateNotificationRuleRequestMarshaller : IMarshaller<IRequest, UpdateNotificationRuleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNotificationRuleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateNotificationRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeStarNotifications");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateNotificationRule";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(publicRequest.Arn);
            }
            if (publicRequest.IsSetDetailType())
            {
                context.Writer.WritePropertyName("DetailType");
                context.Writer.WriteStringValue(publicRequest.DetailType);
            }
            if (publicRequest.IsSetEventTypeIds())
            {
                context.Writer.WritePropertyName("EventTypeIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestEventTypeIdsListValue in publicRequest.EventTypeIds)
                {
                    context.Writer.WriteStringValue(publicRequestEventTypeIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }
            if (publicRequest.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTargetsListValue in publicRequest.Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(publicRequestTargetsListValue, context);

                    context.Writer.WriteEndObject();
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

        private static readonly UpdateNotificationRuleRequestMarshaller _instance = new();

        internal static UpdateNotificationRuleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateNotificationRuleRequestMarshaller Instance => _instance;
    }
}
