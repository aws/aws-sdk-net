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

using Amazon.ForecastService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAutoPredictor Request Marshaller
    /// </summary>
    public partial class CreateAutoPredictorRequestMarshaller : IMarshaller<IRequest, CreateAutoPredictorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutoPredictorRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateAutoPredictorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateAutoPredictor";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
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
            if (publicRequest.IsSetDataConfig())
            {
                context.Writer.WritePropertyName("DataConfig");
                context.Writer.WriteStartObject();

                var marshaller = DataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetEncryptionConfig())
            {
                context.Writer.WritePropertyName("EncryptionConfig");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetExplainPredictor())
            {
                context.Writer.WritePropertyName("ExplainPredictor");
                context.Writer.WriteBooleanValue(publicRequest.ExplainPredictor.Value);
            }
            if (publicRequest.IsSetForecastDimensions())
            {
                context.Writer.WritePropertyName("ForecastDimensions");
                context.Writer.WriteStartArray();
                foreach (var publicRequestForecastDimensionsListValue in publicRequest.ForecastDimensions)
                {
                    context.Writer.WriteStringValue(publicRequestForecastDimensionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetForecastFrequency())
            {
                context.Writer.WritePropertyName("ForecastFrequency");
                context.Writer.WriteStringValue(publicRequest.ForecastFrequency);
            }
            if (publicRequest.IsSetForecastHorizon())
            {
                context.Writer.WritePropertyName("ForecastHorizon");
                context.Writer.WriteNumberValue(publicRequest.ForecastHorizon.Value);
            }
            if (publicRequest.IsSetForecastTypes())
            {
                context.Writer.WritePropertyName("ForecastTypes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestForecastTypesListValue in publicRequest.ForecastTypes)
                {
                    context.Writer.WriteStringValue(publicRequestForecastTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetMonitorConfig())
            {
                context.Writer.WritePropertyName("MonitorConfig");
                context.Writer.WriteStartObject();

                var marshaller = MonitorConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.MonitorConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetOptimizationMetric())
            {
                context.Writer.WritePropertyName("OptimizationMetric");
                context.Writer.WriteStringValue(publicRequest.OptimizationMetric);
            }
            if (publicRequest.IsSetPredictorName())
            {
                context.Writer.WritePropertyName("PredictorName");
                context.Writer.WriteStringValue(publicRequest.PredictorName);
            }
            if (publicRequest.IsSetReferencePredictorArn())
            {
                context.Writer.WritePropertyName("ReferencePredictorArn");
                context.Writer.WriteStringValue(publicRequest.ReferencePredictorArn);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTimeAlignmentBoundary())
            {
                context.Writer.WritePropertyName("TimeAlignmentBoundary");
                context.Writer.WriteStartObject();

                var marshaller = TimeAlignmentBoundaryMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeAlignmentBoundary, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateAutoPredictorRequestMarshaller _instance = new();

        internal static CreateAutoPredictorRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateAutoPredictorRequestMarshaller Instance => _instance;
    }
}
