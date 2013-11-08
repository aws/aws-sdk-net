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
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StorediSCSIVolumeUnmarshaller
      /// </summary>
      internal class StorediSCSIVolumeUnmarshaller : IUnmarshaller<StorediSCSIVolume, XmlUnmarshallerContext>, IUnmarshaller<StorediSCSIVolume, JsonUnmarshallerContext>
      {
        StorediSCSIVolume IUnmarshaller<StorediSCSIVolume, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StorediSCSIVolume Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            StorediSCSIVolume storediSCSIVolume = new StorediSCSIVolume();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("VolumeARN", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeId", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeType", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeStatus", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeSizeInBytes", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeProgress", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeProgress = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeDiskId", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeDiskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SourceSnapshotId", targetDepth))
              {
                context.Read();
                storediSCSIVolume.SourceSnapshotId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PreservedExistingData", targetDepth))
              {
                context.Read();
                storediSCSIVolume.PreservedExistingData = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeiSCSIAttributes", targetDepth))
              {
                context.Read();
                storediSCSIVolume.VolumeiSCSIAttributes = VolumeiSCSIAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return storediSCSIVolume;
                }
            }
          

            return storediSCSIVolume;
        }

        private static StorediSCSIVolumeUnmarshaller instance;
        public static StorediSCSIVolumeUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StorediSCSIVolumeUnmarshaller();
            return instance;
        }
    }
}
  
