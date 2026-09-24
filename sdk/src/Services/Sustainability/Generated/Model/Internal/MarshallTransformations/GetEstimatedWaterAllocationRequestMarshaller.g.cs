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

using Amazon.Sustainability.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Sustainability.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEstimatedWaterAllocation Request Marshaller
    /// </summary>
    public partial class GetEstimatedWaterAllocationRequestMarshaller : IMarshaller<IRequest, GetEstimatedWaterAllocationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEstimatedWaterAllocationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEstimatedWaterAllocationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Sustainability");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/estimated-water-allocation";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAllocationTypes())
            {
                context.Writer.WritePropertyName("AllocationTypes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAllocationTypesListValue in publicRequest.AllocationTypes)
                {
                    context.Writer.WriteStringValue(publicRequestAllocationTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetFilterBy())
            {
                context.Writer.WritePropertyName("FilterBy");
                context.Writer.WriteStartObject();

                var marshaller = FilterExpressionMarshaller.Instance;
                marshaller.Marshall(publicRequest.FilterBy, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetGranularity())
            {
                context.Writer.WritePropertyName("Granularity");
                context.Writer.WriteStringValue(publicRequest.Granularity);
            }
            if (publicRequest.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("GroupBy");
                context.Writer.WriteStartArray();
                foreach (var publicRequestGroupByListValue in publicRequest.GroupBy)
                {
                    context.Writer.WriteStringValue(publicRequestGroupByListValue);
                }
                context.Writer.WriteEndArray();
            }
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
            if (publicRequest.IsSetTimePeriod())
            {
                context.Writer.WritePropertyName("TimePeriod");
                context.Writer.WriteStartObject();

                var marshaller = TimePeriodMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimePeriod, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetEstimatedWaterAllocationRequestMarshaller _instance = new();

        internal static GetEstimatedWaterAllocationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEstimatedWaterAllocationRequestMarshaller Instance => _instance;
    }
}
