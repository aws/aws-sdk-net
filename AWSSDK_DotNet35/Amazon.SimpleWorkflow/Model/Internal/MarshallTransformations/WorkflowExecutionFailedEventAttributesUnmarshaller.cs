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
      /// WorkflowExecutionFailedEventAttributesUnmarshaller
      /// </summary>
      internal class WorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<WorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext>
      {
        WorkflowExecutionFailedEventAttributes IUnmarshaller<WorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WorkflowExecutionFailedEventAttributes workflowExecutionFailedEventAttributes = new WorkflowExecutionFailedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("reason", targetDepth))
              {
                context.Read();
                workflowExecutionFailedEventAttributes.Reason = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("details", targetDepth))
              {
                context.Read();
                workflowExecutionFailedEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                workflowExecutionFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return workflowExecutionFailedEventAttributes;
                }
            }
          

            return workflowExecutionFailedEventAttributes;
        }

        private static WorkflowExecutionFailedEventAttributesUnmarshaller instance;
        public static WorkflowExecutionFailedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionFailedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
