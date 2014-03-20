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
              
              if (context.TestExpression("Id", targetDepth))
              {
                instance.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2InstanceId", targetDepth))
              {
                instance.Ec2InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PublicDnsName", targetDepth))
              {
                instance.PublicDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PublicIpAddress", targetDepth))
              {
                instance.PublicIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PrivateDnsName", targetDepth))
              {
                instance.PrivateDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PrivateIpAddress", targetDepth))
              {
                instance.PrivateIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                instance.Status = InstanceStatusUnmarshaller.GetInstance().Unmarshall(context);
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
  
