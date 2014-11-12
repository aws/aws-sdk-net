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
    /// Response Unmarshaller for LifecycleHook Object
    /// </summary>  
    public class LifecycleHookUnmarshaller : IUnmarshaller<LifecycleHook, XmlUnmarshallerContext>, IUnmarshaller<LifecycleHook, JsonUnmarshallerContext>
    {
        public LifecycleHook Unmarshall(XmlUnmarshallerContext context)
        {
            LifecycleHook unmarshalledObject = new LifecycleHook();
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
                    if (context.TestExpression("DefaultResult", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.DefaultResult = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GlobalTimeout", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.GlobalTimeout = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HeartbeatTimeout", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.HeartbeatTimeout = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LifecycleHookName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.LifecycleHookName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LifecycleTransition", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.LifecycleTransition = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NotificationMetadata", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.NotificationMetadata = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NotificationTargetARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.NotificationTargetARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.RoleARN = unmarshaller.Unmarshall(context);
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

        public LifecycleHook Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static LifecycleHookUnmarshaller instance;
        public static LifecycleHookUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new LifecycleHookUnmarshaller();
            }
            return instance;
        }

    }
}