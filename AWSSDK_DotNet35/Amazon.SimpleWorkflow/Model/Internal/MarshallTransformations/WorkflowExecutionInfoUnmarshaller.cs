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
            WorkflowExecutionInfo workflowExecutionInfo = new WorkflowExecutionInfo();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("execution", targetDepth))
              {
                workflowExecutionInfo.Execution = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowType", targetDepth))
              {
                workflowExecutionInfo.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startTimestamp", targetDepth))
              {
                workflowExecutionInfo.StartTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("closeTimestamp", targetDepth))
              {
                workflowExecutionInfo.CloseTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStatus", targetDepth))
              {
                workflowExecutionInfo.ExecutionStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("closeStatus", targetDepth))
              {
                workflowExecutionInfo.CloseStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("parent", targetDepth))
              {
                workflowExecutionInfo.Parent = WorkflowExecutionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("tagList", targetDepth))
              {
                workflowExecutionInfo.TagList = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     workflowExecutionInfo.TagList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("cancelRequested", targetDepth))
              {
                workflowExecutionInfo.CancelRequested = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
