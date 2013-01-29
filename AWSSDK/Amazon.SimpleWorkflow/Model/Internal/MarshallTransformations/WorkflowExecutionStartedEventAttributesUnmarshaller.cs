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
            WorkflowExecutionStartedEventAttributes workflowExecutionStartedEventAttributes = new WorkflowExecutionStartedEventAttributes();
          workflowExecutionStartedEventAttributes.TagList = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Input", targetDepth))
              {
                workflowExecutionStartedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ExecutionStartToCloseTimeout", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskStartToCloseTimeout", targetDepth))
              {
                workflowExecutionStartedEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildPolicy", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskList", targetDepth))
              {
                workflowExecutionStartedEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowType", targetDepth))
              {
                workflowExecutionStartedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TagList", targetDepth))
              {
                workflowExecutionStartedEventAttributes.TagList = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     workflowExecutionStartedEventAttributes.TagList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("ContinuedExecutionRunId", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ContinuedExecutionRunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ParentWorkflowExecution", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ParentWorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ParentInitiatedEventId", targetDepth))
              {
                workflowExecutionStartedEventAttributes.ParentInitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
