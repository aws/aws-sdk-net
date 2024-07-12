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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAggMetricsListValue in requestObject.AggMetrics)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterAggMetricsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggMetricsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAggregation())
            {
                context.Writer.WritePropertyName("Aggregation");
                context.Writer.Write(requestObject.Aggregation);
            }

            if(requestObject.IsSetAggregationFunctionParameters())
            {
                context.Writer.WritePropertyName("AggregationFunctionParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAggregationFunctionParametersKvp in requestObject.AggregationFunctionParameters)
                {
                    context.Writer.WritePropertyName(requestObjectAggregationFunctionParametersKvp.Key);
                    var requestObjectAggregationFunctionParametersValue = requestObjectAggregationFunctionParametersKvp.Value;

                        context.Writer.Write(requestObjectAggregationFunctionParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAggregationPartitionBy())
            {
                context.Writer.WritePropertyName("AggregationPartitionBy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAggregationPartitionByListValue in requestObject.AggregationPartitionBy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AggregationPartitionByMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregationPartitionByListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAnchor())
            {
                context.Writer.WritePropertyName("Anchor");
                context.Writer.WriteObjectStart();

                var marshaller = AnchorMarshaller.Instance;
                marshaller.Marshall(requestObject.Anchor, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConstant())
            {
                context.Writer.WritePropertyName("Constant");
                context.Writer.WriteObjectStart();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Constant, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilterClass())
            {
                context.Writer.WritePropertyName("FilterClass");
                context.Writer.Write(requestObject.FilterClass);
            }

            if(requestObject.IsSetFilterType())
            {
                context.Writer.WritePropertyName("FilterType");
                context.Writer.Write(requestObject.FilterType);
            }

            if(requestObject.IsSetFunction())
            {
                context.Writer.WritePropertyName("Function");
                context.Writer.Write(requestObject.Function);
            }

            if(requestObject.IsSetInclusive())
            {
                context.Writer.WritePropertyName("Inclusive");
                context.Writer.Write(requestObject.Inclusive);
            }

            if(requestObject.IsSetInverse())
            {
                context.Writer.WritePropertyName("Inverse");
                context.Writer.Write(requestObject.Inverse);
            }

            if(requestObject.IsSetLastNextOffset())
            {
                context.Writer.WritePropertyName("LastNextOffset");
                context.Writer.WriteObjectStart();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.LastNextOffset, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNullFilter())
            {
                context.Writer.WritePropertyName("NullFilter");
                context.Writer.Write(requestObject.NullFilter);
            }

            if(requestObject.IsSetOperandField())
            {
                context.Writer.WritePropertyName("OperandField");
                context.Writer.WriteObjectStart();

                var marshaller = IdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.OperandField, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRange())
            {
                context.Writer.WritePropertyName("Range");
                context.Writer.WriteObjectStart();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Range, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSortDirection())
            {
                context.Writer.WritePropertyName("SortDirection");
                context.Writer.Write(requestObject.SortDirection);
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.Write(requestObject.TimeGranularity);
            }

            if(requestObject.IsSetTopBottomLimit())
            {
                context.Writer.WritePropertyName("TopBottomLimit");
                context.Writer.WriteObjectStart();

                var marshaller = TopicConstantValueMarshaller.Instance;
                marshaller.Marshall(requestObject.TopBottomLimit, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicIRFilterOptionMarshaller Instance = new TopicIRFilterOptionMarshaller();

    }
}