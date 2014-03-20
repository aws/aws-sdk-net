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
      /// WorkflowExecutionTimedOutEventAttributesUnmarshaller
      /// </summary>
      internal class WorkflowExecutionTimedOutEventAttributesUnmarshaller : IUnmarshaller<WorkflowExecutionTimedOutEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionTimedOutEventAttributes, JsonUnmarshallerContext>
      {
        WorkflowExecutionTimedOutEventAttributes IUnmarshaller<WorkflowExecutionTimedOutEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionTimedOutEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowExecutionTimedOutEventAttributes workflowExecutionTimedOutEventAttributes = new WorkflowExecutionTimedOutEventAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("timeoutType", targetDepth))
              {
                workflowExecutionTimedOutEventAttributes.TimeoutType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                workflowExecutionTimedOutEventAttributes.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowExecutionTimedOutEventAttributes;
        }

        private static WorkflowExecutionTimedOutEventAttributesUnmarshaller instance;
        public static WorkflowExecutionTimedOutEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionTimedOutEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
