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
    /// ForecastComputation Marshaller
    /// </summary>
    public class ForecastComputationMarshaller : IRequestMarshaller<ForecastComputation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ForecastComputation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputationId())
            {
                context.Writer.WritePropertyName("ComputationId");
                context.Writer.WriteStringValue(requestObject.ComputationId);
            }

            if(requestObject.IsSetCustomSeasonalityValue())
            {
                context.Writer.WritePropertyName("CustomSeasonalityValue");
                context.Writer.WriteNumberValue(requestObject.CustomSeasonalityValue.Value);
            }

            if(requestObject.IsSetLowerBoundary())
            {
                context.Writer.WritePropertyName("LowerBoundary");
                if(StringUtils.IsSpecialDoubleValue(requestObject.LowerBoundary.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LowerBoundary.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LowerBoundary.Value);
                }
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPeriodsBackward())
            {
                context.Writer.WritePropertyName("PeriodsBackward");
                context.Writer.WriteNumberValue(requestObject.PeriodsBackward.Value);
            }

            if(requestObject.IsSetPeriodsForward())
            {
                context.Writer.WritePropertyName("PeriodsForward");
                context.Writer.WriteNumberValue(requestObject.PeriodsForward.Value);
            }

            if(requestObject.IsSetPredictionInterval())
            {
                context.Writer.WritePropertyName("PredictionInterval");
                context.Writer.WriteNumberValue(requestObject.PredictionInterval.Value);
            }

            if(requestObject.IsSetSeasonality())
            {
                context.Writer.WritePropertyName("Seasonality");
                context.Writer.WriteStringValue(requestObject.Seasonality);
            }

            if(requestObject.IsSetTime())
            {
                context.Writer.WritePropertyName("Time");
                context.Writer.WriteStartObject();

                var marshaller = DimensionFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.Time, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpperBoundary())
            {
                context.Writer.WritePropertyName("UpperBoundary");
                if(StringUtils.IsSpecialDoubleValue(requestObject.UpperBoundary.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.UpperBoundary.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.UpperBoundary.Value);
                }
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteStartObject();

                var marshaller = MeasureFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ForecastComputationMarshaller Instance = new ForecastComputationMarshaller();

    }
}