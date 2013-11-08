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
    using ThirdParty.Json.LitJson;
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// UploadListElementUnmarshaller
      /// </summary>
      internal class UploadListElementUnmarshaller : IUnmarshaller<UploadListElement, XmlUnmarshallerContext>, IUnmarshaller<UploadListElement, JsonUnmarshallerContext>
      {
        UploadListElement IUnmarshaller<UploadListElement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public UploadListElement Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            UploadListElement uploadListElement = new UploadListElement();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("MultipartUploadId", targetDepth))
              {
                context.Read();
                uploadListElement.MultipartUploadId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VaultARN", targetDepth))
              {
                context.Read();
                uploadListElement.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveDescription", targetDepth))
              {
                context.Read();
                uploadListElement.ArchiveDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PartSizeInBytes", targetDepth))
              {
                context.Read();
                uploadListElement.PartSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDate", targetDepth))
              {
                context.Read();
                uploadListElement.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return uploadListElement;
                }
            }
          

            return uploadListElement;
        }

        private static UploadListElementUnmarshaller instance;
        public static UploadListElementUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new UploadListElementUnmarshaller();
            return instance;
        }
    }
}
  
