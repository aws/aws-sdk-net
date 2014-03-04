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
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            VirtualInterface virtualInterface = new VirtualInterface();
          virtualInterface.RouteFilterPrefixes = null;
                        
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
                virtualInterface.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceId", targetDepth))
              {
                virtualInterface.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                virtualInterface.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionId", targetDepth))
              {
                virtualInterface.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceType", targetDepth))
              {
                virtualInterface.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceName", targetDepth))
              {
                virtualInterface.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Vlan", targetDepth))
              {
                virtualInterface.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Asn", targetDepth))
              {
                virtualInterface.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AuthKey", targetDepth))
              {
                virtualInterface.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AmazonAddress", targetDepth))
              {
                virtualInterface.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerAddress", targetDepth))
              {
                virtualInterface.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualInterfaceState", targetDepth))
              {
                virtualInterface.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomerRouterConfig", targetDepth))
              {
                virtualInterface.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VirtualGatewayId", targetDepth))
              {
                virtualInterface.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RouteFilterPrefixes", targetDepth))
              {
                virtualInterface.RouteFilterPrefixes = new List<RouteFilterPrefix>();
                        RouteFilterPrefixUnmarshaller unmarshaller = RouteFilterPrefixUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     virtualInterface.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
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
  
