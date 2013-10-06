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
      /// GetJobOutputResultUnmarshaller 
      /// </summary> 
      internal class GetJobOutputResultUnmarshaller : IUnmarshaller<GetJobOutputResult, XmlUnmarshallerContext>, IUnmarshaller<GetJobOutputResult, JsonUnmarshallerContext> 
      { 
        GetJobOutputResult IUnmarshaller<GetJobOutputResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public GetJobOutputResult Unmarshall(JsonUnmarshallerContext context) 
        {
            GetJobOutputResult getJobOutputResult = new GetJobOutputResult();
          

            if (context.Headers["x-amz-sha256-tree-hash"] != null)
                getJobOutputResult.Checksum = context.Headers["x-amz-sha256-tree-hash"];
            if (context.Headers["Content-Range"] != null)
                getJobOutputResult.ContentRange = context.Headers["Content-Range"];
            if (context.Headers["Accept-Ranges"] != null)
                getJobOutputResult.AcceptRanges = context.Headers["Accept-Ranges"];
            if (context.Headers["Content-Type"] != null)
                getJobOutputResult.ContentType = context.Headers["Content-Type"];
            if (context.Headers["x-amz-archive-description"] != null)
                getJobOutputResult.ArchiveDescription = context.Headers["x-amz-archive-description"];
        getJobOutputResult.Status = context.HttpStatusCode;
            getJobOutputResult.Body = context.Stream;
            
          
            return getJobOutputResult; 
        } 
        
        private static GetJobOutputResultUnmarshaller instance; 
        public static GetJobOutputResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new GetJobOutputResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
