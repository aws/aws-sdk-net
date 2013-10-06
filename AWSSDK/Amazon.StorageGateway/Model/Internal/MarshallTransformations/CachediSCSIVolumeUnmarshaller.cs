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
      /// CachediSCSIVolumeUnmarshaller 
      /// </summary> 
      internal class CachediSCSIVolumeUnmarshaller : IUnmarshaller<CachediSCSIVolume, XmlUnmarshallerContext>, IUnmarshaller<CachediSCSIVolume, JsonUnmarshallerContext> 
      { 
        CachediSCSIVolume IUnmarshaller<CachediSCSIVolume, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public CachediSCSIVolume Unmarshall(JsonUnmarshallerContext context) 
        {
            CachediSCSIVolume cachediSCSIVolume = new CachediSCSIVolume();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VolumeARN", targetDepth)) 
              {
                cachediSCSIVolume.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeId", targetDepth)) 
              {
                cachediSCSIVolume.VolumeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeType", targetDepth)) 
              {
                cachediSCSIVolume.VolumeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeStatus", targetDepth)) 
              {
                cachediSCSIVolume.VolumeStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeSizeInBytes", targetDepth)) 
              {
                cachediSCSIVolume.VolumeSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeProgress", targetDepth)) 
              {
                cachediSCSIVolume.VolumeProgress = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("SourceSnapshotId", targetDepth)) 
              {
                cachediSCSIVolume.SourceSnapshotId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeiSCSIAttributes", targetDepth)) 
              {
                cachediSCSIVolume.VolumeiSCSIAttributes = VolumeiSCSIAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return cachediSCSIVolume; 
                } 
            } 
          
          
            return cachediSCSIVolume; 
        } 
        
        private static CachediSCSIVolumeUnmarshaller instance; 
        public static CachediSCSIVolumeUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new CachediSCSIVolumeUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
