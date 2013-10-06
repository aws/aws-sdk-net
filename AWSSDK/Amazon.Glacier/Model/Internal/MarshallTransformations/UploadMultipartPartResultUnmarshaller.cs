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
      /// UploadMultipartPartResultUnmarshaller 
      /// </summary> 
      internal class UploadMultipartPartResultUnmarshaller : IUnmarshaller<UploadMultipartPartResult, XmlUnmarshallerContext>, IUnmarshaller<UploadMultipartPartResult, JsonUnmarshallerContext> 
      { 
        UploadMultipartPartResult IUnmarshaller<UploadMultipartPartResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public UploadMultipartPartResult Unmarshall(JsonUnmarshallerContext context) 
        {
            UploadMultipartPartResult uploadMultipartPartResult = new UploadMultipartPartResult();
          

            if (context.Headers["x-amz-sha256-tree-hash"] != null)
                uploadMultipartPartResult.Checksum = context.Headers["x-amz-sha256-tree-hash"];
          
            return uploadMultipartPartResult; 
        } 
        
        private static UploadMultipartPartResultUnmarshaller instance; 
        public static UploadMultipartPartResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new UploadMultipartPartResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
