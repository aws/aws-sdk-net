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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkInterface Object
    /// </summary>  
    public class NetworkInterfaceUnmarshaller : IXmlUnmarshaller<NetworkInterface, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkInterface Unmarshall(XmlUnmarshallerContext context)
        {
            NetworkInterface unmarshalledObject = new NetworkInterface();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("association", targetDepth))
                    {
                        var unmarshaller = NetworkInterfaceAssociationUnmarshaller.Instance;
                        unmarshalledObject.Association = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("attachment", targetDepth))
                    {
                        var unmarshaller = NetworkInterfaceAttachmentUnmarshaller.Instance;
                        unmarshalledObject.Attachment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("connectionTrackingConfiguration", targetDepth))
                    {
                        var unmarshaller = ConnectionTrackingConfigurationUnmarshaller.Instance;
                        unmarshalledObject.ConnectionTrackingConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("denyAllIgwTraffic", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DenyAllIgwTraffic = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        var unmarshaller = GroupIdentifierUnmarshaller.Instance;
                        if (unmarshalledObject.Groups == null)
                        {
                            unmarshalledObject.Groups = new List<GroupIdentifier>();
                        }
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
                    if (context.TestExpression("ipv4PrefixSet/item", targetDepth))
                    {
                        var unmarshaller = Ipv4PrefixSpecificationUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv4Prefixes == null)
                        {
                            unmarshalledObject.Ipv4Prefixes = new List<Ipv4PrefixSpecification>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv4Prefixes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ipv6Address", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Address = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6AddressesSet/item", targetDepth))
                    {
                        var unmarshaller = NetworkInterfaceIpv6AddressUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv6Addresses == null)
                        {
                            unmarshalledObject.Ipv6Addresses = new List<NetworkInterfaceIpv6Address>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv6Addresses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ipv6Native", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Native = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6PrefixSet/item", targetDepth))
                    {
                        var unmarshaller = Ipv6PrefixSpecificationUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv6Prefixes == null)
                        {
                            unmarshalledObject.Ipv6Prefixes = new List<Ipv6PrefixSpecification>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv6Prefixes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("macAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MacAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsName = unmarshaller.Unmarshall(context);
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
                        var unmarshaller = NetworkInterfacePrivateIpAddressUnmarshaller.Instance;
                        if (unmarshalledObject.PrivateIpAddresses == null)
                        {
                            unmarshalledObject.PrivateIpAddresses = new List<NetworkInterfacePrivateIpAddress>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PrivateIpAddresses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("requesterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RequesterId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("requesterManaged", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequesterManaged = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceDestCheck", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SourceDestCheck = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.TagSet == null)
                        {
                            unmarshalledObject.TagSet = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TagSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static NetworkInterfaceUnmarshaller _instance = new NetworkInterfaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkInterfaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}