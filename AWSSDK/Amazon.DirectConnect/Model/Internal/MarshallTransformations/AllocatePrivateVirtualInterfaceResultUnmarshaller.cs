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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// AllocatePrivateVirtualInterfaceResultUnmarshaller
      /// </summary>
      internal class AllocatePrivateVirtualInterfaceResultUnmarshaller : IUnmarshaller<AllocatePrivateVirtualInterfaceResult, XmlUnmarshallerContext>, IUnmarshaller<AllocatePrivateVirtualInterfaceResult, JsonUnmarshallerContext>
      {
        AllocatePrivateVirtualInterfaceResult IUnmarshaller<AllocatePrivateVirtualInterfaceResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AllocatePrivateVirtualInterfaceResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            AllocatePrivateVirtualInterfaceResult allocatePrivateVirtualInterfaceResult = new AllocatePrivateVirtualInterfaceResult();
          allocatePrivateVirtualInterfaceResult.RouteFilterPrefixes = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("OwnerAccount", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceId", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionId", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceType", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceName", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Vlan", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Asn", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AuthKey", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmazonAddress", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerAddress", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceState", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerRouterConfig", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualGatewayId", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RouteFilterPrefixes", targetDepth))
              {
                allocatePrivateVirtualInterfaceResult.RouteFilterPrefixes = new List<RouteFilterPrefix>();
                        RouteFilterPrefixUnmarshaller unmarshaller = RouteFilterPrefixUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     allocatePrivateVirtualInterfaceResult.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return allocatePrivateVirtualInterfaceResult;
                }
            }
          

            return allocatePrivateVirtualInterfaceResult;
        }

        private static AllocatePrivateVirtualInterfaceResultUnmarshaller instance;
        public static AllocatePrivateVirtualInterfaceResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AllocatePrivateVirtualInterfaceResultUnmarshaller();
            return instance;
        }
    }
}
  
