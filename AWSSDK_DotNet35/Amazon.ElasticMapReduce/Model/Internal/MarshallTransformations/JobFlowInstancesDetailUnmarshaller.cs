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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            JobFlowInstancesDetail jobFlowInstancesDetail = new JobFlowInstancesDetail();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("MasterInstanceType", targetDepth))
              {
                jobFlowInstancesDetail.MasterInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MasterPublicDnsName", targetDepth))
              {
                jobFlowInstancesDetail.MasterPublicDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MasterInstanceId", targetDepth))
              {
                jobFlowInstancesDetail.MasterInstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SlaveInstanceType", targetDepth))
              {
                jobFlowInstancesDetail.SlaveInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceCount", targetDepth))
              {
                jobFlowInstancesDetail.InstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceGroups", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<InstanceGroupDetail,InstanceGroupDetailUnmarshaller>(
                    InstanceGroupDetailUnmarshaller.GetInstance());                  
                jobFlowInstancesDetail.InstanceGroups = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("NormalizedInstanceHours", targetDepth))
              {
                jobFlowInstancesDetail.NormalizedInstanceHours = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2KeyName", targetDepth))
              {
                jobFlowInstancesDetail.Ec2KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2SubnetId", targetDepth))
              {
                jobFlowInstancesDetail.Ec2SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Placement", targetDepth))
              {
                jobFlowInstancesDetail.Placement = PlacementTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("KeepJobFlowAliveWhenNoSteps", targetDepth))
              {
                jobFlowInstancesDetail.KeepJobFlowAliveWhenNoSteps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TerminationProtected", targetDepth))
              {
                jobFlowInstancesDetail.TerminationProtected = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HadoopVersion", targetDepth))
              {
                jobFlowInstancesDetail.HadoopVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
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
  
