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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ActivityTaskScheduledEventAttributesUnmarshaller
      /// </summary>
      internal class ActivityTaskScheduledEventAttributesUnmarshaller : IUnmarshaller<ActivityTaskScheduledEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ActivityTaskScheduledEventAttributes, JsonUnmarshallerContext>
      {
        ActivityTaskScheduledEventAttributes IUnmarshaller<ActivityTaskScheduledEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTaskScheduledEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            ActivityTaskScheduledEventAttributes activityTaskScheduledEventAttributes = new ActivityTaskScheduledEventAttributes();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ActivityType", targetDepth))
              {
                activityTaskScheduledEventAttributes.ActivityType = ActivityTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityId", targetDepth))
              {
                activityTaskScheduledEventAttributes.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Input", targetDepth))
              {
                activityTaskScheduledEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Control", targetDepth))
              {
                activityTaskScheduledEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ScheduleToStartTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.ScheduleToStartTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ScheduleToCloseTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.ScheduleToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartToCloseTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.StartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskList", targetDepth))
              {
                activityTaskScheduledEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth))
              {
                activityTaskScheduledEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HeartbeatTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.HeartbeatTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return activityTaskScheduledEventAttributes;
                }
            }
          

            return activityTaskScheduledEventAttributes;
        }

        private static ActivityTaskScheduledEventAttributesUnmarshaller instance;
        public static ActivityTaskScheduledEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTaskScheduledEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
