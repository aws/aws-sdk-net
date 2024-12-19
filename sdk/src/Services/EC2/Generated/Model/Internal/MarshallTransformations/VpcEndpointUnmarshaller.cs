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
    /// Response Unmarshaller for VpcEndpoint Object
    /// </summary>  
    public class VpcEndpointUnmarshaller : IXmlUnmarshaller<VpcEndpoint, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcEndpoint Unmarshall(XmlUnmarshallerContext context)
        {
            VpcEndpoint unmarshalledObject = new VpcEndpoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("creationTimestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dnsEntrySet/item", targetDepth))
                    {
                        var unmarshaller = DnsEntryUnmarshaller.Instance;
                        if (unmarshalledObject.DnsEntries == null)
                        {
                            unmarshalledObject.DnsEntries = new List<DnsEntry>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DnsEntries.Add(item);
                        continue;
                    }
                    if (context.TestExpression("dnsOptions", targetDepth))
                    {
                        var unmarshaller = DnsOptionsUnmarshaller.Instance;
                        unmarshalledObject.DnsOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        var unmarshaller = SecurityGroupIdentifierUnmarshaller.Instance;
                        if (unmarshalledObject.Groups == null)
                        {
                            unmarshalledObject.Groups = new List<SecurityGroupIdentifier>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Groups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ipAddressType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpAddressType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastError", targetDepth))
                    {
                        var unmarshaller = LastErrorUnmarshaller.Instance;
                        unmarshalledObject.LastError = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceIdSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.NetworkInterfaceIds == null)
                        {
                            unmarshalledObject.NetworkInterfaceIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkInterfaceIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("policyDocument", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PolicyDocument = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("requesterManaged", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequesterManaged = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeTableIdSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.RouteTableIds == null)
                        {
                            unmarshalledObject.RouteTableIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RouteTableIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("serviceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetIdSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SubnetIds == null)
                        {
                            unmarshalledObject.SubnetIds = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SubnetIds.Add(item);
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
                    if (context.TestExpression("vpcEndpointId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcEndpointType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointType = unmarshaller.Unmarshall(context);
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

        private static VpcEndpointUnmarshaller _instance = new VpcEndpointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcEndpointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}