/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
      /// VolumeRecoveryPointInfoUnmarshaller
      /// </summary>
      internal class VolumeRecoveryPointInfoUnmarshaller : IUnmarshaller<VolumeRecoveryPointInfo, XmlUnmarshallerContext>, IUnmarshaller<VolumeRecoveryPointInfo, JsonUnmarshallerContext>
      {
        VolumeRecoveryPointInfo IUnmarshaller<VolumeRecoveryPointInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public VolumeRecoveryPointInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            VolumeRecoveryPointInfo volumeRecoveryPointInfo = new VolumeRecoveryPointInfo();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("VolumeARN", targetDepth))
              {
                volumeRecoveryPointInfo.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeSizeInBytes", targetDepth))
              {
                volumeRecoveryPointInfo.VolumeSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeUsageInBytes", targetDepth))
              {
                volumeRecoveryPointInfo.VolumeUsageInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeRecoveryPointTime", targetDepth))
              {
                volumeRecoveryPointInfo.VolumeRecoveryPointTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return volumeRecoveryPointInfo;
        }

        private static VolumeRecoveryPointInfoUnmarshaller instance;
        public static VolumeRecoveryPointInfoUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VolumeRecoveryPointInfoUnmarshaller();
            return instance;
        }
    }
}
  
