/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.SimpleWorkflow.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// WorkflowTypeConfigurationUnmarshaller 
      /// </summary> 
      internal class WorkflowTypeConfigurationUnmarshaller : IUnmarshaller<WorkflowTypeConfiguration, UnmarshallerContext>, IUnmarshaller<WorkflowTypeConfiguration, JsonUnmarshallerContext> 
      { 
        WorkflowTypeConfiguration IUnmarshaller<WorkflowTypeConfiguration, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public WorkflowTypeConfiguration Unmarshall(JsonUnmarshallerContext context) 
        { 
          WorkflowTypeConfiguration workflowTypeConfiguration = new WorkflowTypeConfiguration();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("DefaultTaskStartToCloseTimeout", targetDepth)) 
              {
                workflowTypeConfiguration.DefaultTaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DefaultExecutionStartToCloseTimeout", targetDepth)) 
              {
                workflowTypeConfiguration.DefaultExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DefaultTaskList", targetDepth)) 
              {
                workflowTypeConfiguration.DefaultTaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DefaultChildPolicy", targetDepth)) 
              {
                workflowTypeConfiguration.DefaultChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return workflowTypeConfiguration; 
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
  
