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

using Amazon.ObservabilityAdmin.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListResourceTelemetry Request Marshaller
    /// </summary>
    public partial class ListResourceTelemetryRequestMarshaller : IMarshaller<IRequest, ListResourceTelemetryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListResourceTelemetryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListResourceTelemetryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ObservabilityAdmin");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ListResourceTelemetry";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }
            if (publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }
            if (publicRequest.IsSetResourceIdentifierPrefix())
            {
                context.Writer.WritePropertyName("ResourceIdentifierPrefix");
                context.Writer.WriteStringValue(publicRequest.ResourceIdentifierPrefix);
            }
            if (publicRequest.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("ResourceTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestResourceTagsKvp in publicRequest.ResourceTags)
                {
                    context.Writer.WritePropertyName(publicRequestResourceTagsKvp.Key);
                    var publicRequestResourceTagsValue = publicRequestResourceTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestResourceTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestResourceTypesListValue in publicRequest.ResourceTypes)
                {
                    context.Writer.WriteStringValue(publicRequestResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTelemetryConfigurationState())
            {
                context.Writer.WritePropertyName("TelemetryConfigurationState");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTelemetryConfigurationStateKvp in publicRequest.TelemetryConfigurationState)
                {
                    context.Writer.WritePropertyName(publicRequestTelemetryConfigurationStateKvp.Key);
                    var publicRequestTelemetryConfigurationStateValue = publicRequestTelemetryConfigurationStateKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTelemetryConfigurationStateValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ListResourceTelemetryRequestMarshaller _instance = new();

        internal static ListResourceTelemetryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListResourceTelemetryRequestMarshaller Instance => _instance;
    }
}
