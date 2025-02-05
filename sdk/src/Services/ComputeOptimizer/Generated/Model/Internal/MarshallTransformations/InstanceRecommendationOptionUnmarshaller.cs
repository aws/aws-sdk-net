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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceRecommendationOption Object
    /// </summary>  
    public class InstanceRecommendationOptionUnmarshaller : IJsonUnmarshaller<InstanceRecommendationOption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceRecommendationOption Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InstanceRecommendationOption unmarshalledObject = new InstanceRecommendationOption();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("instanceGpuInfo", targetDepth))
                {
                    var unmarshaller = GpuInfoUnmarshaller.Instance;
                    unmarshalledObject.InstanceGpuInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("migrationEffort", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MigrationEffort = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("performanceRisk", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.PerformanceRisk = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("platformDifferences", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PlatformDifferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("projectedUtilizationMetrics", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UtilizationMetric, UtilizationMetricUnmarshaller>(UtilizationMetricUnmarshaller.Instance);
                    unmarshalledObject.ProjectedUtilizationMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rank", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Rank = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("savingsOpportunity", targetDepth))
                {
                    var unmarshaller = SavingsOpportunityUnmarshaller.Instance;
                    unmarshalledObject.SavingsOpportunity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("savingsOpportunityAfterDiscounts", targetDepth))
                {
                    var unmarshaller = InstanceSavingsOpportunityAfterDiscountsUnmarshaller.Instance;
                    unmarshalledObject.SavingsOpportunityAfterDiscounts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceRecommendationOptionUnmarshaller _instance = new InstanceRecommendationOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRecommendationOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}