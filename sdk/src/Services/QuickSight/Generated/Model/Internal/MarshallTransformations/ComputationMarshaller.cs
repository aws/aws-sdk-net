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
    /// Computation Marshaller
    /// </summary>
    public class ComputationMarshaller : IRequestMarshaller<Computation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Computation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetForecast())
            {
                context.Writer.WritePropertyName("Forecast");
                context.Writer.WriteStartObject();

                var marshaller = ForecastComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.Forecast, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGrowthRate())
            {
                context.Writer.WritePropertyName("GrowthRate");
                context.Writer.WriteStartObject();

                var marshaller = GrowthRateComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.GrowthRate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaximumMinimum())
            {
                context.Writer.WritePropertyName("MaximumMinimum");
                context.Writer.WriteStartObject();

                var marshaller = MaximumMinimumComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.MaximumMinimum, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetricComparison())
            {
                context.Writer.WritePropertyName("MetricComparison");
                context.Writer.WriteStartObject();

                var marshaller = MetricComparisonComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricComparison, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPeriodOverPeriod())
            {
                context.Writer.WritePropertyName("PeriodOverPeriod");
                context.Writer.WriteStartObject();

                var marshaller = PeriodOverPeriodComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.PeriodOverPeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPeriodToDate())
            {
                context.Writer.WritePropertyName("PeriodToDate");
                context.Writer.WriteStartObject();

                var marshaller = PeriodToDateComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.PeriodToDate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTopBottomMovers())
            {
                context.Writer.WritePropertyName("TopBottomMovers");
                context.Writer.WriteStartObject();

                var marshaller = TopBottomMoversComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.TopBottomMovers, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTopBottomRanked())
            {
                context.Writer.WritePropertyName("TopBottomRanked");
                context.Writer.WriteStartObject();

                var marshaller = TopBottomRankedComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.TopBottomRanked, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTotalAggregation())
            {
                context.Writer.WritePropertyName("TotalAggregation");
                context.Writer.WriteStartObject();

                var marshaller = TotalAggregationComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalAggregation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUniqueValues())
            {
                context.Writer.WritePropertyName("UniqueValues");
                context.Writer.WriteStartObject();

                var marshaller = UniqueValuesComputationMarshaller.Instance;
                marshaller.Marshall(requestObject.UniqueValues, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComputationMarshaller Instance = new ComputationMarshaller();

    }
}