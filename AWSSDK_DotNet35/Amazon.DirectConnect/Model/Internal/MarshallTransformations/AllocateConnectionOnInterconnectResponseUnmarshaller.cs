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
      /// Response Unmarshaller for AllocateConnectionOnInterconnect operation
      /// </summary>
      internal class AllocateConnectionOnInterconnectResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            AllocateConnectionOnInterconnectResponse response = new AllocateConnectionOnInterconnectResponse();       
          
            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("ownerAccount", targetDepth))
              {
                response.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionId", targetDepth))
              {
                response.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionName", targetDepth))
              {
                response.ConnectionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("connectionState", targetDepth))
              {
                response.ConnectionState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("region", targetDepth))
              {
                response.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("location", targetDepth))
              {
                response.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("bandwidth", targetDepth))
              {
                response.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("vlan", targetDepth))
              {
                response.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("partnerName", targetDepth))
              {
                response.PartnerName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
                        
            return response;
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

        private static AllocateConnectionOnInterconnectResponseUnmarshaller instance;
        public static AllocateConnectionOnInterconnectResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new AllocateConnectionOnInterconnectResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
