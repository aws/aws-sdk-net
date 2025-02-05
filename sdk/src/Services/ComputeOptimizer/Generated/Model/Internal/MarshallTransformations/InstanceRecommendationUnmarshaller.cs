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
    /// Response Unmarshaller for InstanceRecommendation Object
    /// </summary>  
    public class InstanceRecommendationUnmarshaller : IJsonUnmarshaller<InstanceRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceRecommendation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InstanceRecommendation unmarshalledObject = new InstanceRecommendation();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentInstanceGpuInfo", targetDepth))
                {
                    var unmarshaller = GpuInfoUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstanceGpuInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("currentPerformanceRisk", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentPerformanceRisk = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("effectiveRecommendationPreferences", targetDepth))
                {
                    var unmarshaller = EffectiveRecommendationPreferencesUnmarshaller.Instance;
                    unmarshalledObject.EffectiveRecommendationPreferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("externalMetricStatus", targetDepth))
                {
                    var unmarshaller = ExternalMetricStatusUnmarshaller.Instance;
                    unmarshalledObject.ExternalMetricStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("finding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Finding = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("findingReasonCodes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FindingReasonCodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("idle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Idle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inferredWorkloadTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InferredWorkloadTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastRefreshTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastRefreshTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lookBackPeriodInDays", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.LookBackPeriodInDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recommendationOptions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InstanceRecommendationOption, InstanceRecommendationOptionUnmarshaller>(InstanceRecommendationOptionUnmarshaller.Instance);
                    unmarshalledObject.RecommendationOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recommendationSources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RecommendationSource, RecommendationSourceUnmarshaller>(RecommendationSourceUnmarshaller.Instance);
                    unmarshalledObject.RecommendationSources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("utilizationMetrics", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<UtilizationMetric, UtilizationMetricUnmarshaller>(UtilizationMetricUnmarshaller.Instance);
                    unmarshalledObject.UtilizationMetrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceRecommendationUnmarshaller _instance = new InstanceRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}