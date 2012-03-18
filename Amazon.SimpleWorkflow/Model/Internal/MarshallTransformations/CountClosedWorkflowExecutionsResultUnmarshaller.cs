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
    using System.Collections.Generic;
    using Amazon.Runtime.Internal.Transform; 
    
    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// Result Unmarshaller for CountClosedWorkflowExecutions operation 
      /// </summary> 
      internal class CountClosedWorkflowExecutionsResultUnmarshaller : IUnmarshaller<CountClosedWorkflowExecutionsResult, JsonUnmarshallerContext> 
      { 
        public CountClosedWorkflowExecutionsResult Unmarshall(JsonUnmarshallerContext context) 
        { 
          CountClosedWorkflowExecutionsResult result = new CountClosedWorkflowExecutionsResult();
          result.WorkflowExecutionCount = WorkflowExecutionCountUnmarshaller.GetInstance().Unmarshall(context); 
          return result; 
        } 
              
        private static CountClosedWorkflowExecutionsResultUnmarshaller instance; 
        public static CountClosedWorkflowExecutionsResultUnmarshaller GetInstance() 
        { 
          if (instance == null) 
          {
            instance = new CountClosedWorkflowExecutionsResultUnmarshaller(); 
          } 
          return instance; 
        } 
      } 
    } 
  
