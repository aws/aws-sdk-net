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

using Amazon.Glue.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PublishDataQualityResultV2 Request Marshaller
    /// </summary>
    public partial class PublishDataQualityResultV2RequestMarshaller : IMarshaller<IRequest, PublishDataQualityResultV2Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishDataQualityResultV2Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PublishDataQualityResultV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.PublishDataQualityResultV2";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if (publicRequest.IsSetAggregatedMetrics())
            {
                context.Writer.WritePropertyName("AggregatedMetrics");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityAggregatedMetricsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AggregatedMetrics, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetAnalyzerResults())
            {
                context.Writer.WritePropertyName("AnalyzerResults");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAnalyzerResultsListValue in publicRequest.AnalyzerResults)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataQualityAnalyzerResultMarshaller.Instance;
                    marshaller.Marshall(publicRequestAnalyzerResultsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
            if (publicRequest.IsSetDataQualitySecurityConfiguration())
            {
                context.Writer.WritePropertyName("DataQualitySecurityConfiguration");
                context.Writer.WriteStringValue(publicRequest.DataQualitySecurityConfiguration);
            }
            if (publicRequest.IsSetDescriptors())
            {
                context.Writer.WritePropertyName("Descriptors");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDescriptorsKvp in publicRequest.Descriptors)
                {
                    context.Writer.WritePropertyName(publicRequestDescriptorsKvp.Key);
                    var publicRequestDescriptorsValue = publicRequestDescriptorsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestDescriptorsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDimensionsKvp in publicRequest.Dimensions)
                {
                    context.Writer.WritePropertyName(publicRequestDimensionsKvp.Key);
                    var publicRequestDimensionsValue = publicRequestDimensionsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestDimensionsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetEvaluationContext())
            {
                context.Writer.WritePropertyName("EvaluationContext");
                context.Writer.WriteStringValue(publicRequest.EvaluationContext);
            }
            if (publicRequest.IsSetExecutionCompletedOn())
            {
                context.Writer.WritePropertyName("ExecutionCompletedOn");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.ExecutionCompletedOn.Value));
            }
            if (publicRequest.IsSetExecutionStartedOn())
            {
                context.Writer.WritePropertyName("ExecutionStartedOn");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.ExecutionStartedOn.Value));
            }
            if (publicRequest.IsSetObservations())
            {
                context.Writer.WritePropertyName("Observations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestObservationsListValue in publicRequest.Observations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataQualityObservationMarshaller.Instance;
                    marshaller.Marshall(publicRequestObservationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRuleResults())
            {
                context.Writer.WritePropertyName("RuleResults");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRuleResultsListValue in publicRequest.RuleResults)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataQualityRuleResultMarshaller.Instance;
                    marshaller.Marshall(publicRequestRuleResultsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRulesetName())
            {
                context.Writer.WritePropertyName("RulesetName");
                context.Writer.WriteStringValue(publicRequest.RulesetName);
            }
            if (publicRequest.IsSetRunConfiguration())
            {
                context.Writer.WritePropertyName("RunConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityConfigurationV2Marshaller.Instance;
                marshaller.Marshall(publicRequest.RunConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetScore())
            {
                context.Writer.WritePropertyName("Score");
                if (StringUtils.IsSpecialDoubleValue(publicRequest.Score.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.Score.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.Score.Value);
                }
            }
            if (publicRequest.IsSetStatistics())
            {
                context.Writer.WritePropertyName("Statistics");
                context.Writer.WriteStartArray();
                foreach (var publicRequestStatisticsListValue in publicRequest.Statistics)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StatisticSummaryMarshaller.Instance;
                    marshaller.Marshall(publicRequestStatisticsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTelemetry())
            {
                context.Writer.WritePropertyName("Telemetry");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityTelemetryMarshaller.Instance;
                marshaller.Marshall(publicRequest.Telemetry, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PublishDataQualityResultV2RequestMarshaller _instance = new();

        internal static PublishDataQualityResultV2RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PublishDataQualityResultV2RequestMarshaller Instance => _instance;
    }
}
