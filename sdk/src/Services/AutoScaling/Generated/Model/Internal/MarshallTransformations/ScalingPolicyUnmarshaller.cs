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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingPolicy Object
    /// </summary>  
    public class ScalingPolicyUnmarshaller : IUnmarshaller<ScalingPolicy, XmlUnmarshallerContext>, IUnmarshaller<ScalingPolicy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScalingPolicy Unmarshall(XmlUnmarshallerContext context)
        {
            ScalingPolicy unmarshalledObject = new ScalingPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AdjustmentType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AdjustmentType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Alarms/member", targetDepth))
                    {
                        var unmarshaller = AlarmUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Alarms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutoScalingGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Cooldown", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Cooldown = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedInstanceWarmup", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.EstimatedInstanceWarmup = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("MinAdjustmentStep", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MinAdjustmentStep = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PolicyARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PolicyType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ScalingAdjustment", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.ScalingAdjustment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StepAdjustments/member", targetDepth))
                    {
                        var unmarshaller = StepAdjustmentUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.StepAdjustments.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TargetTrackingConfiguration", targetDepth))
                    {
                        var unmarshaller = TargetTrackingConfigurationUnmarshaller.Instance;
                        unmarshalledObject.TargetTrackingConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScalingPolicy Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
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