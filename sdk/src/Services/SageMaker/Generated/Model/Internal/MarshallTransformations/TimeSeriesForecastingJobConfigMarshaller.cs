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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCompletionCriteria())
            {
                context.Writer.WritePropertyName("CompletionCriteria");
                context.Writer.WriteObjectStart();

                var marshaller = AutoMLJobCompletionCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.CompletionCriteria, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFeatureSpecificationS3Uri())
            {
                context.Writer.WritePropertyName("FeatureSpecificationS3Uri");
                context.Writer.Write(requestObject.FeatureSpecificationS3Uri);
            }

            if(requestObject.IsSetForecastFrequency())
            {
                context.Writer.WritePropertyName("ForecastFrequency");
                context.Writer.Write(requestObject.ForecastFrequency);
            }

            if(requestObject.IsSetForecastHorizon())
            {
                context.Writer.WritePropertyName("ForecastHorizon");
                context.Writer.Write(requestObject.ForecastHorizon);
            }

            if(requestObject.IsSetForecastQuantiles())
            {
                context.Writer.WritePropertyName("ForecastQuantiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectForecastQuantilesListValue in requestObject.ForecastQuantiles)
                {
                        context.Writer.Write(requestObjectForecastQuantilesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTimeSeriesConfig())
            {
                context.Writer.WritePropertyName("TimeSeriesConfig");
                context.Writer.WriteObjectStart();

                var marshaller = TimeSeriesConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSeriesConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTransformations())
            {
                context.Writer.WritePropertyName("Transformations");
                context.Writer.WriteObjectStart();

                var marshaller = TimeSeriesTransformationsMarshaller.Instance;
                marshaller.Marshall(requestObject.Transformations, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TimeSeriesForecastingJobConfigMarshaller Instance = new TimeSeriesForecastingJobConfigMarshaller();

    }
}