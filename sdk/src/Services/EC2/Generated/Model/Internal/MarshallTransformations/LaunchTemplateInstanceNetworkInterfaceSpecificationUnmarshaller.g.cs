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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchTemplateInstanceNetworkInterfaceSpecification Object
    /// </summary>
    public partial class LaunchTemplateInstanceNetworkInterfaceSpecificationUnmarshaller : IXmlUnmarshaller<LaunchTemplateInstanceNetworkInterfaceSpecification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public LaunchTemplateInstanceNetworkInterfaceSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            LaunchTemplateInstanceNetworkInterfaceSpecification unmarshalledObject = new LaunchTemplateInstanceNetworkInterfaceSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("associateCarrierIpAddress", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AssociateCarrierIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("associatePublicIpAddress", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AssociatePublicIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("connectionTrackingSpecification", targetDepth))
                    {
                        var unmarshaller = ConnectionTrackingSpecificationUnmarshaller.Instance;
                        unmarshalledObject.ConnectionTrackingSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("deleteOnTermination", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
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
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DeviceIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("enaQueueCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.EnaQueueCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("enaSrdSpecification", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateEnaSrdSpecificationUnmarshaller.Instance;
                        unmarshalledObject.EnaSrdSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("groupSet/groupId", targetDepth))
                    {
                        if (unmarshalledObject.Groups == null)
                        {
                            unmarshalledObject.Groups = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Groups.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("interfaceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InterfaceType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv4PrefixCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv4PrefixCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv4PrefixSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv4Prefixes == null)
                        {
                            unmarshalledObject.Ipv4Prefixes = new List<Ipv4PrefixSpecificationResponse>();
                        }
                        var unmarshaller = Ipv4PrefixSpecificationResponseUnmarshaller.Instance;
                        unmarshalledObject.Ipv4Prefixes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ipv6AddressCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv6AddressCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv6AddressesSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv6Addresses == null)
                        {
                            unmarshalledObject.Ipv6Addresses = new List<InstanceIpv6Address>();
                        }
                        var unmarshaller = InstanceIpv6AddressUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Addresses.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ipv6PrefixCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv6PrefixCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv6PrefixSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv6Prefixes == null)
                        {
                            unmarshalledObject.Ipv6Prefixes = new List<Ipv6PrefixSpecificationResponse>();
                        }
                        var unmarshaller = Ipv6PrefixSpecificationResponseUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Prefixes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("networkCardIndex", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.NetworkCardIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("primaryIpv6", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.PrimaryIpv6 = unmarshaller.Unmarshall(context);
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
                        if (unmarshalledObject.PrivateIpAddresses == null)
                        {
                            unmarshalledObject.PrivateIpAddresses = new List<PrivateIpAddressSpecification>();
                        }
                        var unmarshaller = PrivateIpAddressSpecificationUnmarshaller.Instance;
                        unmarshalledObject.PrivateIpAddresses.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("secondaryPrivateIpAddressCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
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

        private static LaunchTemplateInstanceNetworkInterfaceSpecificationUnmarshaller _instance = new LaunchTemplateInstanceNetworkInterfaceSpecificationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static LaunchTemplateInstanceNetworkInterfaceSpecificationUnmarshaller Instance => _instance;
    }
}
