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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMetricDataV2 Request Marshaller
    /// </summary>       
    public class GetMetricDataV2RequestMarshaller : IMarshaller<IRequest, GetMetricDataV2Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMetricDataV2Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMetricDataV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/metrics/data";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterV2Marshaller.Instance;
                    marshaller.Marshall(publicRequestFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGroupings())
            {
                context.Writer.WritePropertyName("Groupings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGroupingsListValue in publicRequest.Groupings)
                {
                        context.Writer.WriteStringValue(publicRequestGroupingsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.WriteStartObject();

                var marshaller = IntervalDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Interval, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricsListValue in publicRequest.Metrics)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricV2Marshaller.Instance;
                    marshaller.Marshall(publicRequestMetricsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("ResourceArn");
                context.Writer.WriteStringValue(publicRequest.ResourceArn);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static GetMetricDataV2RequestMarshaller _instance = new GetMetricDataV2RequestMarshaller();        

        internal static GetMetricDataV2RequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricDataV2RequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}