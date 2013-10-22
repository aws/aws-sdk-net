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
      /// WorkflowExecutionDetailUnmarshaller
      /// </summary>
      internal class WorkflowExecutionDetailUnmarshaller : IUnmarshaller<WorkflowExecutionDetail, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionDetail, JsonUnmarshallerContext>
      {
        WorkflowExecutionDetail IUnmarshaller<WorkflowExecutionDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WorkflowExecutionDetail workflowExecutionDetail = new WorkflowExecutionDetail();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("executionInfo", targetDepth))
              {
                context.Read();
                workflowExecutionDetail.ExecutionInfo = WorkflowExecutionInfoUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionConfiguration", targetDepth))
              {
                context.Read();
                workflowExecutionDetail.ExecutionConfiguration = WorkflowExecutionConfigurationUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("openCounts", targetDepth))
              {
                context.Read();
                workflowExecutionDetail.OpenCounts = WorkflowExecutionOpenCountsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("latestActivityTaskTimestamp", targetDepth))
              {
                context.Read();
                workflowExecutionDetail.LatestActivityTaskTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("latestExecutionContext", targetDepth))
              {
                context.Read();
                workflowExecutionDetail.LatestExecutionContext = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return workflowExecutionDetail;
                }
            }
          

            return workflowExecutionDetail;
        }

        private static WorkflowExecutionDetailUnmarshaller instance;
        public static WorkflowExecutionDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionDetailUnmarshaller();
            return instance;
        }
    }
}
  
