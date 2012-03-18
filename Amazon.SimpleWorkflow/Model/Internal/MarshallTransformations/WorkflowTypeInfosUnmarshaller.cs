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
      /// WorkflowTypeInfosUnmarshaller 
      /// </summary> 
      internal class WorkflowTypeInfosUnmarshaller : IUnmarshaller<WorkflowTypeInfos, XmlUnmarshallerContext>, IUnmarshaller<WorkflowTypeInfos, JsonUnmarshallerContext> 
      { 
        WorkflowTypeInfos IUnmarshaller<WorkflowTypeInfos, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public WorkflowTypeInfos Unmarshall(JsonUnmarshallerContext context) 
        { 
          WorkflowTypeInfos workflowTypeInfos = new WorkflowTypeInfos();
          workflowTypeInfos.TypeInfos = null; 
                        
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("TypeInfos", targetDepth)) 
              {
                workflowTypeInfos.TypeInfos = new List<WorkflowTypeInfo>();
                        WorkflowTypeInfoUnmarshaller unmarshaller = WorkflowTypeInfoUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     workflowTypeInfos.TypeInfos.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("NextPageToken", targetDepth)) 
              {
                workflowTypeInfos.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return workflowTypeInfos; 
            } 
          } 
          return workflowTypeInfos; 
        } 
        
        private static WorkflowTypeInfosUnmarshaller instance; 
        public static WorkflowTypeInfosUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new WorkflowTypeInfosUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
