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
      /// GlacierJobDescriptionUnmarshaller
      /// </summary>
      internal class GlacierJobDescriptionUnmarshaller : IUnmarshaller<GlacierJobDescription, XmlUnmarshallerContext>, IUnmarshaller<GlacierJobDescription, JsonUnmarshallerContext>
      {
        GlacierJobDescription IUnmarshaller<GlacierJobDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public GlacierJobDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            GlacierJobDescription glacierJobDescription = new GlacierJobDescription();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("JobId", targetDepth))
              {
                context.Read();
                glacierJobDescription.JobId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("JobDescription", targetDepth))
              {
                context.Read();
                glacierJobDescription.JobDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Action", targetDepth))
              {
                context.Read();
                glacierJobDescription.Action = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveId", targetDepth))
              {
                context.Read();
                glacierJobDescription.ArchiveId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VaultARN", targetDepth))
              {
                context.Read();
                glacierJobDescription.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDate", targetDepth))
              {
                context.Read();
                glacierJobDescription.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Completed", targetDepth))
              {
                context.Read();
                glacierJobDescription.Completed = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusCode", targetDepth))
              {
                context.Read();
                glacierJobDescription.StatusCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StatusMessage", targetDepth))
              {
                context.Read();
                glacierJobDescription.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveSizeInBytes", targetDepth))
              {
                context.Read();
                glacierJobDescription.ArchiveSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InventorySizeInBytes", targetDepth))
              {
                context.Read();
                glacierJobDescription.InventorySizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SNSTopic", targetDepth))
              {
                context.Read();
                glacierJobDescription.SNSTopic = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CompletionDate", targetDepth))
              {
                context.Read();
                glacierJobDescription.CompletionDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SHA256TreeHash", targetDepth))
              {
                context.Read();
                glacierJobDescription.SHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ArchiveSHA256TreeHash", targetDepth))
              {
                context.Read();
                glacierJobDescription.ArchiveSHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RetrievalByteRange", targetDepth))
              {
                context.Read();
                glacierJobDescription.RetrievalByteRange = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InventoryRetrievalParameters", targetDepth))
              {
                context.Read();
                glacierJobDescription.InventoryRetrievalParameters = InventoryRetrievalJobDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return glacierJobDescription;
                }
            }
          

            return glacierJobDescription;
        }

        private static GlacierJobDescriptionUnmarshaller instance;
        public static GlacierJobDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new GlacierJobDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
