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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PerformanceInsightsMetricsDetail Object
    /// </summary>  
    public class PerformanceInsightsMetricsDetailUnmarshaller : IJsonUnmarshaller<PerformanceInsightsMetricsDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PerformanceInsightsMetricsDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PerformanceInsightsMetricsDetail unmarshalledObject = new PerformanceInsightsMetricsDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("MetricDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricDisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MetricQuery", targetDepth))
                {
                    var unmarshaller = PerformanceInsightsMetricQueryUnmarshaller.Instance;
                    unmarshalledObject.MetricQuery = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReferenceData", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PerformanceInsightsReferenceData, PerformanceInsightsReferenceDataUnmarshaller>(PerformanceInsightsReferenceDataUnmarshaller.Instance);
                    unmarshalledObject.ReferenceData = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatsAtAnomaly", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PerformanceInsightsStat, PerformanceInsightsStatUnmarshaller>(PerformanceInsightsStatUnmarshaller.Instance);
                    unmarshalledObject.StatsAtAnomaly = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatsAtBaseline", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PerformanceInsightsStat, PerformanceInsightsStatUnmarshaller>(PerformanceInsightsStatUnmarshaller.Instance);
                    unmarshalledObject.StatsAtBaseline = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PerformanceInsightsMetricsDetailUnmarshaller _instance = new PerformanceInsightsMetricsDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PerformanceInsightsMetricsDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}