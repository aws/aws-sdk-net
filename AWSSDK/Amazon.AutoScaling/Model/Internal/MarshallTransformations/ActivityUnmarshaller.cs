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
    /// Response Unmarshaller for Activity Object
    /// </summary>  
    public class ActivityUnmarshaller : IUnmarshaller<Activity, XmlUnmarshallerContext>, IUnmarshaller<Activity, JsonUnmarshallerContext>
    {
        public Activity Unmarshall(XmlUnmarshallerContext context)
        {
            Activity unmarshalledObject = new Activity();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ActivityId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ActivityId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AutoScalingGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Cause", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Cause = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Details", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Details = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Progress", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        unmarshalledObject.Progress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.StatusCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
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

        public Activity Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ActivityUnmarshaller instance;
        public static ActivityUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new ActivityUnmarshaller();
            }
            return instance;
        }

    }
}