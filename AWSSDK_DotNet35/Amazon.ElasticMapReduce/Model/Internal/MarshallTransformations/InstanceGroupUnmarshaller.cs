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
      /// InstanceGroupUnmarshaller
      /// </summary>
      internal class InstanceGroupUnmarshaller : IUnmarshaller<InstanceGroup, XmlUnmarshallerContext>, IUnmarshaller<InstanceGroup, JsonUnmarshallerContext>
      {
        InstanceGroup IUnmarshaller<InstanceGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InstanceGroup Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            InstanceGroup instanceGroup = new InstanceGroup();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                instanceGroup.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                instanceGroup.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Market", targetDepth))
              {
                instanceGroup.Market = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceGroupType", targetDepth))
              {
                instanceGroup.InstanceGroupType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("BidPrice", targetDepth))
              {
                instanceGroup.BidPrice = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceType", targetDepth))
              {
                instanceGroup.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RequestedInstanceCount", targetDepth))
              {
                instanceGroup.RequestedInstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RunningInstanceCount", targetDepth))
              {
                instanceGroup.RunningInstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                instanceGroup.Status = InstanceGroupStatusUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return instanceGroup;
        }

        private static InstanceGroupUnmarshaller instance;
        public static InstanceGroupUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstanceGroupUnmarshaller();
            return instance;
        }
    }
}
  
