/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceNetworkInterfaceSpecification Object
    /// </summary>  
    public class InstanceNetworkInterfaceSpecificationUnmarshaller : IUnmarshaller<InstanceNetworkInterfaceSpecification, XmlUnmarshallerContext>, IUnmarshaller<InstanceNetworkInterfaceSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceNetworkInterfaceSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceNetworkInterfaceSpecification unmarshalledObject = new InstanceNetworkInterfaceSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("associateCarrierIpAddress", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AssociateCarrierIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("associatePublicIpAddress", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deleteOnTermination", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.DeleteOnTermination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deviceIndex", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.DeviceIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroupId/SecurityGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Groups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("interfaceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InterfaceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6AddressCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Ipv6AddressCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6AddressesSet/item", targetDepth))
                    {
                        var unmarshaller = InstanceIpv6AddressUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv6Addresses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkCardIndex", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.NetworkCardIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateIpAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateIpAddressesSet/item", targetDepth))
                    {
                        var unmarshaller = PrivateIpAddressSpecificationUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PrivateIpAddresses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("secondaryPrivateIpAddressCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SecondaryPrivateIpAddressCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceNetworkInterfaceSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static InstanceNetworkInterfaceSpecificationUnmarshaller _instance = new InstanceNetworkInterfaceSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceNetworkInterfaceSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}