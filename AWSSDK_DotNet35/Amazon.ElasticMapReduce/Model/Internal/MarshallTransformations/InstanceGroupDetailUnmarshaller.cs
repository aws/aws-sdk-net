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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            InstanceGroupDetail instanceGroupDetail = new InstanceGroupDetail();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("InstanceGroupId", targetDepth))
              {
                instanceGroupDetail.InstanceGroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                instanceGroupDetail.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Market", targetDepth))
              {
                instanceGroupDetail.Market = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceRole", targetDepth))
              {
                instanceGroupDetail.InstanceRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("BidPrice", targetDepth))
              {
                instanceGroupDetail.BidPrice = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceType", targetDepth))
              {
                instanceGroupDetail.InstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceRequestCount", targetDepth))
              {
                instanceGroupDetail.InstanceRequestCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceRunningCount", targetDepth))
              {
                instanceGroupDetail.InstanceRunningCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("State", targetDepth))
              {
                instanceGroupDetail.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LastStateChangeReason", targetDepth))
              {
                instanceGroupDetail.LastStateChangeReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDateTime", targetDepth))
              {
                instanceGroupDetail.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartDateTime", targetDepth))
              {
                instanceGroupDetail.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ReadyDateTime", targetDepth))
              {
                instanceGroupDetail.ReadyDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndDateTime", targetDepth))
              {
                instanceGroupDetail.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
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
  
