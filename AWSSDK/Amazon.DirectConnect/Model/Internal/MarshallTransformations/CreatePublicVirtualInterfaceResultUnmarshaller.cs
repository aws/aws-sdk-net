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
      /// CreatePublicVirtualInterfaceResultUnmarshaller
      /// </summary>
      internal class CreatePublicVirtualInterfaceResultUnmarshaller : IUnmarshaller<CreatePublicVirtualInterfaceResult, XmlUnmarshallerContext>, IUnmarshaller<CreatePublicVirtualInterfaceResult, JsonUnmarshallerContext>
      {
        CreatePublicVirtualInterfaceResult IUnmarshaller<CreatePublicVirtualInterfaceResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CreatePublicVirtualInterfaceResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            CreatePublicVirtualInterfaceResult createPublicVirtualInterfaceResult = new CreatePublicVirtualInterfaceResult();
          createPublicVirtualInterfaceResult.RouteFilterPrefixes = null;
                        
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
                createPublicVirtualInterfaceResult.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceId", targetDepth))
              {
                createPublicVirtualInterfaceResult.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                createPublicVirtualInterfaceResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionId", targetDepth))
              {
                createPublicVirtualInterfaceResult.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceType", targetDepth))
              {
                createPublicVirtualInterfaceResult.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceName", targetDepth))
              {
                createPublicVirtualInterfaceResult.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Vlan", targetDepth))
              {
                createPublicVirtualInterfaceResult.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Asn", targetDepth))
              {
                createPublicVirtualInterfaceResult.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AuthKey", targetDepth))
              {
                createPublicVirtualInterfaceResult.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmazonAddress", targetDepth))
              {
                createPublicVirtualInterfaceResult.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerAddress", targetDepth))
              {
                createPublicVirtualInterfaceResult.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceState", targetDepth))
              {
                createPublicVirtualInterfaceResult.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerRouterConfig", targetDepth))
              {
                createPublicVirtualInterfaceResult.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualGatewayId", targetDepth))
              {
                createPublicVirtualInterfaceResult.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RouteFilterPrefixes", targetDepth))
              {
                createPublicVirtualInterfaceResult.RouteFilterPrefixes = new List<RouteFilterPrefix>();
                        RouteFilterPrefixUnmarshaller unmarshaller = RouteFilterPrefixUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     createPublicVirtualInterfaceResult.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
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
                    return createPublicVirtualInterfaceResult;
                }
            }
          

            return createPublicVirtualInterfaceResult;
        }

        private static CreatePublicVirtualInterfaceResultUnmarshaller instance;
        public static CreatePublicVirtualInterfaceResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CreatePublicVirtualInterfaceResultUnmarshaller();
            return instance;
        }
    }
}
  
