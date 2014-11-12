/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Response Unmarshaller for NetworkInterface Object
    /// </summary>  
    public class NetworkInterfaceUnmarshaller : IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<NetworkInterface, JsonUnmarshallerContext>
    {
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
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        var unmarshaller = GroupIdentifierUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Groups.Add(item);
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
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.RequesterManaged = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceDestCheck", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
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

        public NetworkInterface Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static NetworkInterfaceUnmarshaller _instance = new NetworkInterfaceUnmarshaller();        

        public static NetworkInterfaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}