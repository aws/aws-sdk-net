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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
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
namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMetricSet Request Marshaller
    /// </summary>       
    public class CreateMetricSetRequestMarshaller : IMarshaller<IRequest, CreateMetricSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMetricSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMetricSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutMetrics");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateMetricSet";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnomalyDetectorArn())
            {
                context.Writer.WritePropertyName("AnomalyDetectorArn");
                context.Writer.WriteStringValue(publicRequest.AnomalyDetectorArn);
            }

            if(publicRequest.IsSetDimensionFilterList())
            {
                context.Writer.WritePropertyName("DimensionFilterList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDimensionFilterListListValue in publicRequest.DimensionFilterList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricSetDimensionFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestDimensionFilterListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDimensionList())
            {
                context.Writer.WritePropertyName("DimensionList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDimensionListListValue in publicRequest.DimensionList)
                {
                        context.Writer.WriteStringValue(publicRequestDimensionListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMetricList())
            {
                context.Writer.WritePropertyName("MetricList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricListListValue in publicRequest.MetricList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricMarshaller.Instance;
                    marshaller.Marshall(publicRequestMetricListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMetricSetDescription())
            {
                context.Writer.WritePropertyName("MetricSetDescription");
                context.Writer.WriteStringValue(publicRequest.MetricSetDescription);
            }

            if(publicRequest.IsSetMetricSetFrequency())
            {
                context.Writer.WritePropertyName("MetricSetFrequency");
                context.Writer.WriteStringValue(publicRequest.MetricSetFrequency);
            }

            if(publicRequest.IsSetMetricSetName())
            {
                context.Writer.WritePropertyName("MetricSetName");
                context.Writer.WriteStringValue(publicRequest.MetricSetName);
            }

            if(publicRequest.IsSetMetricSource())
            {
                context.Writer.WritePropertyName("MetricSource");
                context.Writer.WriteStartObject();

                var marshaller = MetricSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.MetricSource, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOffset())
            {
                context.Writer.WritePropertyName("Offset");
                context.Writer.WriteNumberValue(publicRequest.Offset.Value);
            }

            if(publicRequest.IsSetTags())
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

            if(publicRequest.IsSetTimestampColumn())
            {
                context.Writer.WritePropertyName("TimestampColumn");
                context.Writer.WriteStartObject();

                var marshaller = TimestampColumnMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimestampColumn, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.WriteStringValue(publicRequest.Timezone);
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
        private static CreateMetricSetRequestMarshaller _instance = new CreateMetricSetRequestMarshaller();        

        internal static CreateMetricSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMetricSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}