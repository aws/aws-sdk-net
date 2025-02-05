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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicIRFilterOption Marshaller
    /// </summary>
    public class TopicIRFilterOptionMarshaller : IRequestMarshaller<TopicIRFilterOption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicIRFilterOption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggMetrics())
            {
                context.Writer.WritePropertyName("AggMetrics");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAggMetricsListValue in requestObject.AggMetrics)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterAggMetricsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggMetricsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAggregation())
            {
                context.Writer.WritePropertyName("Aggregation");
                context.Writer.WriteStringValue(requestObject.Aggregation);
            }

            if(requestObject.IsSetAggregationFunctionParameters())
            {
                context.Writer.WritePropertyName("AggregationFunctionParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAggregationFunctionParametersKvp in requestObject.AggregationFunctionParameters)
                {
                    context.Writer.WritePropertyName(requestObjectAggregationFunctionParametersKvp.Key);
                    var requestObjectAggregationFunctionParametersValue = requestObjectAggregationFunctionParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAggregationFunctionParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAggregationPartitionBy())
            {
                context.Writer.WritePropertyName("AggregationPartitionBy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAggregationPartitionByListValue in requestObject.AggregationPartitionBy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AggregationPartitionByMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregationPartitionByListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAnchor())
            {
                context.Writer.WritePropertyName("Anchor");
                context.Writer.WriteStartObject();

                var marshaller = AnchorMarshaller.Instance;
                marshaller.Marshall(requestObject.Anchor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConstant())
            {
                context.Writer.WritePropertyName("Constant");
                context.Writer.WriteStartObject();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Constant, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterClass())
            {
                context.Writer.WritePropertyName("FilterClass");
                context.Writer.WriteStringValue(requestObject.FilterClass);
            }

            if(requestObject.IsSetFilterType())
            {
                context.Writer.WritePropertyName("FilterType");
                context.Writer.WriteStringValue(requestObject.FilterType);
            }

            if(requestObject.IsSetFunction())
            {
                context.Writer.WritePropertyName("Function");
                context.Writer.WriteStringValue(requestObject.Function);
            }

            if(requestObject.IsSetInclusive())
            {
                context.Writer.WritePropertyName("Inclusive");
                context.Writer.WriteBooleanValue(requestObject.Inclusive.Value);
            }

            if(requestObject.IsSetInverse())
            {
                context.Writer.WritePropertyName("Inverse");
                context.Writer.WriteBooleanValue(requestObject.Inverse.Value);
            }

            if(requestObject.IsSetLastNextOffset())
            {
                context.Writer.WritePropertyName("LastNextOffset");
                context.Writer.WriteStartObject();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.LastNextOffset, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNullFilter())
            {
                context.Writer.WritePropertyName("NullFilter");
                context.Writer.WriteStringValue(requestObject.NullFilter);
            }

            if(requestObject.IsSetOperandField())
            {
                context.Writer.WritePropertyName("OperandField");
                context.Writer.WriteStartObject();

                var marshaller = IdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.OperandField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRange())
            {
                context.Writer.WritePropertyName("Range");
                context.Writer.WriteStartObject();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Range, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSortDirection())
            {
                context.Writer.WritePropertyName("SortDirection");
                context.Writer.WriteStringValue(requestObject.SortDirection);
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.WriteStringValue(requestObject.TimeGranularity);
            }

            if(requestObject.IsSetTopBottomLimit())
            {
                context.Writer.WritePropertyName("TopBottomLimit");
                context.Writer.WriteStartObject();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.TopBottomLimit, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicIRFilterOptionMarshaller Instance = new TopicIRFilterOptionMarshaller();

    }
}