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
    /// Response Unmarshaller for ECSServiceRecommendedOptionProjectedMetric Object
    /// </summary>  
    public class ECSServiceRecommendedOptionProjectedMetricUnmarshaller : IUnmarshaller<ECSServiceRecommendedOptionProjectedMetric, XmlUnmarshallerContext>, IUnmarshaller<ECSServiceRecommendedOptionProjectedMetric, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ECSServiceRecommendedOptionProjectedMetric IUnmarshaller<ECSServiceRecommendedOptionProjectedMetric, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ECSServiceRecommendedOptionProjectedMetric Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ECSServiceRecommendedOptionProjectedMetric unmarshalledObject = new ECSServiceRecommendedOptionProjectedMetric();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("projectedMetrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ECSServiceProjectedMetric, ECSServiceProjectedMetricUnmarshaller>(ECSServiceProjectedMetricUnmarshaller.Instance);
                    unmarshalledObject.ProjectedMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendedCpuUnits", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RecommendedCpuUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendedMemorySize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RecommendedMemorySize = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ECSServiceRecommendedOptionProjectedMetricUnmarshaller _instance = new ECSServiceRecommendedOptionProjectedMetricUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ECSServiceRecommendedOptionProjectedMetricUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}