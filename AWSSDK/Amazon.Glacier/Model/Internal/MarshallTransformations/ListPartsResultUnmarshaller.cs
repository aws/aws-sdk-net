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
      /// ListPartsResultUnmarshaller 
      /// </summary> 
      internal class ListPartsResultUnmarshaller : IUnmarshaller<ListPartsResult, XmlUnmarshallerContext>, IUnmarshaller<ListPartsResult, JsonUnmarshallerContext> 
      { 
        ListPartsResult IUnmarshaller<ListPartsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ListPartsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            ListPartsResult listPartsResult = new ListPartsResult();
          listPartsResult.Parts = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("MultipartUploadId", targetDepth)) 
              {
                listPartsResult.MultipartUploadId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VaultARN", targetDepth)) 
              {
                listPartsResult.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ArchiveDescription", targetDepth)) 
              {
                listPartsResult.ArchiveDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("PartSizeInBytes", targetDepth)) 
              {
                listPartsResult.PartSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CreationDate", targetDepth)) 
              {
                listPartsResult.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Parts", targetDepth)) 
              {
                listPartsResult.Parts = new List<PartListElement>();
                        PartListElementUnmarshaller unmarshaller = PartListElementUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listPartsResult.Parts.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("Marker", targetDepth)) 
              {
                listPartsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return listPartsResult; 
                } 
            } 
          
          
            return listPartsResult; 
        } 
        
        private static ListPartsResultUnmarshaller instance; 
        public static ListPartsResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new ListPartsResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
