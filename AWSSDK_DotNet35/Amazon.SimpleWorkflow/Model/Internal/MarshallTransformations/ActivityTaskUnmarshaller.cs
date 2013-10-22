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
      /// ActivityTaskUnmarshaller
      /// </summary>
      internal class ActivityTaskUnmarshaller : IUnmarshaller<ActivityTask, XmlUnmarshallerContext>, IUnmarshaller<ActivityTask, JsonUnmarshallerContext>
      {
        ActivityTask IUnmarshaller<ActivityTask, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTask Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ActivityTask activityTask = new ActivityTask();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("taskToken", targetDepth))
              {
                context.Read();
                activityTask.TaskToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityId", targetDepth))
              {
                context.Read();
                activityTask.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                context.Read();
                activityTask.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecution", targetDepth))
              {
                context.Read();
                activityTask.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityType", targetDepth))
              {
                context.Read();
                activityTask.ActivityType = ActivityTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                context.Read();
                activityTask.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return activityTask;
                }
            }
          

            return activityTask;
        }

        private static ActivityTaskUnmarshaller instance;
        public static ActivityTaskUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTaskUnmarshaller();
            return instance;
        }
    }
}
  
