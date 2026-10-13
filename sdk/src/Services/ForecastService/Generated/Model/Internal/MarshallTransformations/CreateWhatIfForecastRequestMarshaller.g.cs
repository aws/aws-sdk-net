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
    /// CreateWhatIfForecast Request Marshaller
    /// </summary>
    public partial class CreateWhatIfForecastRequestMarshaller : IMarshaller<IRequest, CreateWhatIfForecastRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWhatIfForecastRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateWhatIfForecastRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateWhatIfForecast";
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
            if (publicRequest.IsSetTimeSeriesReplacementsDataSource())
            {
                context.Writer.WritePropertyName("TimeSeriesReplacementsDataSource");
                context.Writer.WriteStartObject();

                var marshaller = TimeSeriesReplacementsDataSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeSeriesReplacementsDataSource, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTimeSeriesTransformations())
            {
                context.Writer.WritePropertyName("TimeSeriesTransformations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTimeSeriesTransformationsListValue in publicRequest.TimeSeriesTransformations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TimeSeriesTransformationMarshaller.Instance;
                    marshaller.Marshall(publicRequestTimeSeriesTransformationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetWhatIfAnalysisArn())
            {
                context.Writer.WritePropertyName("WhatIfAnalysisArn");
                context.Writer.WriteStringValue(publicRequest.WhatIfAnalysisArn);
            }
            if (publicRequest.IsSetWhatIfForecastName())
            {
                context.Writer.WritePropertyName("WhatIfForecastName");
                context.Writer.WriteStringValue(publicRequest.WhatIfForecastName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateWhatIfForecastRequestMarshaller _instance = new();

        internal static CreateWhatIfForecastRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateWhatIfForecastRequestMarshaller Instance => _instance;
    }
}
