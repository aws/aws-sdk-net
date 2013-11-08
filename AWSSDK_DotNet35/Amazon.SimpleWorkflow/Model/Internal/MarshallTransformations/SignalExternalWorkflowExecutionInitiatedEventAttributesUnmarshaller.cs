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
      /// SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller
      /// </summary>
      internal class SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller : IUnmarshaller<SignalExternalWorkflowExecutionInitiatedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<SignalExternalWorkflowExecutionInitiatedEventAttributes, JsonUnmarshallerContext>
      {
        SignalExternalWorkflowExecutionInitiatedEventAttributes IUnmarshaller<SignalExternalWorkflowExecutionInitiatedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public SignalExternalWorkflowExecutionInitiatedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            SignalExternalWorkflowExecutionInitiatedEventAttributes signalExternalWorkflowExecutionInitiatedEventAttributes = new SignalExternalWorkflowExecutionInitiatedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("workflowId", targetDepth))
              {
                context.Read();
                signalExternalWorkflowExecutionInitiatedEventAttributes.WorkflowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("runId", targetDepth))
              {
                context.Read();
                signalExternalWorkflowExecutionInitiatedEventAttributes.RunId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("signalName", targetDepth))
              {
                context.Read();
                signalExternalWorkflowExecutionInitiatedEventAttributes.SignalName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("input", targetDepth))
              {
                context.Read();
                signalExternalWorkflowExecutionInitiatedEventAttributes.Input = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                signalExternalWorkflowExecutionInitiatedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("control", targetDepth))
              {
                context.Read();
                signalExternalWorkflowExecutionInitiatedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return signalExternalWorkflowExecutionInitiatedEventAttributes;
                }
            }
          

            return signalExternalWorkflowExecutionInitiatedEventAttributes;
        }

        private static SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller instance;
        public static SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
