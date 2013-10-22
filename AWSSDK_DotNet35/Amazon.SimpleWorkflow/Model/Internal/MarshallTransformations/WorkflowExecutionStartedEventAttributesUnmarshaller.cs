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
      /// WorkflowExecutionStartedEventAttributesUnmarshaller
      /// </summary>
      internal class WorkflowExecutionStartedEventAttributesUnmarshaller : IUnmarshaller<WorkflowExecutionStartedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionStartedEventAttributes, JsonUnmarshallerContext>
      {
        WorkflowExecutionStartedEventAttributes IUnmarshaller<WorkflowExecutionStartedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionStartedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WorkflowExecutionStartedEventAttributes workflowExecutionStartedEventAttributes = new WorkflowExecutionStartedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("input", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.TagList = new List<String>();
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
                   workflowExecutionStartedEventAttributes.TagList.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("continuedExecutionRunId", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.ContinuedExecutionRunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("parentWorkflowExecution", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.ParentWorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("parentInitiatedEventId", targetDepth))
              {
                context.Read();
                workflowExecutionStartedEventAttributes.ParentInitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return workflowExecutionStartedEventAttributes;
                }
            }
          

            return workflowExecutionStartedEventAttributes;
        }

        private static WorkflowExecutionStartedEventAttributesUnmarshaller instance;
        public static WorkflowExecutionStartedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionStartedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
