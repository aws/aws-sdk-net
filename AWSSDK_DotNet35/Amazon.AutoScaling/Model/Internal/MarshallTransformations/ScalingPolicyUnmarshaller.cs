/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.AutoScaling.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ScalingPolicy Unmarshaller
     /// </summary>
    internal class ScalingPolicyUnmarshaller : IUnmarshaller<ScalingPolicy, XmlUnmarshallerContext>, IUnmarshaller<ScalingPolicy, JsonUnmarshallerContext> 
    {
        public ScalingPolicy Unmarshall(XmlUnmarshallerContext context) 
        {
            ScalingPolicy scalingPolicy = new ScalingPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        scalingPolicy.AutoScalingGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PolicyName", targetDepth))
                    {
                        scalingPolicy.PolicyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ScalingAdjustment", targetDepth))
                    {
                        scalingPolicy.ScalingAdjustment = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AdjustmentType", targetDepth))
                    {
                        scalingPolicy.AdjustmentType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Cooldown", targetDepth))
                    {
                        scalingPolicy.Cooldown = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PolicyARN", targetDepth))
                    {
                        scalingPolicy.PolicyARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Alarms/member", targetDepth))
                    {
                        scalingPolicy.Alarms.Add(AlarmUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("MinAdjustmentStep", targetDepth))
                    {
                        scalingPolicy.MinAdjustmentStep = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return scalingPolicy;
                }
            }
                        


            return scalingPolicy;
        }

        public ScalingPolicy Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ScalingPolicyUnmarshaller instance;

        public static ScalingPolicyUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ScalingPolicyUnmarshaller();

            return instance;
        }
    }
}
    
