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
using System.Collections.Generic;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   VirtualMFADevice Unmarshaller
     /// </summary>
    internal class VirtualMFADeviceUnmarshaller : IUnmarshaller<VirtualMFADevice, XmlUnmarshallerContext>, IUnmarshaller<VirtualMFADevice, JsonUnmarshallerContext> 
    {
        public VirtualMFADevice Unmarshall(XmlUnmarshallerContext context) 
        {
            VirtualMFADevice virtualMFADevice = new VirtualMFADevice();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SerialNumber", targetDepth))
                    {
                        virtualMFADevice.SerialNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Base32StringSeed", targetDepth))
                    {
                        virtualMFADevice.Base32StringSeed = MemoryStreamUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("QRCodePNG", targetDepth))
                    {
                        virtualMFADevice.QRCodePNG = MemoryStreamUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("User", targetDepth))
                    {
                        virtualMFADevice.User = UserUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EnableDate", targetDepth))
                    {
                        virtualMFADevice.EnableDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return virtualMFADevice;
                }
            }
                        


            return virtualMFADevice;
        }

        public VirtualMFADevice Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VirtualMFADeviceUnmarshaller instance;

        public static VirtualMFADeviceUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VirtualMFADeviceUnmarshaller();

            return instance;
        }
    }
}
    
