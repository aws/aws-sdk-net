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
    using System.Net;
    using System.Collections.Generic;
    using ThirdParty.Json.LitJson;
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for CreatePrivateVirtualInterface operation
      /// </summary>
      internal class CreatePrivateVirtualInterfaceResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          CreatePrivateVirtualInterfaceResponse response = new CreatePrivateVirtualInterfaceResponse();          
          
          context.Read();
          
          UnmarshallResult(context,response);
          return response;
        }
        
        private static void UnmarshallResult(JsonUnmarshallerContext context,CreatePrivateVirtualInterfaceResponse response)
        {
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("ownerAccount", targetDepth))
              {
                context.Read();
                response.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceId", targetDepth))
              {
                context.Read();
                response.VirtualInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                context.Read();
                response.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionId", targetDepth))
              {
                context.Read();
                response.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceType", targetDepth))
              {
                context.Read();
                response.VirtualInterfaceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceName", targetDepth))
              {
                context.Read();
                response.VirtualInterfaceName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("vlan", targetDepth))
              {
                context.Read();
                response.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("asn", targetDepth))
              {
                context.Read();
                response.Asn = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("authKey", targetDepth))
              {
                context.Read();
                response.AuthKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("amazonAddress", targetDepth))
              {
                context.Read();
                response.AmazonAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("customerAddress", targetDepth))
              {
                context.Read();
                response.CustomerAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualInterfaceState", targetDepth))
              {
                context.Read();
                response.VirtualInterfaceState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("customerRouterConfig", targetDepth))
              {
                context.Read();
                response.CustomerRouterConfig = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("virtualGatewayId", targetDepth))
              {
                context.Read();
                response.VirtualGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("routeFilterPrefixes", targetDepth))
              {
                context.Read();
                response.RouteFilterPrefixes = new List<RouteFilterPrefix>();
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
                   response.RouteFilterPrefixes.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {                   
                    return;
                }
            }
                        
            return;
        }                        
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);                    
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectServerException"))
          {
            return new DirectConnectServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectClientException"))
          {
            return new DirectConnectClientException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
          }
  
          return new AmazonDirectConnectException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreatePrivateVirtualInterfaceResponseUnmarshaller instance;
        public static CreatePrivateVirtualInterfaceResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new CreatePrivateVirtualInterfaceResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
