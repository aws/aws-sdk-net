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
    /// Response Unmarshaller for AutoScalingInstanceDetails Object
    /// </summary>  
    public class AutoScalingInstanceDetailsUnmarshaller : IUnmarshaller<AutoScalingInstanceDetails, XmlUnmarshallerContext>, IUnmarshaller<AutoScalingInstanceDetails, JsonUnmarshallerContext>
    {
        public AutoScalingInstanceDetails Unmarshall(XmlUnmarshallerContext context)
        {
            AutoScalingInstanceDetails unmarshalledObject = new AutoScalingInstanceDetails();
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
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AutoScalingGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.HealthStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LaunchConfigurationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.LaunchConfigurationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LifecycleState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.LifecycleState = unmarshaller.Unmarshall(context);
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

        public AutoScalingInstanceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static AutoScalingInstanceDetailsUnmarshaller instance;
        public static AutoScalingInstanceDetailsUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new AutoScalingInstanceDetailsUnmarshaller();
            }
            return instance;
        }

    }
}