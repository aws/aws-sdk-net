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
      /// WorkflowExecutionInfoUnmarshaller
      /// </summary>
      internal class WorkflowExecutionInfoUnmarshaller : IUnmarshaller<WorkflowExecutionInfo, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionInfo, JsonUnmarshallerContext>
      {
        WorkflowExecutionInfo IUnmarshaller<WorkflowExecutionInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionInfo Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            WorkflowExecutionInfo workflowExecutionInfo = new WorkflowExecutionInfo();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("execution", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.Execution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startTimestamp", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.StartTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("closeTimestamp", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.CloseTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStatus", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.ExecutionStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("closeStatus", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.CloseStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("parent", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.Parent = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.TagList = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   workflowExecutionInfo.TagList.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("cancelRequested", targetDepth))
              {
                context.Read();
                workflowExecutionInfo.CancelRequested = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return workflowExecutionInfo;
                }
            }
          

            return workflowExecutionInfo;
        }

        private static WorkflowExecutionInfoUnmarshaller instance;
        public static WorkflowExecutionInfoUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionInfoUnmarshaller();
            return instance;
        }
    }
}
  
