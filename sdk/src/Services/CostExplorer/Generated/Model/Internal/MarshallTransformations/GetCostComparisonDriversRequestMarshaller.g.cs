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

using Amazon.CostExplorer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCostComparisonDrivers Request Marshaller
    /// </summary>
    public partial class GetCostComparisonDriversRequestMarshaller : IMarshaller<IRequest, GetCostComparisonDriversRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCostComparisonDriversRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetCostComparisonDriversRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.GetCostComparisonDrivers";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";
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
            if (publicRequest.IsSetBaselineTimePeriod())
            {
                context.Writer.WritePropertyName("BaselineTimePeriod");
                context.Writer.WriteStartObject();

                var marshaller = DateIntervalMarshaller.Instance;
                marshaller.Marshall(publicRequest.BaselineTimePeriod, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetBillingViewArn())
            {
                context.Writer.WritePropertyName("BillingViewArn");
                context.Writer.WriteStringValue(publicRequest.BillingViewArn);
            }
            if (publicRequest.IsSetComparisonTimePeriod())
            {
                context.Writer.WritePropertyName("ComparisonTimePeriod");
                context.Writer.WriteStartObject();

                var marshaller = DateIntervalMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComparisonTimePeriod, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteStartObject();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filter, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("GroupBy");
                context.Writer.WriteStartArray();
                foreach (var publicRequestGroupByListValue in publicRequest.GroupBy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GroupDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestGroupByListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }
            if (publicRequest.IsSetMetricForComparison())
            {
                context.Writer.WritePropertyName("MetricForComparison");
                context.Writer.WriteStringValue(publicRequest.MetricForComparison);
            }
            if (publicRequest.IsSetNextPageToken())
            {
                context.Writer.WritePropertyName("NextPageToken");
                context.Writer.WriteStringValue(publicRequest.NextPageToken);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GetCostComparisonDriversRequestMarshaller _instance = new();

        internal static GetCostComparisonDriversRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetCostComparisonDriversRequestMarshaller Instance => _instance;
    }
}
