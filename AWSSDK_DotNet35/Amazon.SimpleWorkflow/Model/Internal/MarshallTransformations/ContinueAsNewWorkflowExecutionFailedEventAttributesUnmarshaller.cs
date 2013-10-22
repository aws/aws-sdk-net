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
      /// ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller
      /// </summary>
      internal class ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller : IUnmarshaller<ContinueAsNewWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ContinueAsNewWorkflowExecutionFailedEventAttributes, JsonUnmarshallerContext>
      {
        ContinueAsNewWorkflowExecutionFailedEventAttributes IUnmarshaller<ContinueAsNewWorkflowExecutionFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ContinueAsNewWorkflowExecutionFailedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ContinueAsNewWorkflowExecutionFailedEventAttributes continueAsNewWorkflowExecutionFailedEventAttributes = new ContinueAsNewWorkflowExecutionFailedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("cause", targetDepth))
              {
                context.Read();
                continueAsNewWorkflowExecutionFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                continueAsNewWorkflowExecutionFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return continueAsNewWorkflowExecutionFailedEventAttributes;
                }
            }
          

            return continueAsNewWorkflowExecutionFailedEventAttributes;
        }

        private static ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller instance;
        public static ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
