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
      /// WorkflowExecutionOpenCountsUnmarshaller
      /// </summary>
      internal class WorkflowExecutionOpenCountsUnmarshaller : IUnmarshaller<WorkflowExecutionOpenCounts, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionOpenCounts, JsonUnmarshallerContext>
      {
        WorkflowExecutionOpenCounts IUnmarshaller<WorkflowExecutionOpenCounts, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionOpenCounts Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WorkflowExecutionOpenCounts workflowExecutionOpenCounts = new WorkflowExecutionOpenCounts();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("openActivityTasks", targetDepth))
              {
                context.Read();
                workflowExecutionOpenCounts.OpenActivityTasks = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("openDecisionTasks", targetDepth))
              {
                context.Read();
                workflowExecutionOpenCounts.OpenDecisionTasks = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("openTimers", targetDepth))
              {
                context.Read();
                workflowExecutionOpenCounts.OpenTimers = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("openChildWorkflowExecutions", targetDepth))
              {
                context.Read();
                workflowExecutionOpenCounts.OpenChildWorkflowExecutions = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return workflowExecutionOpenCounts;
                }
            }
          

            return workflowExecutionOpenCounts;
        }

        private static WorkflowExecutionOpenCountsUnmarshaller instance;
        public static WorkflowExecutionOpenCountsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionOpenCountsUnmarshaller();
            return instance;
        }
    }
}
  
