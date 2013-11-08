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
    using ThirdParty.Json.LitJson;
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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ActivityTaskScheduledEventAttributes activityTaskScheduledEventAttributes = new ActivityTaskScheduledEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("activityType", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.ActivityType = ActivityTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityId", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduleToStartTimeout", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.ScheduleToStartTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduleToCloseTimeout", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.ScheduleToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startToCloseTimeout", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.StartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("heartbeatTimeout", targetDepth))
              {
                context.Read();
                activityTaskScheduledEventAttributes.HeartbeatTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
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
  
