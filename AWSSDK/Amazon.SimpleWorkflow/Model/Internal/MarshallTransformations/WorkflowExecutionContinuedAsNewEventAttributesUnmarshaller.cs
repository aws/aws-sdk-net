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
            WorkflowExecutionContinuedAsNewEventAttributes workflowExecutionContinuedAsNewEventAttributes = new WorkflowExecutionContinuedAsNewEventAttributes();
          workflowExecutionContinuedAsNewEventAttributes.TagList = null;
                        
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
                workflowExecutionContinuedAsNewEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NewExecutionRunId", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.NewExecutionRunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ExecutionStartToCloseTimeout", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskList", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskStartToCloseTimeout", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildPolicy", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TagList", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.TagList = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     workflowExecutionContinuedAsNewEventAttributes.TagList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("WorkflowType", targetDepth))
              {
                workflowExecutionContinuedAsNewEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
