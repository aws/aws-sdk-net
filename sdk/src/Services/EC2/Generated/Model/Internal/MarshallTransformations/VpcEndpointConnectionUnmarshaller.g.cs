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
    /// Response Unmarshaller for VpcEndpointConnection Object
    /// </summary>
    public partial class VpcEndpointConnectionUnmarshaller : IXmlUnmarshaller<VpcEndpointConnection, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public VpcEndpointConnection Unmarshall(XmlUnmarshallerContext context)
        {
            VpcEndpointConnection unmarshalledObject = new VpcEndpointConnection();
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

                    if (context.TestExpression("gatewayLoadBalancerArnSet/item", targetDepth))
                    {
                        if (unmarshalledObject.GatewayLoadBalancerArns == null)
                        {
                            unmarshalledObject.GatewayLoadBalancerArns = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GatewayLoadBalancerArns.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ipAddressType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpAddressType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkLoadBalancerArnSet/item", targetDepth))
                    {
                        if (unmarshalledObject.NetworkLoadBalancerArns == null)
                        {
                            unmarshalledObject.NetworkLoadBalancerArns = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkLoadBalancerArns.Add(unmarshaller.Unmarshall(context));
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

                    if (context.TestExpression("serviceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceId = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("vpcEndpointConnectionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointConnectionId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("vpcEndpointId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("vpcEndpointOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("vpcEndpointRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("vpcEndpointState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpointState = unmarshaller.Unmarshall(context);
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

        private static VpcEndpointConnectionUnmarshaller _instance = new VpcEndpointConnectionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static VpcEndpointConnectionUnmarshaller Instance => _instance;
    }
}
