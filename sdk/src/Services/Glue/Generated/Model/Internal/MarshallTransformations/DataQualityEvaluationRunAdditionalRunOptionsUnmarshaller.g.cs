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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Glue.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataQualityEvaluationRunAdditionalRunOptions Object
    /// </summary>
    public partial class DataQualityEvaluationRunAdditionalRunOptionsUnmarshaller : IJsonUnmarshaller<DataQualityEvaluationRunAdditionalRunOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DataQualityEvaluationRunAdditionalRunOptions Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new DataQualityEvaluationRunAdditionalRunOptions();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CloudWatchMetricsEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchMetricsEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CompositeRuleEvaluationMethod", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompositeRuleEvaluationMethod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CustomLogGroupPrefix", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomLogGroupPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DataQualityRuleResults", targetDepth, ref reader))
                {
                    var unmarshaller = DataQualityRuleResultsOptionsUnmarshaller.Instance;
                    unmarshalledObject.DataQualityRuleResults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ObservationMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObservationMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ObservationResults", targetDepth, ref reader))
                {
                    var unmarshaller = ObservationResultsOptionsUnmarshaller.Instance;
                    unmarshalledObject.ObservationResults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ObservationScope", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObservationScope = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProfilingResults", targetDepth, ref reader))
                {
                    var unmarshaller = ProfilingResultsOptionsUnmarshaller.Instance;
                    unmarshalledObject.ProfilingResults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ResultsS3Prefix", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultsS3Prefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RowLevelResults", targetDepth, ref reader))
                {
                    var unmarshaller = RowLevelResultsOptionsUnmarshaller.Instance;
                    unmarshalledObject.RowLevelResults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static DataQualityEvaluationRunAdditionalRunOptionsUnmarshaller _instance = new DataQualityEvaluationRunAdditionalRunOptionsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DataQualityEvaluationRunAdditionalRunOptionsUnmarshaller Instance => _instance;
    }
}
