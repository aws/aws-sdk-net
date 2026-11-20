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

using Amazon.WAFV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListEventsByWebACL Request Marshaller
    /// </summary>
    public partial class ListEventsByWebACLRequestMarshaller : IMarshaller<IRequest, ListEventsByWebACLRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListEventsByWebACLRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListEventsByWebACLRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WAFV2");
            string target = "AWSWAF_20190729.ListEventsByWebACL";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetApiPatternFilters())
            {
                context.Writer.WritePropertyName("ApiPatternFilters");
                context.Writer.WriteStartArray();
                foreach (var publicRequestApiPatternFiltersListValue in publicRequest.ApiPatternFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ApiPatternFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestApiPatternFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartArray();
                foreach (var publicRequestFiltersListValue in publicRequest.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EventFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetInclude())
            {
                context.Writer.WritePropertyName("Include");
                context.Writer.WriteStartArray();
                foreach (var publicRequestIncludeListValue in publicRequest.Include)
                {
                    context.Writer.WriteStringValue(publicRequestIncludeListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLimit())
            {
                context.Writer.WritePropertyName("Limit");
                context.Writer.WriteNumberValue(publicRequest.Limit.Value);
            }
            if (publicRequest.IsSetNextMarker())
            {
                context.Writer.WritePropertyName("NextMarker");
                context.Writer.WriteStringValue(publicRequest.NextMarker);
            }
            if (publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStringValue(publicRequest.Scope);
            }
            if (publicRequest.IsSetSortBy())
            {
                context.Writer.WritePropertyName("SortBy");
                context.Writer.WriteStringValue(publicRequest.SortBy);
            }
            if (publicRequest.IsSetSortOrder())
            {
                context.Writer.WritePropertyName("SortOrder");
                context.Writer.WriteStringValue(publicRequest.SortOrder);
            }
            if (publicRequest.IsSetTimeWindow())
            {
                context.Writer.WritePropertyName("TimeWindow");
                context.Writer.WriteStartObject();

                var marshaller = TimeWindowMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeWindow, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetWebAclArn())
            {
                context.Writer.WritePropertyName("WebAclArn");
                context.Writer.WriteStringValue(publicRequest.WebAclArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ListEventsByWebACLRequestMarshaller _instance = new();

        internal static ListEventsByWebACLRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListEventsByWebACLRequestMarshaller Instance => _instance;
    }
}
