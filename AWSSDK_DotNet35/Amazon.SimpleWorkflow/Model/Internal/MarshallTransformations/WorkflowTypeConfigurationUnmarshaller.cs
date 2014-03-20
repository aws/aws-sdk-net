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
      /// WorkflowTypeConfigurationUnmarshaller
      /// </summary>
      internal class WorkflowTypeConfigurationUnmarshaller : IUnmarshaller<WorkflowTypeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<WorkflowTypeConfiguration, JsonUnmarshallerContext>
      {
        WorkflowTypeConfiguration IUnmarshaller<WorkflowTypeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowTypeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowTypeConfiguration workflowTypeConfiguration = new WorkflowTypeConfiguration();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("defaultTaskStartToCloseTimeout", targetDepth))
              {
                workflowTypeConfiguration.DefaultTaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultExecutionStartToCloseTimeout", targetDepth))
              {
                workflowTypeConfiguration.DefaultExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultTaskList", targetDepth))
              {
                workflowTypeConfiguration.DefaultTaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("defaultChildPolicy", targetDepth))
              {
                workflowTypeConfiguration.DefaultChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowTypeConfiguration;
        }

        private static WorkflowTypeConfigurationUnmarshaller instance;
        public static WorkflowTypeConfigurationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowTypeConfigurationUnmarshaller();
            return instance;
        }
    }
}
  
