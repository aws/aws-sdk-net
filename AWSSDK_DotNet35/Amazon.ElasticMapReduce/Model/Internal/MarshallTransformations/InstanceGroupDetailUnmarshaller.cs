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
      /// InstanceGroupDetailUnmarshaller
      /// </summary>
      internal class InstanceGroupDetailUnmarshaller : IUnmarshaller<InstanceGroupDetail, XmlUnmarshallerContext>, IUnmarshaller<InstanceGroupDetail, JsonUnmarshallerContext>
      {
        InstanceGroupDetail IUnmarshaller<InstanceGroupDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InstanceGroupDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            InstanceGroupDetail instanceGroupDetail = new InstanceGroupDetail();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("InstanceGroupId", targetDepth))
              {
                context.Read();
                instanceGroupDetail.InstanceGroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                instanceGroupDetail.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Market", targetDepth))
              {
                context.Read();
                instanceGroupDetail.Market = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceRole", targetDepth))
              {
                context.Read();
                instanceGroupDetail.InstanceRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("BidPrice", targetDepth))
              {
                context.Read();
                instanceGroupDetail.BidPrice = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceType", targetDepth))
              {
                context.Read();
                instanceGroupDetail.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceRequestCount", targetDepth))
              {
                context.Read();
                instanceGroupDetail.InstanceRequestCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceRunningCount", targetDepth))
              {
                context.Read();
                instanceGroupDetail.InstanceRunningCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("State", targetDepth))
              {
                context.Read();
                instanceGroupDetail.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LastStateChangeReason", targetDepth))
              {
                context.Read();
                instanceGroupDetail.LastStateChangeReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDateTime", targetDepth))
              {
                context.Read();
                instanceGroupDetail.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartDateTime", targetDepth))
              {
                context.Read();
                instanceGroupDetail.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ReadyDateTime", targetDepth))
              {
                context.Read();
                instanceGroupDetail.ReadyDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndDateTime", targetDepth))
              {
                context.Read();
                instanceGroupDetail.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return instanceGroupDetail;
                }
            }
          

            return instanceGroupDetail;
        }

        private static InstanceGroupDetailUnmarshaller instance;
        public static InstanceGroupDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstanceGroupDetailUnmarshaller();
            return instance;
        }
    }
}
  
