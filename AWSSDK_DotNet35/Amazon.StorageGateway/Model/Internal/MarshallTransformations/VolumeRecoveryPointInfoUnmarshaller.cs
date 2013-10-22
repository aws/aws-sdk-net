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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            VolumeRecoveryPointInfo volumeRecoveryPointInfo = new VolumeRecoveryPointInfo();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("VolumeARN", targetDepth))
              {
                context.Read();
                volumeRecoveryPointInfo.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeSizeInBytes", targetDepth))
              {
                context.Read();
                volumeRecoveryPointInfo.VolumeSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeUsageInBytes", targetDepth))
              {
                context.Read();
                volumeRecoveryPointInfo.VolumeUsageInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VolumeRecoveryPointTime", targetDepth))
              {
                context.Read();
                volumeRecoveryPointInfo.VolumeRecoveryPointTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return volumeRecoveryPointInfo;
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
  
