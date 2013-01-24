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
      /// DescribeCacheResultUnmarshaller 
      /// </summary> 
      internal class DescribeCacheResultUnmarshaller : IUnmarshaller<DescribeCacheResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeCacheResult, JsonUnmarshallerContext> 
      { 
        DescribeCacheResult IUnmarshaller<DescribeCacheResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeCacheResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeCacheResult describeCacheResult = new DescribeCacheResult();
          describeCacheResult.DiskIds = null; 
                                  
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
                describeCacheResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskIds", targetDepth)) 
              {
                describeCacheResult.DiskIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeCacheResult.DiskIds.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("CacheAllocatedInBytes", targetDepth)) 
              {
                describeCacheResult.CacheAllocatedInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CacheUsedPercentage", targetDepth)) 
              {
                describeCacheResult.CacheUsedPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CacheDirtyPercentage", targetDepth)) 
              {
                describeCacheResult.CacheDirtyPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CacheHitPercentage", targetDepth)) 
              {
                describeCacheResult.CacheHitPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CacheMissPercentage", targetDepth)) 
              {
                describeCacheResult.CacheMissPercentage = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeCacheResult; 
                } 
            } 
          
          
            return describeCacheResult; 
        } 
        
        private static DescribeCacheResultUnmarshaller instance; 
        public static DescribeCacheResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeCacheResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
