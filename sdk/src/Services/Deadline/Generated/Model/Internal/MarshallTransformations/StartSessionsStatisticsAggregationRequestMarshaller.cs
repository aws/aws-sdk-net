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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
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
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSessionsStatisticsAggregation Request Marshaller
    /// </summary>       
    public class StartSessionsStatisticsAggregationRequestMarshaller : IMarshaller<IRequest, StartSessionsStatisticsAggregationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSessionsStatisticsAggregationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSessionsStatisticsAggregationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/sessions-statistics-aggregation";
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
                context.Writer.WritePropertyName("endTime");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
            }

            if(publicRequest.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("groupBy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGroupByListValue in publicRequest.GroupBy)
                {
                        context.Writer.WriteStringValue(publicRequestGroupByListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPeriod())
            {
                context.Writer.WritePropertyName("period");
                context.Writer.WriteStringValue(publicRequest.Period);
            }

            if(publicRequest.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("resourceIds");
                context.Writer.WriteStartObject();

                var marshaller = SessionsStatisticsResourcesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResourceIds, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
            }

            if(publicRequest.IsSetStatistics())
            {
                context.Writer.WritePropertyName("statistics");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStatisticsListValue in publicRequest.Statistics)
                {
                        context.Writer.WriteStringValue(publicRequestStatisticsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimezone())
            {
                context.Writer.WritePropertyName("timezone");
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
            

            
            request.HostPrefix = $"management.";

            return request;
        }
        private static StartSessionsStatisticsAggregationRequestMarshaller _instance = new StartSessionsStatisticsAggregationRequestMarshaller();        

        internal static StartSessionsStatisticsAggregationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSessionsStatisticsAggregationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}