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
            JobFlowDetail jobFlowDetail = new JobFlowDetail();
          jobFlowDetail.Steps = null;
                        jobFlowDetail.BootstrapActions = null;
                        jobFlowDetail.SupportedProducts = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
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
                jobFlowDetail.Steps = new List<StepDetail>();
                        StepDetailUnmarshaller unmarshaller = StepDetailUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     jobFlowDetail.Steps.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("BootstrapActions", targetDepth))
              {
                jobFlowDetail.BootstrapActions = new List<BootstrapActionDetail>();
                        BootstrapActionDetailUnmarshaller unmarshaller = BootstrapActionDetailUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     jobFlowDetail.BootstrapActions.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("SupportedProducts", targetDepth))
              {
                jobFlowDetail.SupportedProducts = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     jobFlowDetail.SupportedProducts.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
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
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return jobFlowDetail;
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
  
