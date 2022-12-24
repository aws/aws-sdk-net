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
using ThirdParty.Json.LitJson;

namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ECSServiceRecommendation Object
    /// </summary>  
    public class ECSServiceRecommendationUnmarshaller : IUnmarshaller<ECSServiceRecommendation, XmlUnmarshallerContext>, IUnmarshaller<ECSServiceRecommendation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ECSServiceRecommendation IUnmarshaller<ECSServiceRecommendation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ECSServiceRecommendation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ECSServiceRecommendation unmarshalledObject = new ECSServiceRecommendation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentPerformanceRisk", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentPerformanceRisk = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentServiceConfiguration", targetDepth))
                {
                    var unmarshaller = ServiceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CurrentServiceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("finding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Finding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("findingReasonCodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FindingReasonCodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastRefreshTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastRefreshTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lookbackPeriodInDays", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.LookbackPeriodInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceRecommendationOptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ECSServiceRecommendationOption, ECSServiceRecommendationOptionUnmarshaller>(ECSServiceRecommendationOptionUnmarshaller.Instance);
                    unmarshalledObject.ServiceRecommendationOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("utilizationMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ECSServiceUtilizationMetric, ECSServiceUtilizationMetricUnmarshaller>(ECSServiceUtilizationMetricUnmarshaller.Instance);
                    unmarshalledObject.UtilizationMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ECSServiceRecommendationUnmarshaller _instance = new ECSServiceRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ECSServiceRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}