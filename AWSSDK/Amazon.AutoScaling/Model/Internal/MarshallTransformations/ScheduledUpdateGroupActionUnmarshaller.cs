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
     ///   ScheduledUpdateGroupAction Unmarshaller
     /// </summary>
    internal class ScheduledUpdateGroupActionUnmarshaller : IUnmarshaller<ScheduledUpdateGroupAction, XmlUnmarshallerContext>, IUnmarshaller<ScheduledUpdateGroupAction, JsonUnmarshallerContext> 
    {
        public ScheduledUpdateGroupAction Unmarshall(XmlUnmarshallerContext context) 
        {
            ScheduledUpdateGroupAction scheduledUpdateGroupAction = new ScheduledUpdateGroupAction();
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
                        scheduledUpdateGroupAction.AutoScalingGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ScheduledActionName", targetDepth))
                    {
                        scheduledUpdateGroupAction.ScheduledActionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ScheduledActionARN", targetDepth))
                    {
                        scheduledUpdateGroupAction.ScheduledActionARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Time", targetDepth))
                    {
                        scheduledUpdateGroupAction.Time = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        scheduledUpdateGroupAction.StartTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EndTime", targetDepth))
                    {
                        scheduledUpdateGroupAction.EndTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Recurrence", targetDepth))
                    {
                        scheduledUpdateGroupAction.Recurrence = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MinSize", targetDepth))
                    {
                        scheduledUpdateGroupAction.MinSize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxSize", targetDepth))
                    {
                        scheduledUpdateGroupAction.MaxSize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DesiredCapacity", targetDepth))
                    {
                        scheduledUpdateGroupAction.DesiredCapacity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return scheduledUpdateGroupAction;
                }
            }
                        


            return scheduledUpdateGroupAction;
        }

        public ScheduledUpdateGroupAction Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ScheduledUpdateGroupActionUnmarshaller instance;

        public static ScheduledUpdateGroupActionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ScheduledUpdateGroupActionUnmarshaller();

            return instance;
        }
    }
}
    
