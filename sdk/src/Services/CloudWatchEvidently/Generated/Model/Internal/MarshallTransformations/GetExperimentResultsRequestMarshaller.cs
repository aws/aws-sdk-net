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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvidently.Model;
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
namespace Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetExperimentResults Request Marshaller
    /// </summary>       
    public class GetExperimentResultsRequestMarshaller : IMarshaller<IRequest, GetExperimentResultsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetExperimentResultsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetExperimentResultsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvidently");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-02-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetExperiment())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Experiment set");
            request.AddPathResource("{experiment}", StringUtils.FromString(publicRequest.Experiment));
            if (!publicRequest.IsSetProject())
                throw new AmazonCloudWatchEvidentlyException("Request object does not have required field Project set");
            request.AddPathResource("{project}", StringUtils.FromString(publicRequest.Project));
            request.ResourcePath = "/projects/{project}/experiments/{experiment}/results";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBaseStat())
            {
                context.Writer.WritePropertyName("baseStat");
                context.Writer.WriteStringValue(publicRequest.BaseStat);
            }

            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("endTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetMetricNames())
            {
                context.Writer.WritePropertyName("metricNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricNamesListValue in publicRequest.MetricNames)
                {
                        context.Writer.WriteStringValue(publicRequestMetricNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPeriod())
            {
                context.Writer.WritePropertyName("period");
                context.Writer.WriteNumberValue(publicRequest.Period.Value);
            }

            if(publicRequest.IsSetReportNames())
            {
                context.Writer.WritePropertyName("reportNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestReportNamesListValue in publicRequest.ReportNames)
                {
                        context.Writer.WriteStringValue(publicRequestReportNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResultStats())
            {
                context.Writer.WritePropertyName("resultStats");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResultStatsListValue in publicRequest.ResultStats)
                {
                        context.Writer.WriteStringValue(publicRequestResultStatsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            if(publicRequest.IsSetTreatmentNames())
            {
                context.Writer.WritePropertyName("treatmentNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTreatmentNamesListValue in publicRequest.TreatmentNames)
                {
                        context.Writer.WriteStringValue(publicRequestTreatmentNamesListValue);
                }
                context.Writer.WriteEndArray();
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
        private static GetExperimentResultsRequestMarshaller _instance = new GetExperimentResultsRequestMarshaller();        

        internal static GetExperimentResultsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetExperimentResultsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}