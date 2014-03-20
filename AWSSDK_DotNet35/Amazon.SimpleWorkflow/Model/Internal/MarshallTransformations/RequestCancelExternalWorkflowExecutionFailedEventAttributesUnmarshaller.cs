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
      /// RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller
      /// </summary>
      internal class RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<RequestCancelExternalWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<RequestCancelExternalWorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext>
      {
        RequestCancelExternalWorkflowExecutionFailedEventAttributes IUnmarshaller<RequestCancelExternalWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public RequestCancelExternalWorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            RequestCancelExternalWorkflowExecutionFailedEventAttributes requestCancelExternalWorkflowExecutionFailedEventAttributes = new RequestCancelExternalWorkflowExecutionFailedEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("workflowId", targetDepth))
              {
                requestCancelExternalWorkflowExecutionFailedEventAttributes.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("runId", targetDepth))
              {
                requestCancelExternalWorkflowExecutionFailedEventAttributes.RunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("cause", targetDepth))
              {
                requestCancelExternalWorkflowExecutionFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("initiatedEventId", targetDepth))
              {
                requestCancelExternalWorkflowExecutionFailedEventAttributes.InitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                requestCancelExternalWorkflowExecutionFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                requestCancelExternalWorkflowExecutionFailedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return requestCancelExternalWorkflowExecutionFailedEventAttributes;
        }

        private static RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller instance;
        public static RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
