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
    /// Response Unmarshaller for EffectiveRecommendationPreferences Object
    /// </summary>  
    public class EffectiveRecommendationPreferencesUnmarshaller : IUnmarshaller<EffectiveRecommendationPreferences, XmlUnmarshallerContext>, IUnmarshaller<EffectiveRecommendationPreferences, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EffectiveRecommendationPreferences IUnmarshaller<EffectiveRecommendationPreferences, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EffectiveRecommendationPreferences Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EffectiveRecommendationPreferences unmarshalledObject = new EffectiveRecommendationPreferences();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cpuVendorArchitectures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CpuVendorArchitectures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enhancedInfrastructureMetrics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnhancedInfrastructureMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("externalMetricsPreference", targetDepth))
                {
                    var unmarshaller = ExternalMetricsPreferenceUnmarshaller.Instance;
                    unmarshalledObject.ExternalMetricsPreference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inferredWorkloadTypes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InferredWorkloadTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EffectiveRecommendationPreferencesUnmarshaller _instance = new EffectiveRecommendationPreferencesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EffectiveRecommendationPreferencesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}