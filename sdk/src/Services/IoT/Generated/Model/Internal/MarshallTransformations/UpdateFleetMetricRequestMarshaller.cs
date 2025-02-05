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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
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
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFleetMetric Request Marshaller
    /// </summary>       
    public class UpdateFleetMetricRequestMarshaller : IMarshaller<IRequest, UpdateFleetMetricRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFleetMetricRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFleetMetricRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetMetricName())
                throw new AmazonIoTException("Request object does not have required field MetricName set");
            request.AddPathResource("{metricName}", StringUtils.FromString(publicRequest.MetricName));
            request.ResourcePath = "/fleet-metric/{metricName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAggregationField())
            {
                context.Writer.WritePropertyName("aggregationField");
                context.Writer.WriteStringValue(publicRequest.AggregationField);
            }

            if(publicRequest.IsSetAggregationType())
            {
                context.Writer.WritePropertyName("aggregationType");
                context.Writer.WriteStartObject();

                var marshaller = AggregationTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.AggregationType, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetExpectedVersion())
            {
                context.Writer.WritePropertyName("expectedVersion");
                context.Writer.WriteNumberValue(publicRequest.ExpectedVersion.Value);
            }

            if(publicRequest.IsSetIndexName())
            {
                context.Writer.WritePropertyName("indexName");
                context.Writer.WriteStringValue(publicRequest.IndexName);
            }

            if(publicRequest.IsSetPeriod())
            {
                context.Writer.WritePropertyName("period");
                context.Writer.WriteNumberValue(publicRequest.Period.Value);
            }

            if(publicRequest.IsSetQueryString())
            {
                context.Writer.WritePropertyName("queryString");
                context.Writer.WriteStringValue(publicRequest.QueryString);
            }

            if(publicRequest.IsSetQueryVersion())
            {
                context.Writer.WritePropertyName("queryVersion");
                context.Writer.WriteStringValue(publicRequest.QueryVersion);
            }

            if(publicRequest.IsSetUnit())
            {
                context.Writer.WritePropertyName("unit");
                context.Writer.WriteStringValue(publicRequest.Unit);
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
        private static UpdateFleetMetricRequestMarshaller _instance = new UpdateFleetMetricRequestMarshaller();        

        internal static UpdateFleetMetricRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFleetMetricRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}