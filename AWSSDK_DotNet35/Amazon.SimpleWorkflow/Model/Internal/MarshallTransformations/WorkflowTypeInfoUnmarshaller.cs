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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowTypeInfo workflowTypeInfo = new WorkflowTypeInfo();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("workflowType", targetDepth))
              {
                workflowTypeInfo.WorkflowType = WorkflowTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("status", targetDepth))
              {
                workflowTypeInfo.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("description", targetDepth))
              {
                workflowTypeInfo.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("creationDate", targetDepth))
              {
                workflowTypeInfo.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("deprecationDate", targetDepth))
              {
                workflowTypeInfo.DeprecationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
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
  
