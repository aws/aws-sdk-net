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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// VolumeUnmarshaller
      /// </summary>
      internal class VolumeUnmarshaller : IUnmarshaller<Volume, XmlUnmarshallerContext>, IUnmarshaller<Volume, JsonUnmarshallerContext>
      {
        Volume IUnmarshaller<Volume, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Volume Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Volume volume = new Volume();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("VolumeId", targetDepth))
              {
                context.Read();
                volume.VolumeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2VolumeId", targetDepth))
              {
                context.Read();
                volume.Ec2VolumeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                volume.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RaidArrayId", targetDepth))
              {
                context.Read();
                volume.RaidArrayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceId", targetDepth))
              {
                context.Read();
                volume.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                context.Read();
                volume.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Size", targetDepth))
              {
                context.Read();
                volume.Size = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Device", targetDepth))
              {
                context.Read();
                volume.Device = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MountPoint", targetDepth))
              {
                context.Read();
                volume.MountPoint = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                context.Read();
                volume.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AvailabilityZone", targetDepth))
              {
                context.Read();
                volume.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return volume;
                }
            }
          

            return volume;
        }

        private static VolumeUnmarshaller instance;
        public static VolumeUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VolumeUnmarshaller();
            return instance;
        }
    }
}
  
