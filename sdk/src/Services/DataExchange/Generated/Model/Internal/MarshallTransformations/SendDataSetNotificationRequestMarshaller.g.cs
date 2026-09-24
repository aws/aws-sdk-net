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

using Amazon.DataExchange.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendDataSetNotification Request Marshaller
    /// </summary>
    public partial class SendDataSetNotificationRequestMarshaller : IMarshaller<IRequest, SendDataSetNotificationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendDataSetNotificationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendDataSetNotificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataExchange");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDataSetId())
            {
                throw new AmazonDataExchangeException("Request object does not have required field DataSetId set");
            }
            request.AddPathResource("{DataSetId}", StringUtils.FromString(publicRequest.DataSetId));

            request.ResourcePath = "/v1/data-sets/{DataSetId}/notification";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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
            if (publicRequest.IsSetComment())
            {
                context.Writer.WritePropertyName("Comment");
                context.Writer.WriteStringValue(publicRequest.Comment);
            }
            if (publicRequest.IsSetDetails())
            {
                context.Writer.WritePropertyName("Details");
                context.Writer.WriteStartObject();

                var marshaller = NotificationDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Details, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStartObject();

                var marshaller = ScopeDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Scope, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly SendDataSetNotificationRequestMarshaller _instance = new();

        internal static SendDataSetNotificationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendDataSetNotificationRequestMarshaller Instance => _instance;
    }
}
