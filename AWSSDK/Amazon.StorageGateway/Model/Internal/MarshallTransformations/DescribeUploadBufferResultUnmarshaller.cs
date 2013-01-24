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
      /// DescribeUploadBufferResultUnmarshaller 
      /// </summary> 
      internal class DescribeUploadBufferResultUnmarshaller : IUnmarshaller<DescribeUploadBufferResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeUploadBufferResult, JsonUnmarshallerContext> 
      { 
        DescribeUploadBufferResult IUnmarshaller<DescribeUploadBufferResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeUploadBufferResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeUploadBufferResult describeUploadBufferResult = new DescribeUploadBufferResult();
          describeUploadBufferResult.DiskIds = null; 
                                  
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
                describeUploadBufferResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskIds", targetDepth)) 
              {
                describeUploadBufferResult.DiskIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeUploadBufferResult.DiskIds.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("UploadBufferUsedInBytes", targetDepth)) 
              {
                describeUploadBufferResult.UploadBufferUsedInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("UploadBufferAllocatedInBytes", targetDepth)) 
              {
                describeUploadBufferResult.UploadBufferAllocatedInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeUploadBufferResult; 
                } 
            } 
          
          
            return describeUploadBufferResult; 
        } 
        
        private static DescribeUploadBufferResultUnmarshaller instance; 
        public static DescribeUploadBufferResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeUploadBufferResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
