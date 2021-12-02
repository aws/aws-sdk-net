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
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PerformanceInsightsMetricsDetail Object
    /// </summary>  
    public class PerformanceInsightsMetricsDetailUnmarshaller : IUnmarshaller<PerformanceInsightsMetricsDetail, XmlUnmarshallerContext>, IUnmarshaller<PerformanceInsightsMetricsDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PerformanceInsightsMetricsDetail IUnmarshaller<PerformanceInsightsMetricsDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PerformanceInsightsMetricsDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PerformanceInsightsMetricsDetail unmarshalledObject = new PerformanceInsightsMetricsDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MetricDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricQuery", targetDepth))
                {
                    var unmarshaller = PerformanceInsightsMetricQueryUnmarshaller.Instance;
                    unmarshalledObject.MetricQuery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReferenceData", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PerformanceInsightsReferenceData, PerformanceInsightsReferenceDataUnmarshaller>(PerformanceInsightsReferenceDataUnmarshaller.Instance);
                    unmarshalledObject.ReferenceData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatsAtAnomaly", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PerformanceInsightsStat, PerformanceInsightsStatUnmarshaller>(PerformanceInsightsStatUnmarshaller.Instance);
                    unmarshalledObject.StatsAtAnomaly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatsAtBaseline", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PerformanceInsightsStat, PerformanceInsightsStatUnmarshaller>(PerformanceInsightsStatUnmarshaller.Instance);
                    unmarshalledObject.StatsAtBaseline = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
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