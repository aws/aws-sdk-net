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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            ActivityTaskScheduledEventAttributes activityTaskScheduledEventAttributes = new ActivityTaskScheduledEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("activityType", targetDepth))
              {
                activityTaskScheduledEventAttributes.ActivityType = ActivityTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityId", targetDepth))
              {
                activityTaskScheduledEventAttributes.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                activityTaskScheduledEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                activityTaskScheduledEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduleToStartTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.ScheduleToStartTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduleToCloseTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.ScheduleToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startToCloseTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.StartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                activityTaskScheduledEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                activityTaskScheduledEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("heartbeatTimeout", targetDepth))
              {
                activityTaskScheduledEventAttributes.HeartbeatTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
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
  
