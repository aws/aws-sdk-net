/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.SimpleWorkflow.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ChildWorkflowExecutionFailedEventAttributesUnmarshaller 
      /// </summary> 
      internal class ChildWorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<ChildWorkflowExecutionFailedEventAttributes, UnmarshallerContext>, IUnmarshaller<ChildWorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext> 
      { 
        ChildWorkflowExecutionFailedEventAttributes IUnmarshaller<ChildWorkflowExecutionFailedEventAttributes, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ChildWorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          ChildWorkflowExecutionFailedEventAttributes childWorkflowExecutionFailedEventAttributes = new ChildWorkflowExecutionFailedEventAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("WorkflowExecution", targetDepth)) 
              {
                childWorkflowExecutionFailedEventAttributes.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("WorkflowType", targetDepth)) 
              {
                childWorkflowExecutionFailedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Reason", targetDepth)) 
              {
                childWorkflowExecutionFailedEventAttributes.Reason = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Details", targetDepth)) 
              {
                childWorkflowExecutionFailedEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("InitiatedEventId", targetDepth)) 
              {
                childWorkflowExecutionFailedEventAttributes.InitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StartedEventId", targetDepth)) 
              {
                childWorkflowExecutionFailedEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return childWorkflowExecutionFailedEventAttributes; 
            } 
          } 
          return childWorkflowExecutionFailedEventAttributes; 
        } 
        
        private static ChildWorkflowExecutionFailedEventAttributesUnmarshaller instance; 
        public static ChildWorkflowExecutionFailedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new ChildWorkflowExecutionFailedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
