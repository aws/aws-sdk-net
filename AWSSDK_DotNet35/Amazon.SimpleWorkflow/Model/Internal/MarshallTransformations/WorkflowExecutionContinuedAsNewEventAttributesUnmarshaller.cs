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
      /// WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller
      /// </summary>
      internal class WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller : IUnmarshaller<WorkflowExecutionContinuedAsNewEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionContinuedAsNewEventAttributes, JsonUnmarshallerContext>
      {
        WorkflowExecutionContinuedAsNewEventAttributes IUnmarshaller<WorkflowExecutionContinuedAsNewEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionContinuedAsNewEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WorkflowExecutionContinuedAsNewEventAttributes workflowExecutionContinuedAsNewEventAttributes = new WorkflowExecutionContinuedAsNewEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("input", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("newExecutionRunId", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.NewExecutionRunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.TagList = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
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
                   workflowExecutionContinuedAsNewEventAttributes.TagList.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                context.Read();
                workflowExecutionContinuedAsNewEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return workflowExecutionContinuedAsNewEventAttributes;
                }
            }
          

            return workflowExecutionContinuedAsNewEventAttributes;
        }

        private static WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller instance;
        public static WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
