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
      /// CreatePrivateVirtualInterfaceResultUnmarshaller
      /// </summary>
      internal class CreatePrivateVirtualInterfaceResultUnmarshaller : IUnmarshaller<CreatePrivateVirtualInterfaceResult, XmlUnmarshallerContext>, IUnmarshaller<CreatePrivateVirtualInterfaceResult, JsonUnmarshallerContext>
      {
        CreatePrivateVirtualInterfaceResult IUnmarshaller<CreatePrivateVirtualInterfaceResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CreatePrivateVirtualInterfaceResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            CreatePrivateVirtualInterfaceResult createPrivateVirtualInterfaceResult = new CreatePrivateVirtualInterfaceResult();
          createPrivateVirtualInterfaceResult.RouteFilterPrefixes = null;
                        
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
                createPrivateVirtualInterfaceResult.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceId", targetDepth))
              {
                createPrivateVirtualInterfaceResult.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                createPrivateVirtualInterfaceResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionId", targetDepth))
              {
                createPrivateVirtualInterfaceResult.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceType", targetDepth))
              {
                createPrivateVirtualInterfaceResult.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceName", targetDepth))
              {
                createPrivateVirtualInterfaceResult.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Vlan", targetDepth))
              {
                createPrivateVirtualInterfaceResult.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Asn", targetDepth))
              {
                createPrivateVirtualInterfaceResult.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AuthKey", targetDepth))
              {
                createPrivateVirtualInterfaceResult.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmazonAddress", targetDepth))
              {
                createPrivateVirtualInterfaceResult.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerAddress", targetDepth))
              {
                createPrivateVirtualInterfaceResult.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceState", targetDepth))
              {
                createPrivateVirtualInterfaceResult.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerRouterConfig", targetDepth))
              {
                createPrivateVirtualInterfaceResult.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualGatewayId", targetDepth))
              {
                createPrivateVirtualInterfaceResult.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RouteFilterPrefixes", targetDepth))
              {
                createPrivateVirtualInterfaceResult.RouteFilterPrefixes = new List<RouteFilterPrefix>();
                        RouteFilterPrefixUnmarshaller unmarshaller = RouteFilterPrefixUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     createPrivateVirtualInterfaceResult.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
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
                    return createPrivateVirtualInterfaceResult;
                }
            }
          

            return createPrivateVirtualInterfaceResult;
        }

        private static CreatePrivateVirtualInterfaceResultUnmarshaller instance;
        public static CreatePrivateVirtualInterfaceResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CreatePrivateVirtualInterfaceResultUnmarshaller();
            return instance;
        }
    }
}
  
