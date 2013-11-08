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
     ///   InstanceNetworkInterface Unmarshaller
     /// </summary>
    internal class InstanceNetworkInterfaceUnmarshaller : IUnmarshaller<InstanceNetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<InstanceNetworkInterface, JsonUnmarshallerContext> 
    {
        public InstanceNetworkInterface Unmarshall(XmlUnmarshallerContext context) 
        {
            InstanceNetworkInterface instanceNetworkInterface = new InstanceNetworkInterface();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        instanceNetworkInterface.NetworkInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        instanceNetworkInterface.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        instanceNetworkInterface.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        instanceNetworkInterface.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        instanceNetworkInterface.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        instanceNetworkInterface.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateIpAddress", targetDepth))
                    {
                        instanceNetworkInterface.PrivateIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateDnsName", targetDepth))
                    {
                        instanceNetworkInterface.PrivateDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("sourceDestCheck", targetDepth))
                    {
                        instanceNetworkInterface.SourceDestCheck = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        instanceNetworkInterface.Groups.Add(GroupIdentifierUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("attachment", targetDepth))
                    {
                        instanceNetworkInterface.Attachment = InstanceNetworkInterfaceAttachmentUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("association", targetDepth))
                    {
                        instanceNetworkInterface.Association = InstanceNetworkInterfaceAssociationUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateIpAddressesSet/item", targetDepth))
                    {
                        instanceNetworkInterface.PrivateIpAddresses.Add(InstancePrivateIpAddressUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceNetworkInterface;
                }
            }
                        


            return instanceNetworkInterface;
        }

        public InstanceNetworkInterface Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceNetworkInterfaceUnmarshaller instance;

        public static InstanceNetworkInterfaceUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceNetworkInterfaceUnmarshaller();

            return instance;
        }
    }
}
    
