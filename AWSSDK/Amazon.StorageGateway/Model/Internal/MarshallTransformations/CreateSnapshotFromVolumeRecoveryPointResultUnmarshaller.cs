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
      /// CreateSnapshotFromVolumeRecoveryPointResultUnmarshaller 
      /// </summary> 
      internal class CreateSnapshotFromVolumeRecoveryPointResultUnmarshaller : IUnmarshaller<CreateSnapshotFromVolumeRecoveryPointResult, XmlUnmarshallerContext>, IUnmarshaller<CreateSnapshotFromVolumeRecoveryPointResult, JsonUnmarshallerContext> 
      { 
        CreateSnapshotFromVolumeRecoveryPointResult IUnmarshaller<CreateSnapshotFromVolumeRecoveryPointResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public CreateSnapshotFromVolumeRecoveryPointResult Unmarshall(JsonUnmarshallerContext context) 
        {
            CreateSnapshotFromVolumeRecoveryPointResult createSnapshotFromVolumeRecoveryPointResult = new CreateSnapshotFromVolumeRecoveryPointResult();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("SnapshotId", targetDepth)) 
              {
                createSnapshotFromVolumeRecoveryPointResult.SnapshotId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeARN", targetDepth)) 
              {
                createSnapshotFromVolumeRecoveryPointResult.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeRecoveryPointTime", targetDepth)) 
              {
                createSnapshotFromVolumeRecoveryPointResult.VolumeRecoveryPointTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return createSnapshotFromVolumeRecoveryPointResult; 
                } 
            } 
          
          
            return createSnapshotFromVolumeRecoveryPointResult; 
        } 
        
        private static CreateSnapshotFromVolumeRecoveryPointResultUnmarshaller instance; 
        public static CreateSnapshotFromVolumeRecoveryPointResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new CreateSnapshotFromVolumeRecoveryPointResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
