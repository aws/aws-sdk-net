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
      /// DiskUnmarshaller 
      /// </summary> 
      internal class DiskUnmarshaller : IUnmarshaller<Disk, XmlUnmarshallerContext>, IUnmarshaller<Disk, JsonUnmarshallerContext> 
      { 
        Disk IUnmarshaller<Disk, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public Disk Unmarshall(JsonUnmarshallerContext context) 
        {
            Disk disk = new Disk();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("DiskId", targetDepth)) 
              {
                disk.DiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskPath", targetDepth)) 
              {
                disk.DiskPath = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskNode", targetDepth)) 
              {
                disk.DiskNode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskSizeInBytes", targetDepth)) 
              {
                disk.DiskSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskAllocationType", targetDepth)) 
              {
                disk.DiskAllocationType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DiskAllocationResource", targetDepth)) 
              {
                disk.DiskAllocationResource = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return disk; 
                } 
            } 
          
          
            return disk; 
        } 
        
        private static DiskUnmarshaller instance; 
        public static DiskUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DiskUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
