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
    /// Response Unmarshaller for Subnet Object
    /// </summary>  
    public class SubnetUnmarshaller : IXmlUnmarshaller<Subnet, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Subnet Unmarshall(XmlUnmarshallerContext context)
        {
            Subnet unmarshalledObject = new Subnet();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("assignIpv6AddressOnCreation", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AssignIpv6AddressOnCreation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availabilityZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availableIpAddressCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AvailableIpAddressCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CidrBlock = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("customerOwnedIpv4Pool", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CustomerOwnedIpv4Pool = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("defaultForAz", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DefaultForAz = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enableDns64", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnableDns64 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enableLniAtDeviceIndex", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.EnableLniAtDeviceIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6CidrBlockAssociationSet/item", targetDepth))
                    {
                        var unmarshaller = SubnetIpv6CidrBlockAssociationUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv6CidrBlockAssociationSet == null)
                        {
                            unmarshalledObject.Ipv6CidrBlockAssociationSet = new List<SubnetIpv6CidrBlockAssociation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv6CidrBlockAssociationSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ipv6Native", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Native = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("mapCustomerOwnedIpOnLaunch", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.MapCustomerOwnedIpOnLaunch = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("mapPublicIpOnLaunch", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.MapPublicIpOnLaunch = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("privateDnsNameOptionsOnLaunch", targetDepth))
                    {
                        var unmarshaller = PrivateDnsNameOptionsOnLaunchUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsNameOptionsOnLaunch = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetArn = unmarshaller.Unmarshall(context);
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
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
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

        private static SubnetUnmarshaller _instance = new SubnetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubnetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}