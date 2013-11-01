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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// VirtualInterfaceUnmarshaller
      /// </summary>
      internal class VirtualInterfaceUnmarshaller : IUnmarshaller<VirtualInterface, XmlUnmarshallerContext>, IUnmarshaller<VirtualInterface, JsonUnmarshallerContext>
      {
        VirtualInterface IUnmarshaller<VirtualInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public VirtualInterface Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            VirtualInterface virtualInterface = new VirtualInterface();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("ownerAccount", targetDepth))
              {
                context.Read();
                virtualInterface.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceId", targetDepth))
              {
                context.Read();
                virtualInterface.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                context.Read();
                virtualInterface.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionId", targetDepth))
              {
                context.Read();
                virtualInterface.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceType", targetDepth))
              {
                context.Read();
                virtualInterface.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceName", targetDepth))
              {
                context.Read();
                virtualInterface.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("vlan", targetDepth))
              {
                context.Read();
                virtualInterface.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("asn", targetDepth))
              {
                context.Read();
                virtualInterface.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("authKey", targetDepth))
              {
                context.Read();
                virtualInterface.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("amazonAddress", targetDepth))
              {
                context.Read();
                virtualInterface.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("customerAddress", targetDepth))
              {
                context.Read();
                virtualInterface.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceState", targetDepth))
              {
                context.Read();
                virtualInterface.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("customerRouterConfig", targetDepth))
              {
                context.Read();
                virtualInterface.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualGatewayId", targetDepth))
              {
                context.Read();
                virtualInterface.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("routeFilterPrefixes", targetDepth))
              {
                context.Read();
                virtualInterface.RouteFilterPrefixes = new List<RouteFilterPrefix>();
                        RouteFilterPrefixUnmarshaller unmarshaller = RouteFilterPrefixUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   virtualInterface.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return virtualInterface;
                }
            }
          

            return virtualInterface;
        }

        private static VirtualInterfaceUnmarshaller instance;
        public static VirtualInterfaceUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VirtualInterfaceUnmarshaller();
            return instance;
        }
    }
}
  
