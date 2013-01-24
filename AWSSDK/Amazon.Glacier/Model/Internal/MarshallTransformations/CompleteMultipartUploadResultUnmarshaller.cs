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
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// CompleteMultipartUploadResultUnmarshaller 
      /// </summary> 
      internal class CompleteMultipartUploadResultUnmarshaller : IUnmarshaller<CompleteMultipartUploadResult, XmlUnmarshallerContext>, IUnmarshaller<CompleteMultipartUploadResult, JsonUnmarshallerContext> 
      { 
        CompleteMultipartUploadResult IUnmarshaller<CompleteMultipartUploadResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public CompleteMultipartUploadResult Unmarshall(JsonUnmarshallerContext context) 
        {
            CompleteMultipartUploadResult completeMultipartUploadResult = new CompleteMultipartUploadResult();
          

            if (context.Headers["Location"] != null)
                completeMultipartUploadResult.Location = context.Headers["Location"];
            if (context.Headers["x-amz-sha256-tree-hash"] != null)
                completeMultipartUploadResult.Checksum = context.Headers["x-amz-sha256-tree-hash"];
            if (context.Headers["x-amz-archive-id"] != null)
                completeMultipartUploadResult.ArchiveId = context.Headers["x-amz-archive-id"];
          
            return completeMultipartUploadResult; 
        } 
        
        private static CompleteMultipartUploadResultUnmarshaller instance; 
        public static CompleteMultipartUploadResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new CompleteMultipartUploadResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
