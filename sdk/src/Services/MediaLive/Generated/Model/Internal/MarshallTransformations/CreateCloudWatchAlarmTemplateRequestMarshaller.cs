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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
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
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCloudWatchAlarmTemplate Request Marshaller
    /// </summary>       
    public class CreateCloudWatchAlarmTemplateRequestMarshaller : IMarshaller<IRequest, CreateCloudWatchAlarmTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCloudWatchAlarmTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCloudWatchAlarmTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/prod/cloudwatch-alarm-templates";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("comparisonOperator");
                context.Writer.WriteStringValue(publicRequest.ComparisonOperator);
            }

            if(publicRequest.IsSetDatapointsToAlarm())
            {
                context.Writer.WritePropertyName("datapointsToAlarm");
                context.Writer.WriteNumberValue(publicRequest.DatapointsToAlarm.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEvaluationPeriods())
            {
                context.Writer.WritePropertyName("evaluationPeriods");
                context.Writer.WriteNumberValue(publicRequest.EvaluationPeriods.Value);
            }

            if(publicRequest.IsSetGroupIdentifier())
            {
                context.Writer.WritePropertyName("groupIdentifier");
                context.Writer.WriteStringValue(publicRequest.GroupIdentifier);
            }

            if(publicRequest.IsSetMetricName())
            {
                context.Writer.WritePropertyName("metricName");
                context.Writer.WriteStringValue(publicRequest.MetricName);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPeriod())
            {
                context.Writer.WritePropertyName("period");
                context.Writer.WriteNumberValue(publicRequest.Period.Value);
            }

            if(publicRequest.IsSetRequestId())
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(publicRequest.RequestId);
            }

            else if(!(publicRequest.IsSetRequestId()))
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetStatistic())
            {
                context.Writer.WritePropertyName("statistic");
                context.Writer.WriteStringValue(publicRequest.Statistic);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTargetResourceType())
            {
                context.Writer.WritePropertyName("targetResourceType");
                context.Writer.WriteStringValue(publicRequest.TargetResourceType);
            }

            if(publicRequest.IsSetThreshold())
            {
                context.Writer.WritePropertyName("threshold");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.Threshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.Threshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.Threshold.Value);
                }
            }

            if(publicRequest.IsSetTreatMissingData())
            {
                context.Writer.WritePropertyName("treatMissingData");
                context.Writer.WriteStringValue(publicRequest.TreatMissingData);
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
        private static CreateCloudWatchAlarmTemplateRequestMarshaller _instance = new CreateCloudWatchAlarmTemplateRequestMarshaller();        

        internal static CreateCloudWatchAlarmTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCloudWatchAlarmTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}