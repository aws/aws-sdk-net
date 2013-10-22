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
     ///   InstanceNetworkInterfaceSpecification Unmarshaller
     /// </summary>
    internal class InstanceNetworkInterfaceSpecificationUnmarshaller : IUnmarshaller<InstanceNetworkInterfaceSpecification, XmlUnmarshallerContext>, IUnmarshaller<InstanceNetworkInterfaceSpecification, JsonUnmarshallerContext> 
    {
        public InstanceNetworkInterfaceSpecification Unmarshall(XmlUnmarshallerContext context) 
        {
            InstanceNetworkInterfaceSpecification instanceNetworkInterfaceSpecification = new InstanceNetworkInterfaceSpecification();
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
                        instanceNetworkInterfaceSpecification.NetworkInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("deviceIndex", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.DeviceIndex = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateIpAddress", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.PrivateIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupSet/item/groupId", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.Groups.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("deleteOnTermination", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.DeleteOnTermination = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateIpAddressesSet/item", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.PrivateIpAddresses.Add(PrivateIpAddressSpecificationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("secondaryPrivateIpAddressCount", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.SecondaryPrivateIpAddressCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("associatePublicIpAddress", targetDepth))
                    {
                        instanceNetworkInterfaceSpecification.AssociatePublicIpAddress = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceNetworkInterfaceSpecification;
                }
            }
                        


            return instanceNetworkInterfaceSpecification;
        }

        public InstanceNetworkInterfaceSpecification Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceNetworkInterfaceSpecificationUnmarshaller instance;

        public static InstanceNetworkInterfaceSpecificationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceNetworkInterfaceSpecificationUnmarshaller();

            return instance;
        }
    }
}
    
