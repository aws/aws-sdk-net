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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            InstanceGroup instanceGroup = new InstanceGroup();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                context.Read();
                instanceGroup.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                instanceGroup.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Market", targetDepth))
              {
                context.Read();
                instanceGroup.Market = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceGroupType", targetDepth))
              {
                context.Read();
                instanceGroup.InstanceGroupType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("BidPrice", targetDepth))
              {
                context.Read();
                instanceGroup.BidPrice = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceType", targetDepth))
              {
                context.Read();
                instanceGroup.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RequestedInstanceCount", targetDepth))
              {
                context.Read();
                instanceGroup.RequestedInstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RunningInstanceCount", targetDepth))
              {
                context.Read();
                instanceGroup.RunningInstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                context.Read();
                instanceGroup.Status = InstanceGroupStatusUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return instanceGroup;
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
  
