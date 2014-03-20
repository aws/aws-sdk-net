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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// RaidArrayUnmarshaller
      /// </summary>
      internal class RaidArrayUnmarshaller : IUnmarshaller<RaidArray, XmlUnmarshallerContext>, IUnmarshaller<RaidArray, JsonUnmarshallerContext>
      {
        RaidArray IUnmarshaller<RaidArray, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public RaidArray Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            RaidArray raidArray = new RaidArray();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("RaidArrayId", targetDepth))
              {
                raidArray.RaidArrayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceId", targetDepth))
              {
                raidArray.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                raidArray.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RaidLevel", targetDepth))
              {
                raidArray.RaidLevel = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NumberOfDisks", targetDepth))
              {
                raidArray.NumberOfDisks = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Size", targetDepth))
              {
                raidArray.Size = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Device", targetDepth))
              {
                raidArray.Device = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MountPoint", targetDepth))
              {
                raidArray.MountPoint = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AvailabilityZone", targetDepth))
              {
                raidArray.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                raidArray.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return raidArray;
        }

        private static RaidArrayUnmarshaller instance;
        public static RaidArrayUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new RaidArrayUnmarshaller();
            return instance;
        }
    }
}
  
