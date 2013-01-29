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
      /// StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller
      /// </summary>
      internal class StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller : IUnmarshaller<StartChildWorkflowExecutionInitiatedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<StartChildWorkflowExecutionInitiatedEventAttributes, JsonUnmarshallerContext>
      {
        StartChildWorkflowExecutionInitiatedEventAttributes IUnmarshaller<StartChildWorkflowExecutionInitiatedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StartChildWorkflowExecutionInitiatedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            StartChildWorkflowExecutionInitiatedEventAttributes startChildWorkflowExecutionInitiatedEventAttributes = new StartChildWorkflowExecutionInitiatedEventAttributes();
          startChildWorkflowExecutionInitiatedEventAttributes.TagList = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("WorkflowId", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowType", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Control", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Input", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ExecutionStartToCloseTimeout", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskList", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildPolicy", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TaskStartToCloseTimeout", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TagList", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.TagList = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     startChildWorkflowExecutionInitiatedEventAttributes.TagList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return startChildWorkflowExecutionInitiatedEventAttributes;
                }
            }
          

            return startChildWorkflowExecutionInitiatedEventAttributes;
        }

        private static StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller instance;
        public static StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
