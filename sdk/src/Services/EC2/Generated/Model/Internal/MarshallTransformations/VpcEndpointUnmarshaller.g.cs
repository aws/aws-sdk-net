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
    /// Response Unmarshaller for VpcEndpoint Object
    /// </summary>
    public partial class VpcEndpointUnmarshaller : IXmlUnmarshaller<VpcEndpoint, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public VpcEndpoint Unmarshall(XmlUnmarshallerContext context)
        {
            VpcEndpoint unmarshalledObject = new VpcEndpoint();
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
                    if (context.TestExpression("creationTimestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("dnsEntrySet/item", targetDepth))
                    {
                        if (unmarshalledObject.DnsEntries == null)
                        {
                            unmarshalledObject.DnsEntries = new List<DnsEntry>();
                        }
                        var unmarshaller = DnsEntryUnmarshaller.Instance;
                        unmarshalledObject.DnsEntries.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("dnsOptions", targetDepth))
                    {
                        var unmarshaller = DnsOptionsUnmarshaller.Instance;
                        unmarshalledObject.DnsOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("failureReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Groups == null)
                        {
                            unmarshalledObject.Groups = new List<SecurityGroupIdentifier>();
                        }
                        var unmarshaller = SecurityGroupIdentifierUnmarshaller.Instance;
                        unmarshalledObject.Groups.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ipAddressType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpAddressType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv4PrefixSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv4Prefixes == null)
                        {
                            unmarshalledObject.Ipv4Prefixes = new List<SubnetIpPrefixes>();
                        }
                        var unmarshaller = SubnetIpPrefixesUnmarshaller.Instance;
                        unmarshalledObject.Ipv4Prefixes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ipv6PrefixSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv6Prefixes == null)
                        {
                            unmarshalledObject.Ipv6Prefixes = new List<SubnetIpPrefixes>();
                        }
                        var unmarshaller = SubnetIpPrefixesUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Prefixes.Add(unmarshaller.Unmarshall(context));
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
                        if (unmarshalledObject.NetworkInterfaceIds == null)
                        {
                            unmarshalledObject.NetworkInterfaceIds = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("payerResponsibilitySet/item", targetDepth))
                    {
                        if (unmarshalledObject.PayerResponsibilities == null)
                        {
                            unmarshalledObject.PayerResponsibilities = new List<PayerResponsibilityEntry>();
                        }
                        var unmarshaller = PayerResponsibilityEntryUnmarshaller.Instance;
                        unmarshalledObject.PayerResponsibilities.Add(unmarshaller.Unmarshall(context));
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

                    if (context.TestExpression("resourceConfigurationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceConfigurationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("routeTableIdSet/item", targetDepth))
                    {
                        if (unmarshalledObject.RouteTableIds == null)
                        {
                            unmarshalledObject.RouteTableIds = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RouteTableIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("serviceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("serviceNetworkArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceNetworkArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("serviceRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceRegion = unmarshaller.Unmarshall(context);
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
                        if (unmarshalledObject.SubnetIds == null)
                        {
                            unmarshalledObject.SubnetIds = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
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
        public static VpcEndpointUnmarshaller Instance => _instance;
    }
}
