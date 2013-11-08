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
     ///   Address Unmarshaller
     /// </summary>
    internal class AddressUnmarshaller : IUnmarshaller<Address, XmlUnmarshallerContext>, IUnmarshaller<Address, JsonUnmarshallerContext> 
    {
        public Address Unmarshall(XmlUnmarshallerContext context) 
        {
            Address address = new Address();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        address.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("publicIp", targetDepth))
                    {
                        address.PublicIp = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("allocationId", targetDepth))
                    {
                        address.AllocationId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("associationId", targetDepth))
                    {
                        address.AssociationId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("domain", targetDepth))
                    {
                        address.Domain = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        address.NetworkInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceOwnerId", targetDepth))
                    {
                        address.NetworkInterfaceOwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("privateIpAddress", targetDepth))
                    {
                        address.PrivateIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return address;
                }
            }
                        


            return address;
        }

        public Address Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AddressUnmarshaller instance;

        public static AddressUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AddressUnmarshaller();

            return instance;
        }
    }
}
    
