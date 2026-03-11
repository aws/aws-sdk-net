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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricAlarm Request Marshaller
    /// </summary>       
    public class PutMetricAlarmRequestMarshaller : IMarshaller<IRequest, PutMetricAlarmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricAlarmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricAlarmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/PutMetricAlarm";
            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetActionsEnabled())
                {
                    context.Writer.WriteTextString("ActionsEnabled");
                    context.Writer.WriteBoolean(publicRequest.ActionsEnabled.Value);
                }
                if (publicRequest.IsSetAlarmActions())
                {
                    context.Writer.WriteTextString("AlarmActions");
                    context.Writer.WriteStartArray(publicRequest.AlarmActions.Count);
                    foreach(var publicRequestAlarmActionsListValue in publicRequest.AlarmActions)
                    {
                            context.Writer.WriteTextString(publicRequestAlarmActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetAlarmDescription())
                {
                    context.Writer.WriteTextString("AlarmDescription");
                    context.Writer.WriteTextString(publicRequest.AlarmDescription);
                }
                if (publicRequest.IsSetAlarmName())
                {
                    context.Writer.WriteTextString("AlarmName");
                    context.Writer.WriteTextString(publicRequest.AlarmName);
                }
                if (publicRequest.IsSetComparisonOperator())
                {
                    context.Writer.WriteTextString("ComparisonOperator");
                    context.Writer.WriteTextString(publicRequest.ComparisonOperator);
                }
                if (publicRequest.IsSetDatapointsToAlarm())
                {
                    context.Writer.WriteTextString("DatapointsToAlarm");
                    context.Writer.WriteInt32(publicRequest.DatapointsToAlarm.Value);
                }
                if (publicRequest.IsSetDimensions())
                {
                    context.Writer.WriteTextString("Dimensions");
                    context.Writer.WriteStartArray(publicRequest.Dimensions.Count);
                    foreach(var publicRequestDimensionsListValue in publicRequest.Dimensions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = DimensionMarshaller.Instance;
                        marshaller.Marshall(publicRequestDimensionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEvaluateLowSampleCountPercentile())
                {
                    context.Writer.WriteTextString("EvaluateLowSampleCountPercentile");
                    context.Writer.WriteTextString(publicRequest.EvaluateLowSampleCountPercentile);
                }
                if (publicRequest.IsSetEvaluationPeriods())
                {
                    context.Writer.WriteTextString("EvaluationPeriods");
                    context.Writer.WriteInt32(publicRequest.EvaluationPeriods.Value);
                }
                if (publicRequest.IsSetExtendedStatistic())
                {
                    context.Writer.WriteTextString("ExtendedStatistic");
                    context.Writer.WriteTextString(publicRequest.ExtendedStatistic);
                }
                if (publicRequest.IsSetInsufficientDataActions())
                {
                    context.Writer.WriteTextString("InsufficientDataActions");
                    context.Writer.WriteStartArray(publicRequest.InsufficientDataActions.Count);
                    foreach(var publicRequestInsufficientDataActionsListValue in publicRequest.InsufficientDataActions)
                    {
                            context.Writer.WriteTextString(publicRequestInsufficientDataActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetMetricName())
                {
                    context.Writer.WriteTextString("MetricName");
                    context.Writer.WriteTextString(publicRequest.MetricName);
                }
                if (publicRequest.IsSetMetrics())
                {
                    context.Writer.WriteTextString("Metrics");
                    context.Writer.WriteStartArray(publicRequest.Metrics.Count);
                    foreach(var publicRequestMetricsListValue in publicRequest.Metrics)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = MetricDataQueryMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetNamespace())
                {
                    context.Writer.WriteTextString("Namespace");
                    context.Writer.WriteTextString(publicRequest.Namespace);
                }
                if (publicRequest.IsSetOKActions())
                {
                    context.Writer.WriteTextString("OKActions");
                    context.Writer.WriteStartArray(publicRequest.OKActions.Count);
                    foreach(var publicRequestOKActionsListValue in publicRequest.OKActions)
                    {
                            context.Writer.WriteTextString(publicRequestOKActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetPeriod())
                {
                    context.Writer.WriteTextString("Period");
                    context.Writer.WriteInt32(publicRequest.Period.Value);
                }
                if (publicRequest.IsSetStatistic())
                {
                    context.Writer.WriteTextString("Statistic");
                    context.Writer.WriteTextString(publicRequest.Statistic);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetThreshold())
                {
                    context.Writer.WriteTextString("Threshold");
                    context.Writer.WriteOptimizedNumber(publicRequest.Threshold.Value);
                }
                if (publicRequest.IsSetThresholdMetricId())
                {
                    context.Writer.WriteTextString("ThresholdMetricId");
                    context.Writer.WriteTextString(publicRequest.ThresholdMetricId);
                }
                if (publicRequest.IsSetTreatMissingData())
                {
                    context.Writer.WriteTextString("TreatMissingData");
                    context.Writer.WriteTextString(publicRequest.TreatMissingData);
                }
                if (publicRequest.IsSetUnit())
                {
                    context.Writer.WriteTextString("Unit");
                    context.Writer.WriteTextString(publicRequest.Unit);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static PutMetricAlarmRequestMarshaller _instance = new PutMetricAlarmRequestMarshaller();        

        internal static PutMetricAlarmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricAlarmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}