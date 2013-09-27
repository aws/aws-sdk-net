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
      /// DecisionTaskUnmarshaller
      /// </summary>
      internal class DecisionTaskUnmarshaller : IUnmarshaller<DecisionTask, XmlUnmarshallerContext>, IUnmarshaller<DecisionTask, JsonUnmarshallerContext>
      {
        DecisionTask IUnmarshaller<DecisionTask, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DecisionTask Unmarshall(JsonUnmarshallerContext context)
        {
            DecisionTask decisionTask = new DecisionTask();
          decisionTask.Events = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TaskToken", targetDepth))
              {
                decisionTask.TaskToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartedEventId", targetDepth))
              {
                decisionTask.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecution", targetDepth))
              {
                decisionTask.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowType", targetDepth))
              {
                decisionTask.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Events", targetDepth))
              {
                decisionTask.Events = new List<HistoryEvent>();
                        HistoryEventUnmarshaller unmarshaller = HistoryEventUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     decisionTask.Events.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("NextPageToken", targetDepth))
              {
                decisionTask.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PreviousStartedEventId", targetDepth))
              {
                decisionTask.PreviousStartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return decisionTask;
                }
            }
          

            return decisionTask;
        }

        private static DecisionTaskUnmarshaller instance;
        public static DecisionTaskUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DecisionTaskUnmarshaller();
            return instance;
        }
    }
}
  
