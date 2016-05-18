/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StepScalingPolicyConfiguration Object
    /// </summary>  
    public class StepScalingPolicyConfigurationUnmarshaller : IUnmarshaller<StepScalingPolicyConfiguration, XmlUnmarshallerContext>, IUnmarshaller<StepScalingPolicyConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StepScalingPolicyConfiguration IUnmarshaller<StepScalingPolicyConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StepScalingPolicyConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StepScalingPolicyConfiguration unmarshalledObject = new StepScalingPolicyConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdjustmentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdjustmentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cooldown", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Cooldown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricAggregationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricAggregationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinAdjustmentMagnitude", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinAdjustmentMagnitude = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepAdjustments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StepAdjustment, StepAdjustmentUnmarshaller>(StepAdjustmentUnmarshaller.Instance);
                    unmarshalledObject.StepAdjustments = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StepScalingPolicyConfigurationUnmarshaller _instance = new StepScalingPolicyConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StepScalingPolicyConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}