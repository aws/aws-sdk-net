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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   NetworkInterfaceAttachment Unmarshaller
     /// </summary>
    internal class NetworkInterfaceAttachmentUnmarshaller : IUnmarshaller<NetworkInterfaceAttachment, XmlUnmarshallerContext>, IUnmarshaller<NetworkInterfaceAttachment, JsonUnmarshallerContext> 
    {
        public NetworkInterfaceAttachment Unmarshall(XmlUnmarshallerContext context) 
        {
            NetworkInterfaceAttachment networkInterfaceAttachment = new NetworkInterfaceAttachment();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("attachmentId", targetDepth))
                    {
                        networkInterfaceAttachment.AttachmentId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        networkInterfaceAttachment.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceOwnerId", targetDepth))
                    {
                        networkInterfaceAttachment.InstanceOwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("deviceIndex", targetDepth))
                    {
                        networkInterfaceAttachment.DeviceIndex = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        networkInterfaceAttachment.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("attachTime", targetDepth))
                    {
                        networkInterfaceAttachment.AttachTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("deleteOnTermination", targetDepth))
                    {
                        networkInterfaceAttachment.DeleteOnTermination = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return networkInterfaceAttachment;
                }
            }
                        


            return networkInterfaceAttachment;
        }

        public NetworkInterfaceAttachment Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static NetworkInterfaceAttachmentUnmarshaller instance;

        public static NetworkInterfaceAttachmentUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new NetworkInterfaceAttachmentUnmarshaller();

            return instance;
        }
    }
}
    
