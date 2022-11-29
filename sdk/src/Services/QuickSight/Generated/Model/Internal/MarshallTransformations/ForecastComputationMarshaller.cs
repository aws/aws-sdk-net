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
            if(requestObject.IsSetComputationId())
            {
                context.Writer.WritePropertyName("ComputationId");
                context.Writer.Write(requestObject.ComputationId);
            }

            if(requestObject.IsSetCustomSeasonalityValue())
            {
                context.Writer.WritePropertyName("CustomSeasonalityValue");
                context.Writer.Write(requestObject.CustomSeasonalityValue);
            }

            if(requestObject.IsSetLowerBoundary())
            {
                context.Writer.WritePropertyName("LowerBoundary");
                context.Writer.Write(requestObject.LowerBoundary);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPeriodsBackward())
            {
                context.Writer.WritePropertyName("PeriodsBackward");
                context.Writer.Write(requestObject.PeriodsBackward);
            }

            if(requestObject.IsSetPeriodsForward())
            {
                context.Writer.WritePropertyName("PeriodsForward");
                context.Writer.Write(requestObject.PeriodsForward);
            }

            if(requestObject.IsSetPredictionInterval())
            {
                context.Writer.WritePropertyName("PredictionInterval");
                context.Writer.Write(requestObject.PredictionInterval);
            }

            if(requestObject.IsSetSeasonality())
            {
                context.Writer.WritePropertyName("Seasonality");
                context.Writer.Write(requestObject.Seasonality);
            }

            if(requestObject.IsSetTime())
            {
                context.Writer.WritePropertyName("Time");
                context.Writer.WriteObjectStart();

                var marshaller = DimensionFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.Time, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUpperBoundary())
            {
                context.Writer.WritePropertyName("UpperBoundary");
                context.Writer.Write(requestObject.UpperBoundary);
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteObjectStart();

                var marshaller = MeasureFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.Value, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ForecastComputationMarshaller Instance = new ForecastComputationMarshaller();

    }
}