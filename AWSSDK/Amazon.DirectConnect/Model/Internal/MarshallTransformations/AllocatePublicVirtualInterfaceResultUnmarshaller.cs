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
      /// AllocatePublicVirtualInterfaceResultUnmarshaller
      /// </summary>
      internal class AllocatePublicVirtualInterfaceResultUnmarshaller : IUnmarshaller<AllocatePublicVirtualInterfaceResult, XmlUnmarshallerContext>, IUnmarshaller<AllocatePublicVirtualInterfaceResult, JsonUnmarshallerContext>
      {
        AllocatePublicVirtualInterfaceResult IUnmarshaller<AllocatePublicVirtualInterfaceResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AllocatePublicVirtualInterfaceResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            AllocatePublicVirtualInterfaceResult allocatePublicVirtualInterfaceResult = new AllocatePublicVirtualInterfaceResult();
          allocatePublicVirtualInterfaceResult.RouteFilterPrefixes = null;
                        
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
                allocatePublicVirtualInterfaceResult.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceId", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionId", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceType", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceName", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Vlan", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Asn", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AuthKey", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmazonAddress", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerAddress", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceState", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerRouterConfig", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualGatewayId", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RouteFilterPrefixes", targetDepth))
              {
                allocatePublicVirtualInterfaceResult.RouteFilterPrefixes = new List<RouteFilterPrefix>();
                        RouteFilterPrefixUnmarshaller unmarshaller = RouteFilterPrefixUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     allocatePublicVirtualInterfaceResult.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
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
                    return allocatePublicVirtualInterfaceResult;
                }
            }
          

            return allocatePublicVirtualInterfaceResult;
        }

        private static AllocatePublicVirtualInterfaceResultUnmarshaller instance;
        public static AllocatePublicVirtualInterfaceResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AllocatePublicVirtualInterfaceResultUnmarshaller();
            return instance;
        }
    }
}
  
