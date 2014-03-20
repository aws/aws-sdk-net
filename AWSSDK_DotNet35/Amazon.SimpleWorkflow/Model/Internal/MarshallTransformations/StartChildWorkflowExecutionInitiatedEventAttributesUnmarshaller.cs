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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            StartChildWorkflowExecutionInitiatedEventAttributes startChildWorkflowExecutionInitiatedEventAttributes = new StartChildWorkflowExecutionInitiatedEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("workflowId", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
              {
                startChildWorkflowExecutionInitiatedEventAttributes.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                startChildWorkflowExecutionInitiatedEventAttributes.TagList = unmarshaller.Unmarshall(context);
                
                continue;
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
  
