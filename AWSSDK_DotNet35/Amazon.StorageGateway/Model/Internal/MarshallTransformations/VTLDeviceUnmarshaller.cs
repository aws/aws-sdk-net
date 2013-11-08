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
      /// VTLDeviceUnmarshaller
      /// </summary>
      internal class VTLDeviceUnmarshaller : IUnmarshaller<VTLDevice, XmlUnmarshallerContext>, IUnmarshaller<VTLDevice, JsonUnmarshallerContext>
      {
        VTLDevice IUnmarshaller<VTLDevice, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public VTLDevice Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            VTLDevice vTLDevice = new VTLDevice();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("VTLDeviceARN", targetDepth))
              {
                context.Read();
                vTLDevice.VTLDeviceARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VTLDeviceType", targetDepth))
              {
                context.Read();
                vTLDevice.VTLDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VTLDeviceVendor", targetDepth))
              {
                context.Read();
                vTLDevice.VTLDeviceVendor = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VTLDeviceProductIdentifier", targetDepth))
              {
                context.Read();
                vTLDevice.VTLDeviceProductIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DeviceiSCSIAttributes", targetDepth))
              {
                context.Read();
                vTLDevice.DeviceiSCSIAttributes = DeviceiSCSIAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return vTLDevice;
                }
            }
          

            return vTLDevice;
        }

        private static VTLDeviceUnmarshaller instance;
        public static VTLDeviceUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new VTLDeviceUnmarshaller();
            return instance;
        }
    }
}
  
