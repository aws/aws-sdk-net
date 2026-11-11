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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingPolicy Object
    /// </summary>
    public partial class ScalingPolicyUnmarshaller : IXmlUnmarshaller<ScalingPolicy, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ScalingPolicy Unmarshall(XmlUnmarshallerContext context)
        {
            ScalingPolicy unmarshalledObject = new ScalingPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
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
                        if (unmarshalledObject.Alarms == null)
                        {
                            unmarshalledObject.Alarms = new List<Alarm>();
                        }
                        var unmarshaller = AlarmUnmarshaller.Instance;
                        unmarshalledObject.Alarms.Add(unmarshaller.Unmarshall(context));
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
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Cooldown = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("EstimatedInstanceWarmup", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
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
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinAdjustmentMagnitude = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("MinAdjustmentStep", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
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

                    if (context.TestExpression("PredictiveScalingConfiguration", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingConfigurationUnmarshaller.Instance;
                        unmarshalledObject.PredictiveScalingConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ScalingAdjustment", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ScalingAdjustment = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StepAdjustments/member", targetDepth))
                    {
                        if (unmarshalledObject.StepAdjustments == null)
                        {
                            unmarshalledObject.StepAdjustments = new List<StepAdjustment>();
                        }
                        var unmarshaller = StepAdjustmentUnmarshaller.Instance;
                        unmarshalledObject.StepAdjustments.Add(unmarshaller.Unmarshall(context));
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

        private static ScalingPolicyUnmarshaller _instance = new ScalingPolicyUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ScalingPolicyUnmarshaller Instance => _instance;
    }
}
