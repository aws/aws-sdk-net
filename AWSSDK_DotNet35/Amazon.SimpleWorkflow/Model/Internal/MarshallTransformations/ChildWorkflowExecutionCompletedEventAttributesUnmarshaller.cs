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
      /// ChildWorkflowExecutionCompletedEventAttributesUnmarshaller
      /// </summary>
      internal class ChildWorkflowExecutionCompletedEventAttributesUnmarshaller : IUnmarshaller<ChildWorkflowExecutionCompletedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ChildWorkflowExecutionCompletedEventAttributes, JsonUnmarshallerContext>
      {
        ChildWorkflowExecutionCompletedEventAttributes IUnmarshaller<ChildWorkflowExecutionCompletedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ChildWorkflowExecutionCompletedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ChildWorkflowExecutionCompletedEventAttributes childWorkflowExecutionCompletedEventAttributes = new ChildWorkflowExecutionCompletedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("workflowExecution", targetDepth))
              {
                context.Read();
                childWorkflowExecutionCompletedEventAttributes.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                context.Read();
                childWorkflowExecutionCompletedEventAttributes.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("result", targetDepth))
              {
                context.Read();
                childWorkflowExecutionCompletedEventAttributes.Result = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("initiatedEventId", targetDepth))
              {
                context.Read();
                childWorkflowExecutionCompletedEventAttributes.InitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startedEventId", targetDepth))
              {
                context.Read();
                childWorkflowExecutionCompletedEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return childWorkflowExecutionCompletedEventAttributes;
                }
            }
          

            return childWorkflowExecutionCompletedEventAttributes;
        }

        private static ChildWorkflowExecutionCompletedEventAttributesUnmarshaller instance;
        public static ChildWorkflowExecutionCompletedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ChildWorkflowExecutionCompletedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
