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
     ///   Activity Unmarshaller
     /// </summary>
    internal class ActivityUnmarshaller : IUnmarshaller<Activity, XmlUnmarshallerContext>, IUnmarshaller<Activity, JsonUnmarshallerContext> 
    {
        public Activity Unmarshall(XmlUnmarshallerContext context) 
        {
            Activity activity = new Activity();
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
                        activity.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        activity.AutoScalingGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        activity.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Cause", targetDepth))
                    {
                        activity.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        activity.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EndTime", targetDepth))
                    {
                        activity.EndTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StatusCode", targetDepth))
                    {
                        activity.StatusCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StatusMessage", targetDepth))
                    {
                        activity.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Progress", targetDepth))
                    {
                        activity.Progress = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Details", targetDepth))
                    {
                        activity.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return activity;
                }
            }
                        


            return activity;
        }

        public Activity Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ActivityUnmarshaller instance;

        public static ActivityUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ActivityUnmarshaller();

            return instance;
        }
    }
}
    
