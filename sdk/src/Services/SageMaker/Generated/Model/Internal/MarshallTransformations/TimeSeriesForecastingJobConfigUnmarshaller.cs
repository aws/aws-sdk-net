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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TimeSeriesForecastingJobConfig Object
    /// </summary>  
    public class TimeSeriesForecastingJobConfigUnmarshaller : IJsonUnmarshaller<TimeSeriesForecastingJobConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TimeSeriesForecastingJobConfig Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TimeSeriesForecastingJobConfig unmarshalledObject = new TimeSeriesForecastingJobConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CandidateGenerationConfig", targetDepth))
                {
                    var unmarshaller = CandidateGenerationConfigUnmarshaller.Instance;
                    unmarshalledObject.CandidateGenerationConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CompletionCriteria", targetDepth))
                {
                    var unmarshaller = AutoMLJobCompletionCriteriaUnmarshaller.Instance;
                    unmarshalledObject.CompletionCriteria = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FeatureSpecificationS3Uri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeatureSpecificationS3Uri = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ForecastFrequency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ForecastFrequency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ForecastHorizon", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ForecastHorizon = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ForecastQuantiles", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ForecastQuantiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HolidayConfig", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HolidayConfigAttributes, HolidayConfigAttributesUnmarshaller>(HolidayConfigAttributesUnmarshaller.Instance);
                    unmarshalledObject.HolidayConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeSeriesConfig", targetDepth))
                {
                    var unmarshaller = TimeSeriesConfigUnmarshaller.Instance;
                    unmarshalledObject.TimeSeriesConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Transformations", targetDepth))
                {
                    var unmarshaller = TimeSeriesTransformationsUnmarshaller.Instance;
                    unmarshalledObject.Transformations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TimeSeriesForecastingJobConfigUnmarshaller _instance = new TimeSeriesForecastingJobConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TimeSeriesForecastingJobConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}