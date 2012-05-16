/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.StorageGateway.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// NetworkInterfaceUnmarshaller 
      /// </summary> 
      internal class NetworkInterfaceUnmarshaller : IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<NetworkInterface, JsonUnmarshallerContext> 
      { 
        NetworkInterface IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public NetworkInterface Unmarshall(JsonUnmarshallerContext context) 
        { 
          NetworkInterface networkInterface = new NetworkInterface();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("Ipv4Address", targetDepth)) 
              {
                networkInterface.Ipv4Address = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("MacAddress", targetDepth)) 
              {
                networkInterface.MacAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Ipv6Address", targetDepth)) 
              {
                networkInterface.Ipv6Address = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return networkInterface; 
            } 
          } 
          return networkInterface; 
        } 
        
        private static NetworkInterfaceUnmarshaller instance; 
        public static NetworkInterfaceUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new NetworkInterfaceUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
