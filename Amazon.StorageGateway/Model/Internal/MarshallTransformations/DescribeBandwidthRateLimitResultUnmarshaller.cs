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
      /// DescribeBandwidthRateLimitResultUnmarshaller 
      /// </summary> 
      internal class DescribeBandwidthRateLimitResultUnmarshaller : IUnmarshaller<DescribeBandwidthRateLimitResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeBandwidthRateLimitResult, JsonUnmarshallerContext> 
      { 
        DescribeBandwidthRateLimitResult IUnmarshaller<DescribeBandwidthRateLimitResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeBandwidthRateLimitResult Unmarshall(JsonUnmarshallerContext context) 
        { 
          DescribeBandwidthRateLimitResult describeBandwidthRateLimitResult = new DescribeBandwidthRateLimitResult();
          
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
                describeBandwidthRateLimitResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("AverageUploadRateLimitInBitsPerSec", targetDepth)) 
              {
                describeBandwidthRateLimitResult.AverageUploadRateLimitInBitsPerSec = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("AverageDownloadRateLimitInBitsPerSec", targetDepth)) 
              {
                describeBandwidthRateLimitResult.AverageDownloadRateLimitInBitsPerSec = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return describeBandwidthRateLimitResult; 
            } 
          } 
          return describeBandwidthRateLimitResult; 
        } 
        
        private static DescribeBandwidthRateLimitResultUnmarshaller instance; 
        public static DescribeBandwidthRateLimitResultUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new DescribeBandwidthRateLimitResultUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
