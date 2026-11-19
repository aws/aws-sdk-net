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

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an explanation code for an unreachable path. For more information, see <a
    /// href="https://docs.aws.amazon.com/vpc/latest/reachability/explanation-codes.html">Reachability
    /// Analyzer explanation codes</a>.
    /// </summary>
    public partial class Explanation
    {
        /// <summary>
        /// Gets and sets the property Acl. 
        /// <para>
        /// The network ACL.
        /// </para>
        /// </summary>
        public AnalysisComponent Acl { get; set; }

        /// <summary>
        /// Checks to see if the Acl property is set.
        /// </summary>
        internal bool IsSetAcl() => this.Acl != null;

        /// <summary>
        /// Gets and sets the property AclRule. 
        /// <para>
        /// The network ACL rule.
        /// </para>
        /// </summary>
        public AnalysisAclRule AclRule { get; set; }

        /// <summary>
        /// Checks to see if the AclRule property is set.
        /// </summary>
        internal bool IsSetAclRule() => this.AclRule != null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The IPv4 address, in CIDR notation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// The IPv4 addresses, in CIDR notation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Addresses property is set.
        /// </summary>
        internal bool IsSetAddresses() => this.Addresses != null && (this.Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The resource to which the component is attached.
        /// </para>
        /// </summary>
        public AnalysisComponent AttachedTo { get; set; }

        /// <summary>
        /// Checks to see if the AttachedTo property is set.
        /// </summary>
        internal bool IsSetAttachedTo() => this.AttachedTo != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        /// The IDs of the Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZoneIds property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneIds() => this.AvailabilityZoneIds != null && (this.AvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// The CIDR ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Cidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Cidrs property is set.
        /// </summary>
        internal bool IsSetCidrs() => this.Cidrs != null && (this.Cidrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClassicLoadBalancerListener. 
        /// <para>
        /// The listener for a Classic Load Balancer.
        /// </para>
        /// </summary>
        public AnalysisLoadBalancerListener ClassicLoadBalancerListener { get; set; }

        /// <summary>
        /// Checks to see if the ClassicLoadBalancerListener property is set.
        /// </summary>
        internal bool IsSetClassicLoadBalancerListener() => this.ClassicLoadBalancerListener != null;

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The component.
        /// </para>
        /// </summary>
        public AnalysisComponent Component { get; set; }

        /// <summary>
        /// Checks to see if the Component property is set.
        /// </summary>
        internal bool IsSetComponent() => this.Component != null;

        /// <summary>
        /// Gets and sets the property ComponentAccount. 
        /// <para>
        /// The Amazon Web Services account for the component.
        /// </para>
        /// </summary>
        public string ComponentAccount { get; set; }

        /// <summary>
        /// Checks to see if the ComponentAccount property is set.
        /// </summary>
        internal bool IsSetComponentAccount() => this.ComponentAccount != null;

        /// <summary>
        /// Gets and sets the property ComponentRegion. 
        /// <para>
        /// The Region for the component.
        /// </para>
        /// </summary>
        public string ComponentRegion { get; set; }

        /// <summary>
        /// Checks to see if the ComponentRegion property is set.
        /// </summary>
        internal bool IsSetComponentRegion() => this.ComponentRegion != null;

        /// <summary>
        /// Gets and sets the property CustomerGateway. 
        /// <para>
        /// The customer gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent CustomerGateway { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGateway property is set.
        /// </summary>
        internal bool IsSetCustomerGateway() => this.CustomerGateway != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        public AnalysisComponent Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationVpc. 
        /// <para>
        /// The destination VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent DestinationVpc { get; set; }

        /// <summary>
        /// Checks to see if the DestinationVpc property is set.
        /// </summary>
        internal bool IsSetDestinationVpc() => this.DestinationVpc != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// egress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ingress
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property ElasticLoadBalancerListener. 
        /// <para>
        /// The load balancer listener.
        /// </para>
        /// </summary>
        public AnalysisComponent ElasticLoadBalancerListener { get; set; }

        /// <summary>
        /// Checks to see if the ElasticLoadBalancerListener property is set.
        /// </summary>
        internal bool IsSetElasticLoadBalancerListener() => this.ElasticLoadBalancerListener != null;

        /// <summary>
        /// Gets and sets the property ExplanationCode. 
        /// <para>
        /// The explanation code.
        /// </para>
        /// </summary>
        public string ExplanationCode { get; set; }

        /// <summary>
        /// Checks to see if the ExplanationCode property is set.
        /// </summary>
        internal bool IsSetExplanationCode() => this.ExplanationCode != null;

        /// <summary>
        /// Gets and sets the property FirewallStatefulRule. 
        /// <para>
        /// The Network Firewall stateful rule.
        /// </para>
        /// </summary>
        public FirewallStatefulRule FirewallStatefulRule { get; set; }

        /// <summary>
        /// Checks to see if the FirewallStatefulRule property is set.
        /// </summary>
        internal bool IsSetFirewallStatefulRule() => this.FirewallStatefulRule != null;

        /// <summary>
        /// Gets and sets the property FirewallStatelessRule. 
        /// <para>
        /// The Network Firewall stateless rule.
        /// </para>
        /// </summary>
        public FirewallStatelessRule FirewallStatelessRule { get; set; }

        /// <summary>
        /// Checks to see if the FirewallStatelessRule property is set.
        /// </summary>
        internal bool IsSetFirewallStatelessRule() => this.FirewallStatelessRule != null;

        /// <summary>
        /// Gets and sets the property IngressRouteTable. 
        /// <para>
        /// The route table.
        /// </para>
        /// </summary>
        public AnalysisComponent IngressRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the IngressRouteTable property is set.
        /// </summary>
        internal bool IsSetIngressRouteTable() => this.IngressRouteTable != null;

        /// <summary>
        /// Gets and sets the property InternetGateway. 
        /// <para>
        /// The internet gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent InternetGateway { get; set; }

        /// <summary>
        /// Checks to see if the InternetGateway property is set.
        /// </summary>
        internal bool IsSetInternetGateway() => this.InternetGateway != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string LoadBalancerArn { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerArn property is set.
        /// </summary>
        internal bool IsSetLoadBalancerArn() => this.LoadBalancerArn != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerListenerPort. 
        /// <para>
        /// The listener port of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? LoadBalancerListenerPort { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerListenerPort property is set.
        /// </summary>
        internal bool IsSetLoadBalancerListenerPort() => this.LoadBalancerListenerPort.HasValue;

        /// <summary>
        /// Gets and sets the property LoadBalancerTarget. 
        /// <para>
        /// The target.
        /// </para>
        /// </summary>
        public AnalysisLoadBalancerTarget LoadBalancerTarget { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerTarget property is set.
        /// </summary>
        internal bool IsSetLoadBalancerTarget() => this.LoadBalancerTarget != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetGroup. 
        /// <para>
        /// The target group.
        /// </para>
        /// </summary>
        public AnalysisComponent LoadBalancerTargetGroup { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerTargetGroup property is set.
        /// </summary>
        internal bool IsSetLoadBalancerTargetGroup() => this.LoadBalancerTargetGroup != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetGroups. 
        /// <para>
        /// The target groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisComponent> LoadBalancerTargetGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisComponent>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerTargetGroups property is set.
        /// </summary>
        internal bool IsSetLoadBalancerTargetGroups() => this.LoadBalancerTargetGroups != null && (this.LoadBalancerTargetGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetPort. 
        /// <para>
        /// The target port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? LoadBalancerTargetPort { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerTargetPort property is set.
        /// </summary>
        internal bool IsSetLoadBalancerTargetPort() => this.LoadBalancerTargetPort.HasValue;

        /// <summary>
        /// Gets and sets the property MissingComponent. 
        /// <para>
        /// The missing component.
        /// </para>
        /// </summary>
        public string MissingComponent { get; set; }

        /// <summary>
        /// Checks to see if the MissingComponent property is set.
        /// </summary>
        internal bool IsSetMissingComponent() => this.MissingComponent != null;

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// The NAT gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent NatGateway { get; set; }

        /// <summary>
        /// Checks to see if the NatGateway property is set.
        /// </summary>
        internal bool IsSetNatGateway() => this.NatGateway != null;

        /// <summary>
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// The network interface.
        /// </para>
        /// </summary>
        public AnalysisComponent NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterface property is set.
        /// </summary>
        internal bool IsSetNetworkInterface() => this.NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property PacketField. 
        /// <para>
        /// The packet field.
        /// </para>
        /// </summary>
        public string PacketField { get; set; }

        /// <summary>
        /// Checks to see if the PacketField property is set.
        /// </summary>
        internal bool IsSetPacketField() => this.PacketField != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The port ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> PortRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;

        /// <summary>
        /// Checks to see if the PortRanges property is set.
        /// </summary>
        internal bool IsSetPortRanges() => this.PortRanges != null && (this.PortRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrefixList. 
        /// <para>
        /// The prefix list.
        /// </para>
        /// </summary>
        public AnalysisComponent PrefixList { get; set; }

        /// <summary>
        /// Checks to see if the PrefixList property is set.
        /// </summary>
        internal bool IsSetPrefixList() => this.PrefixList != null;

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteTable. 
        /// <para>
        /// The route table.
        /// </para>
        /// </summary>
        public AnalysisComponent RouteTable { get; set; }

        /// <summary>
        /// Checks to see if the RouteTable property is set.
        /// </summary>
        internal bool IsSetRouteTable() => this.RouteTable != null;

        /// <summary>
        /// Gets and sets the property RouteTableRoute. 
        /// <para>
        /// The route table route.
        /// </para>
        /// </summary>
        public AnalysisRouteTableRoute RouteTableRoute { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableRoute property is set.
        /// </summary>
        internal bool IsSetRouteTableRoute() => this.RouteTableRoute != null;

        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// The security group.
        /// </para>
        /// </summary>
        public AnalysisComponent SecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroup property is set.
        /// </summary>
        internal bool IsSetSecurityGroup() => this.SecurityGroup != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupRule. 
        /// <para>
        /// The security group rule.
        /// </para>
        /// </summary>
        public AnalysisSecurityGroupRule SecurityGroupRule { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupRule property is set.
        /// </summary>
        internal bool IsSetSecurityGroupRule() => this.SecurityGroupRule != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnalysisComponent> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<AnalysisComponent>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceVpc. 
        /// <para>
        /// The source VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent SourceVpc { get; set; }

        /// <summary>
        /// Checks to see if the SourceVpc property is set.
        /// </summary>
        internal bool IsSetSourceVpc() => this.SourceVpc != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Subnet. 
        /// <para>
        /// The subnet.
        /// </para>
        /// </summary>
        public AnalysisComponent Subnet { get; set; }

        /// <summary>
        /// Checks to see if the Subnet property is set.
        /// </summary>
        internal bool IsSetSubnet() => this.Subnet != null;

        /// <summary>
        /// Gets and sets the property SubnetRouteTable. 
        /// <para>
        /// The route table for the subnet.
        /// </para>
        /// </summary>
        public AnalysisComponent SubnetRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the SubnetRouteTable property is set.
        /// </summary>
        internal bool IsSetSubnetRouteTable() => this.SubnetRouteTable != null;

        /// <summary>
        /// Gets and sets the property TransitGateway. 
        /// <para>
        /// The transit gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGateway { get; set; }

        /// <summary>
        /// Checks to see if the TransitGateway property is set.
        /// </summary>
        internal bool IsSetTransitGateway() => this.TransitGateway != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachment. 
        /// <para>
        /// The transit gateway attachment.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGatewayAttachment { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachment property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachment() => this.TransitGatewayAttachment != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayPolicyTable. 
        /// <para>
        /// The transit gateway policy table.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGatewayPolicyTable { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayPolicyTable property is set.
        /// </summary>
        internal bool IsSetTransitGatewayPolicyTable() => this.TransitGatewayPolicyTable != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayPolicyTableEntry. 
        /// <para>
        /// The transit gateway policy table entry.
        /// </para>
        /// </summary>
        public AnalysisTransitGatewayPolicyTableEntry TransitGatewayPolicyTableEntry { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayPolicyTableEntry property is set.
        /// </summary>
        internal bool IsSetTransitGatewayPolicyTableEntry() => this.TransitGatewayPolicyTableEntry != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTable. 
        /// <para>
        /// The transit gateway route table.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGatewayRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayRouteTable property is set.
        /// </summary>
        internal bool IsSetTransitGatewayRouteTable() => this.TransitGatewayRouteTable != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableRoute. 
        /// <para>
        /// The transit gateway route table route.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableRoute TransitGatewayRouteTableRoute { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayRouteTableRoute property is set.
        /// </summary>
        internal bool IsSetTransitGatewayRouteTableRoute() => this.TransitGatewayRouteTableRoute != null;

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The component VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;

        /// <summary>
        /// Gets and sets the property VpcEndpoint. 
        /// <para>
        /// The VPC endpoint.
        /// </para>
        /// </summary>
        public AnalysisComponent VpcEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpoint property is set.
        /// </summary>
        internal bool IsSetVpcEndpoint() => this.VpcEndpoint != null;

        /// <summary>
        /// Gets and sets the property VpcPeeringConnection. 
        /// <para>
        /// The VPC peering connection.
        /// </para>
        /// </summary>
        public AnalysisComponent VpcPeeringConnection { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeeringConnection property is set.
        /// </summary>
        internal bool IsSetVpcPeeringConnection() => this.VpcPeeringConnection != null;

        /// <summary>
        /// Gets and sets the property VpnConnection. 
        /// <para>
        /// The VPN connection.
        /// </para>
        /// </summary>
        public AnalysisComponent VpnConnection { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnection property is set.
        /// </summary>
        internal bool IsSetVpnConnection() => this.VpnConnection != null;

        /// <summary>
        /// Gets and sets the property VpnGateway. 
        /// <para>
        /// The VPN gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent VpnGateway { get; set; }

        /// <summary>
        /// Checks to see if the VpnGateway property is set.
        /// </summary>
        internal bool IsSetVpnGateway() => this.VpnGateway != null;
    }
}
