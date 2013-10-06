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
      /// ListLocalDisksResultUnmarshaller 
      /// </summary> 
      internal class ListLocalDisksResultUnmarshaller : IUnmarshaller<ListLocalDisksResult, XmlUnmarshallerContext>, IUnmarshaller<ListLocalDisksResult, JsonUnmarshallerContext> 
      { 
        ListLocalDisksResult IUnmarshaller<ListLocalDisksResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ListLocalDisksResult Unmarshall(JsonUnmarshallerContext context) 
        {
            ListLocalDisksResult listLocalDisksResult = new ListLocalDisksResult();
          listLocalDisksResult.Disks = null; 
                                  
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
                listLocalDisksResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Disks", targetDepth)) 
              {
                listLocalDisksResult.Disks = new List<Disk>();
                        DiskUnmarshaller unmarshaller = DiskUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listLocalDisksResult.Disks.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return listLocalDisksResult; 
                } 
            } 
          
          
            return listLocalDisksResult; 
        } 
        
        private static ListLocalDisksResultUnmarshaller instance; 
        public static ListLocalDisksResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new ListLocalDisksResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
