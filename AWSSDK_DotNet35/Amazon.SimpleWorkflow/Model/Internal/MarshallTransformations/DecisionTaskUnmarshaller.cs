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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            DecisionTask decisionTask = new DecisionTask();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("taskToken", targetDepth))
              {
                context.Read();
                decisionTask.TaskToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                context.Read();
                decisionTask.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecution", targetDepth))
              {
                context.Read();
                decisionTask.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                context.Read();
                decisionTask.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("events", targetDepth))
              {
                context.Read();
                decisionTask.Events = new List<HistoryEvent>();
                        HistoryEventUnmarshaller unmarshaller = HistoryEventUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   decisionTask.Events.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("nextPageToken", targetDepth))
              {
                context.Read();
                decisionTask.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("previousStartedEventId", targetDepth))
              {
                context.Read();
                decisionTask.PreviousStartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
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
  
