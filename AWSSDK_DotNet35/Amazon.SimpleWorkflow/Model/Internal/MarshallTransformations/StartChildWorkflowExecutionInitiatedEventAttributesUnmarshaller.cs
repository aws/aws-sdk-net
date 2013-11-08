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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            StartChildWorkflowExecutionInitiatedEventAttributes startChildWorkflowExecutionInitiatedEventAttributes = new StartChildWorkflowExecutionInitiatedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("workflowId", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                context.Read();
                startChildWorkflowExecutionInitiatedEventAttributes.TagList = new List<String>();
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
                   startChildWorkflowExecutionInitiatedEventAttributes.TagList.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
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
  
