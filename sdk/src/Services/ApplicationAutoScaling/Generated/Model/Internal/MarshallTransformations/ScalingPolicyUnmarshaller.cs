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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingPolicy Object
    /// </summary>  
    public class ScalingPolicyUnmarshaller : IJsonUnmarshaller<ScalingPolicy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ScalingPolicy Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ScalingPolicy unmarshalledObject = new ScalingPolicy();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Alarms", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Alarm, AlarmUnmarshaller>(AlarmUnmarshaller.Instance);
                    unmarshalledObject.Alarms = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PolicyARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PolicyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PolicyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PredictiveScalingPolicyConfiguration", targetDepth))
                {
                    var unmarshaller = PredictiveScalingPolicyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PredictiveScalingPolicyConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ScalableDimension", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalableDimension = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceNamespace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StepScalingPolicyConfiguration", targetDepth))
                {
                    var unmarshaller = StepScalingPolicyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StepScalingPolicyConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetTrackingScalingPolicyConfiguration", targetDepth))
                {
                    var unmarshaller = TargetTrackingScalingPolicyConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TargetTrackingScalingPolicyConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScalingPolicyUnmarshaller _instance = new ScalingPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScalingPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}