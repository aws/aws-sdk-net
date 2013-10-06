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
      /// ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller
      /// </summary>
      internal class ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller : IUnmarshaller<ExternalWorkflowExecutionCancelRequestedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<ExternalWorkflowExecutionCancelRequestedEventAttributes, JsonUnmarshallerContext>
      {
        ExternalWorkflowExecutionCancelRequestedEventAttributes IUnmarshaller<ExternalWorkflowExecutionCancelRequestedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ExternalWorkflowExecutionCancelRequestedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            ExternalWorkflowExecutionCancelRequestedEventAttributes externalWorkflowExecutionCancelRequestedEventAttributes = new ExternalWorkflowExecutionCancelRequestedEventAttributes();
          
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
                externalWorkflowExecutionCancelRequestedEventAttributes.WorkflowExecution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InitiatedEventId", targetDepth))
              {
                externalWorkflowExecutionCancelRequestedEventAttributes.InitiatedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return externalWorkflowExecutionCancelRequestedEventAttributes;
                }
            }
          

            return externalWorkflowExecutionCancelRequestedEventAttributes;
        }

        private static ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller instance;
        public static ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
