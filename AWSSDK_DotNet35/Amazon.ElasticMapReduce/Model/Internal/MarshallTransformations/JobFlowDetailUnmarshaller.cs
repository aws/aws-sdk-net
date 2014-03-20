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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// JobFlowDetailUnmarshaller
      /// </summary>
      internal class JobFlowDetailUnmarshaller : IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowDetail, JsonUnmarshallerContext>
      {
        JobFlowDetail IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobFlowDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            JobFlowDetail jobFlowDetail = new JobFlowDetail();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("JobFlowId", targetDepth))
              {
                jobFlowDetail.JobFlowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                jobFlowDetail.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LogUri", targetDepth))
              {
                jobFlowDetail.LogUri = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmiVersion", targetDepth))
              {
                jobFlowDetail.AmiVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ExecutionStatusDetail", targetDepth))
              {
                jobFlowDetail.ExecutionStatusDetail = JobFlowExecutionStatusDetailUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Instances", targetDepth))
              {
                jobFlowDetail.Instances = JobFlowInstancesDetailUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Steps", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<StepDetail,StepDetailUnmarshaller>(
                    StepDetailUnmarshaller.GetInstance());                  
                jobFlowDetail.Steps = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("BootstrapActions", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<BootstrapActionDetail,BootstrapActionDetailUnmarshaller>(
                    BootstrapActionDetailUnmarshaller.GetInstance());                  
                jobFlowDetail.BootstrapActions = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("SupportedProducts", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                jobFlowDetail.SupportedProducts = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("VisibleToAllUsers", targetDepth))
              {
                jobFlowDetail.VisibleToAllUsers = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("JobFlowRole", targetDepth))
              {
                jobFlowDetail.JobFlowRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return jobFlowDetail;
        }

        private static JobFlowDetailUnmarshaller instance;
        public static JobFlowDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobFlowDetailUnmarshaller();
            return instance;
        }
    }
}
  
