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
      /// WorkflowTypeInfoUnmarshaller
      /// </summary>
      internal class WorkflowTypeInfoUnmarshaller : IUnmarshaller<WorkflowTypeInfo, XmlUnmarshallerContext>, IUnmarshaller<WorkflowTypeInfo, JsonUnmarshallerContext>
      {
        WorkflowTypeInfo IUnmarshaller<WorkflowTypeInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowTypeInfo Unmarshall(JsonUnmarshallerContext context)
        {
            WorkflowTypeInfo workflowTypeInfo = new WorkflowTypeInfo();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("WorkflowType", targetDepth))
              {
                workflowTypeInfo.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                workflowTypeInfo.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Description", targetDepth))
              {
                workflowTypeInfo.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDate", targetDepth))
              {
                workflowTypeInfo.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DeprecationDate", targetDepth))
              {
                workflowTypeInfo.DeprecationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return workflowTypeInfo;
                }
            }
          

            return workflowTypeInfo;
        }

        private static WorkflowTypeInfoUnmarshaller instance;
        public static WorkflowTypeInfoUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowTypeInfoUnmarshaller();
            return instance;
        }
    }
}
  
