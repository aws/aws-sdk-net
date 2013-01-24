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
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeGatewayInformationResultUnmarshaller 
      /// </summary> 
      internal class DescribeGatewayInformationResultUnmarshaller : IUnmarshaller<DescribeGatewayInformationResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeGatewayInformationResult, JsonUnmarshallerContext> 
      { 
        DescribeGatewayInformationResult IUnmarshaller<DescribeGatewayInformationResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeGatewayInformationResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeGatewayInformationResult describeGatewayInformationResult = new DescribeGatewayInformationResult();
          describeGatewayInformationResult.GatewayNetworkInterfaces = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("GatewayARN", targetDepth)) 
              {
                describeGatewayInformationResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("GatewayId", targetDepth)) 
              {
                describeGatewayInformationResult.GatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("GatewayTimezone", targetDepth)) 
              {
                describeGatewayInformationResult.GatewayTimezone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("GatewayState", targetDepth)) 
              {
                describeGatewayInformationResult.GatewayState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("GatewayNetworkInterfaces", targetDepth)) 
              {
                describeGatewayInformationResult.GatewayNetworkInterfaces = new List<NetworkInterface>();
                        NetworkInterfaceUnmarshaller unmarshaller = NetworkInterfaceUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeGatewayInformationResult.GatewayNetworkInterfaces.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("GatewayType", targetDepth)) 
              {
                describeGatewayInformationResult.GatewayType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("NextUpdateAvailabilityDate", targetDepth)) 
              {
                describeGatewayInformationResult.NextUpdateAvailabilityDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeGatewayInformationResult; 
                } 
            } 
          
          
            return describeGatewayInformationResult; 
        } 
        
        private static DescribeGatewayInformationResultUnmarshaller instance; 
        public static DescribeGatewayInformationResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeGatewayInformationResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
