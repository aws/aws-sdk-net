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
        public ScalingPolicy Unmarshall(XmlUnmarshallerContext context)
        {
            ScalingPolicy unmarshalledObject = new ScalingPolicy();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AdjustmentType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AdjustmentType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Alarms/member", targetDepth))
                    {
                        var unmarshaller = AlarmUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Alarms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AutoScalingGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Cooldown", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.Cooldown = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinAdjustmentStep", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.MinAdjustmentStep = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.PolicyARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ScalingAdjustment", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.ScalingAdjustment = unmarshaller.Unmarshall(context);
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

        public ScalingPolicy Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ScalingPolicyUnmarshaller instance;
        public static ScalingPolicyUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new ScalingPolicyUnmarshaller();
            }
            return instance;
        }

    }
}