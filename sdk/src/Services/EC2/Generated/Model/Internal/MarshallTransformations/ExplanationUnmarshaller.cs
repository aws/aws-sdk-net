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
    /// Response Unmarshaller for Explanation Object
    /// </summary>  
    public class ExplanationUnmarshaller : IXmlUnmarshaller<Explanation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Explanation Unmarshall(XmlUnmarshallerContext context)
        {
            Explanation unmarshalledObject = new Explanation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("acl", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Acl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("aclRule", targetDepth))
                    {
                        var unmarshaller = AnalysisAclRuleUnmarshaller.Instance;
                        unmarshalledObject.AclRule = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("address", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("addressSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Addresses == null)
                        {
                            unmarshalledObject.Addresses = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Addresses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("attachedTo", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.AttachedTo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("availabilityZoneSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("cidrSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Cidrs == null)
                        {
                            unmarshalledObject.Cidrs = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Cidrs.Add(item);
                        continue;
                    }
                    if (context.TestExpression("classicLoadBalancerListener", targetDepth))
                    {
                        var unmarshaller = AnalysisLoadBalancerListenerUnmarshaller.Instance;
                        unmarshalledObject.ClassicLoadBalancerListener = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("component", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Component = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("componentAccount", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ComponentAccount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("componentRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ComponentRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("customerGateway", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.CustomerGateway = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destination", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationVpc", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.DestinationVpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("direction", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Direction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("elasticLoadBalancerListener", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.ElasticLoadBalancerListener = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("explanationCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExplanationCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("firewallStatefulRule", targetDepth))
                    {
                        var unmarshaller = FirewallStatefulRuleUnmarshaller.Instance;
                        unmarshalledObject.FirewallStatefulRule = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("firewallStatelessRule", targetDepth))
                    {
                        var unmarshaller = FirewallStatelessRuleUnmarshaller.Instance;
                        unmarshalledObject.FirewallStatelessRule = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ingressRouteTable", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.IngressRouteTable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("internetGateway", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.InternetGateway = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("loadBalancerArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("loadBalancerListenerPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerListenerPort = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("loadBalancerTarget", targetDepth))
                    {
                        var unmarshaller = AnalysisLoadBalancerTargetUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerTarget = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("loadBalancerTargetGroup", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerTargetGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("loadBalancerTargetGroupSet/item", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        if (unmarshalledObject.LoadBalancerTargetGroups == null)
                        {
                            unmarshalledObject.LoadBalancerTargetGroups = new List<AnalysisComponent>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LoadBalancerTargetGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("loadBalancerTargetPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerTargetPort = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("missingComponent", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MissingComponent = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("natGateway", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.NatGateway = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterface", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterface = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("packetField", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PacketField = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("portRangeSet/item", targetDepth))
                    {
                        var unmarshaller = PortRangeUnmarshaller.Instance;
                        if (unmarshalledObject.PortRanges == null)
                        {
                            unmarshalledObject.PortRanges = new List<PortRange>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PortRanges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("prefixList", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.PrefixList = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("protocolSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Protocols == null)
                        {
                            unmarshalledObject.Protocols = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Protocols.Add(item);
                        continue;
                    }
                    if (context.TestExpression("routeTable", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.RouteTable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeTableRoute", targetDepth))
                    {
                        var unmarshaller = AnalysisRouteTableRouteUnmarshaller.Instance;
                        unmarshalledObject.RouteTableRoute = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroup", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.SecurityGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroupRule", targetDepth))
                    {
                        var unmarshaller = AnalysisSecurityGroupRuleUnmarshaller.Instance;
                        unmarshalledObject.SecurityGroupRule = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroupSet/item", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        if (unmarshalledObject.SecurityGroups == null)
                        {
                            unmarshalledObject.SecurityGroups = new List<AnalysisComponent>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("sourceVpc", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.SourceVpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnet", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Subnet = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetRouteTable", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.SubnetRouteTable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transitGateway", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.TransitGateway = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transitGatewayAttachment", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayAttachment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transitGatewayRouteTable", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayRouteTable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transitGatewayRouteTableRoute", targetDepth))
                    {
                        var unmarshaller = TransitGatewayRouteTableRouteUnmarshaller.Instance;
                        unmarshalledObject.TransitGatewayRouteTableRoute = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpc", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcEndpoint", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.VpcEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcPeeringConnection", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.VpcPeeringConnection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpnConnection", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.VpnConnection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpnGateway", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.VpnGateway = unmarshaller.Unmarshall(context);
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

        private static ExplanationUnmarshaller _instance = new ExplanationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExplanationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}