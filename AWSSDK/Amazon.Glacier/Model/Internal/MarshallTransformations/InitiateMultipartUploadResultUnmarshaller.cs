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
      /// InitiateMultipartUploadResultUnmarshaller 
      /// </summary> 
      internal class InitiateMultipartUploadResultUnmarshaller : IUnmarshaller<InitiateMultipartUploadResult, XmlUnmarshallerContext>, IUnmarshaller<InitiateMultipartUploadResult, JsonUnmarshallerContext> 
      { 
        InitiateMultipartUploadResult IUnmarshaller<InitiateMultipartUploadResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public InitiateMultipartUploadResult Unmarshall(JsonUnmarshallerContext context) 
        {
            InitiateMultipartUploadResult initiateMultipartUploadResult = new InitiateMultipartUploadResult();
          

            if (context.Headers["Location"] != null)
                initiateMultipartUploadResult.Location = context.Headers["Location"];
            if (context.Headers["x-amz-multipart-upload-id"] != null)
                initiateMultipartUploadResult.UploadId = context.Headers["x-amz-multipart-upload-id"];
          
            return initiateMultipartUploadResult; 
        } 
        
        private static InitiateMultipartUploadResultUnmarshaller instance; 
        public static InitiateMultipartUploadResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new InitiateMultipartUploadResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
