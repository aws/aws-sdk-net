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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimeSeriesForecastingJobConfig Marshaller
    /// </summary>
    public class TimeSeriesForecastingJobConfigMarshaller : IRequestMarshaller<TimeSeriesForecastingJobConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TimeSeriesForecastingJobConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCandidateGenerationConfig())
            {
                context.Writer.WritePropertyName("CandidateGenerationConfig");
                context.Writer.WriteStartObject();

                var marshaller = CandidateGenerationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CandidateGenerationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompletionCriteria())
            {
                context.Writer.WritePropertyName("CompletionCriteria");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLJobCompletionCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.CompletionCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFeatureSpecificationS3Uri())
            {
                context.Writer.WritePropertyName("FeatureSpecificationS3Uri");
                context.Writer.WriteStringValue(requestObject.FeatureSpecificationS3Uri);
            }

            if(requestObject.IsSetForecastFrequency())
            {
                context.Writer.WritePropertyName("ForecastFrequency");
                context.Writer.WriteStringValue(requestObject.ForecastFrequency);
            }

            if(requestObject.IsSetForecastHorizon())
            {
                context.Writer.WritePropertyName("ForecastHorizon");
                context.Writer.WriteNumberValue(requestObject.ForecastHorizon.Value);
            }

            if(requestObject.IsSetForecastQuantiles())
            {
                context.Writer.WritePropertyName("ForecastQuantiles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectForecastQuantilesListValue in requestObject.ForecastQuantiles)
                {
                        context.Writer.WriteStringValue(requestObjectForecastQuantilesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHolidayConfig())
            {
                context.Writer.WritePropertyName("HolidayConfig");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHolidayConfigListValue in requestObject.HolidayConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HolidayConfigAttributesMarshaller.Instance;
                    marshaller.Marshall(requestObjectHolidayConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimeSeriesConfig())
            {
                context.Writer.WritePropertyName("TimeSeriesConfig");
                context.Writer.WriteStartObject();

                var marshaller = TimeSeriesConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSeriesConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTransformations())
            {
                context.Writer.WritePropertyName("Transformations");
                context.Writer.WriteStartObject();

                var marshaller = TimeSeriesTransformationsMarshaller.Instance;
                marshaller.Marshall(requestObject.Transformations, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TimeSeriesForecastingJobConfigMarshaller Instance = new TimeSeriesForecastingJobConfigMarshaller();

    }
}