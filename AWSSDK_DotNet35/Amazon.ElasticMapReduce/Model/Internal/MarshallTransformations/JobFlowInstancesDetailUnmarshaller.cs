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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// JobFlowInstancesDetailUnmarshaller
      /// </summary>
      internal class JobFlowInstancesDetailUnmarshaller : IUnmarshaller<JobFlowInstancesDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowInstancesDetail, JsonUnmarshallerContext>
      {
        JobFlowInstancesDetail IUnmarshaller<JobFlowInstancesDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobFlowInstancesDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            JobFlowInstancesDetail jobFlowInstancesDetail = new JobFlowInstancesDetail();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("MasterInstanceType", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.MasterInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MasterPublicDnsName", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.MasterPublicDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MasterInstanceId", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.MasterInstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SlaveInstanceType", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.SlaveInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceCount", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.InstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceGroups", targetDepth))
              {
                context.Read();
                
                if (context.CurrentTokenType == JsonToken.Null)
                {
                    jobFlowInstancesDetail.InstanceGroups = null;
                    continue;
                }
                  jobFlowInstancesDetail.InstanceGroups = new List<InstanceGroupDetail>();
                  InstanceGroupDetailUnmarshaller unmarshaller = InstanceGroupDetailUnmarshaller.GetInstance();
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
                   jobFlowInstancesDetail.InstanceGroups.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("NormalizedInstanceHours", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.NormalizedInstanceHours = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2KeyName", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.Ec2KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2SubnetId", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.Ec2SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Placement", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.Placement = PlacementTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeepJobFlowAliveWhenNoSteps", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.KeepJobFlowAliveWhenNoSteps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TerminationProtected", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.TerminationProtected = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HadoopVersion", targetDepth))
              {
                context.Read();
                jobFlowInstancesDetail.HadoopVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return jobFlowInstancesDetail;
                }
            }
          

            return jobFlowInstancesDetail;
        }

        private static JobFlowInstancesDetailUnmarshaller instance;
        public static JobFlowInstancesDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobFlowInstancesDetailUnmarshaller();
            return instance;
        }
    }
}
  
