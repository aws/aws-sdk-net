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
      /// DescribeJobResultUnmarshaller 
      /// </summary> 
      internal class DescribeJobResultUnmarshaller : IUnmarshaller<DescribeJobResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeJobResult, JsonUnmarshallerContext> 
      { 
        DescribeJobResult IUnmarshaller<DescribeJobResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeJobResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeJobResult describeJobResult = new DescribeJobResult();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("JobId", targetDepth)) 
              {
                describeJobResult.JobId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("JobDescription", targetDepth)) 
              {
                describeJobResult.JobDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Action", targetDepth)) 
              {
                describeJobResult.Action = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ArchiveId", targetDepth)) 
              {
                describeJobResult.ArchiveId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VaultARN", targetDepth)) 
              {
                describeJobResult.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CreationDate", targetDepth)) 
              {
                describeJobResult.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Completed", targetDepth)) 
              {
                describeJobResult.Completed = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StatusCode", targetDepth)) 
              {
                describeJobResult.StatusCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StatusMessage", targetDepth)) 
              {
                describeJobResult.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ArchiveSizeInBytes", targetDepth)) 
              {
                describeJobResult.ArchiveSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("InventorySizeInBytes", targetDepth)) 
              {
                describeJobResult.InventorySizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("SNSTopic", targetDepth)) 
              {
                describeJobResult.SNSTopic = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CompletionDate", targetDepth)) 
              {
                describeJobResult.CompletionDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("SHA256TreeHash", targetDepth)) 
              {
                describeJobResult.SHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ArchiveSHA256TreeHash", targetDepth)) 
              {
                describeJobResult.ArchiveSHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("RetrievalByteRange", targetDepth)) 
              {
                describeJobResult.RetrievalByteRange = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeJobResult; 
                } 
            } 
          
          
            return describeJobResult; 
        } 
        
        private static DescribeJobResultUnmarshaller instance; 
        public static DescribeJobResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeJobResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
