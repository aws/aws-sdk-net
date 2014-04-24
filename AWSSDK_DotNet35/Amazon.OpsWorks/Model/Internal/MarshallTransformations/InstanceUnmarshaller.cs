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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// InstanceUnmarshaller
      /// </summary>
      internal class InstanceUnmarshaller : IUnmarshaller<Instance, XmlUnmarshallerContext>, IUnmarshaller<Instance, JsonUnmarshallerContext>
      {
        Instance IUnmarshaller<Instance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Instance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Instance instance = new Instance();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("InstanceId", targetDepth))
              {
                instance.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2InstanceId", targetDepth))
              {
                instance.Ec2InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Hostname", targetDepth))
              {
                instance.Hostname = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StackId", targetDepth))
              {
                instance.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LayerIds", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                instance.LayerIds = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("SecurityGroupIds", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                instance.SecurityGroupIds = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("InstanceType", targetDepth))
              {
                instance.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceProfileArn", targetDepth))
              {
                instance.InstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                instance.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Os", targetDepth))
              {
                instance.Os = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmiId", targetDepth))
              {
                instance.AmiId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AvailabilityZone", targetDepth))
              {
                instance.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SubnetId", targetDepth))
              {
                instance.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PublicDns", targetDepth))
              {
                instance.PublicDns = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PrivateDns", targetDepth))
              {
                instance.PrivateDns = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PublicIp", targetDepth))
              {
                instance.PublicIp = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PrivateIp", targetDepth))
              {
                instance.PrivateIp = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ElasticIp", targetDepth))
              {
                instance.ElasticIp = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoScalingType", targetDepth))
              {
                instance.AutoScalingType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshKeyName", targetDepth))
              {
                instance.SshKeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshHostRsaKeyFingerprint", targetDepth))
              {
                instance.SshHostRsaKeyFingerprint = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshHostDsaKeyFingerprint", targetDepth))
              {
                instance.SshHostDsaKeyFingerprint = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                instance.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LastServiceErrorId", targetDepth))
              {
                instance.LastServiceErrorId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Architecture", targetDepth))
              {
                instance.Architecture = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RootDeviceType", targetDepth))
              {
                instance.RootDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RootDeviceVolumeId", targetDepth))
              {
                instance.RootDeviceVolumeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstallUpdatesOnBoot", targetDepth))
              {
                instance.InstallUpdatesOnBoot = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EbsOptimized", targetDepth))
              {
                instance.EbsOptimized = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return instance;
        }

        private static InstanceUnmarshaller instance;
        public static InstanceUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstanceUnmarshaller();
            return instance;
        }
    }
}
  
