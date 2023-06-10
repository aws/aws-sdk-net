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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an explanation code for an unreachable path. For more information, see <a
    /// href="https://docs.aws.amazon.com/vpc/latest/reachability/explanation-codes.html">Reachability
    /// Analyzer explanation codes</a>.
    /// </summary>
    public partial class Explanation
    {
        private AnalysisComponent _acl;
        private AnalysisAclRule _aclRule;
        private string _address;
        private List<string> _addresses = new List<string>();
        private AnalysisComponent _attachedTo;
        private List<string> _availabilityZones = new List<string>();
        private List<string> _cidrs = new List<string>();
        private AnalysisLoadBalancerListener _classicLoadBalancerListener;
        private AnalysisComponent _component;
        private string _componentAccount;
        private string _componentRegion;
        private AnalysisComponent _customerGateway;
        private AnalysisComponent _destination;
        private AnalysisComponent _destinationVpc;
        private string _direction;
        private AnalysisComponent _elasticLoadBalancerListener;
        private string _explanationCode;
        private FirewallStatefulRule _firewallStatefulRule;
        private FirewallStatelessRule _firewallStatelessRule;
        private AnalysisComponent _ingressRouteTable;
        private AnalysisComponent _internetGateway;
        private string _loadBalancerArn;
        private int? _loadBalancerListenerPort;
        private AnalysisLoadBalancerTarget _loadBalancerTarget;
        private AnalysisComponent _loadBalancerTargetGroup;
        private List<AnalysisComponent> _loadBalancerTargetGroups = new List<AnalysisComponent>();
        private int? _loadBalancerTargetPort;
        private string _missingComponent;
        private AnalysisComponent _natGateway;
        private AnalysisComponent _networkInterface;
        private string _packetField;
        private int? _port;
        private List<PortRange> _portRanges = new List<PortRange>();
        private AnalysisComponent _prefixList;
        private List<string> _protocols = new List<string>();
        private AnalysisComponent _routeTable;
        private AnalysisRouteTableRoute _routeTableRoute;
        private AnalysisComponent _securityGroup;
        private AnalysisSecurityGroupRule _securityGroupRule;
        private List<AnalysisComponent> _securityGroups = new List<AnalysisComponent>();
        private AnalysisComponent _sourceVpc;
        private string _state;
        private AnalysisComponent _subnet;
        private AnalysisComponent _subnetRouteTable;
        private AnalysisComponent _transitGateway;
        private AnalysisComponent _transitGatewayAttachment;
        private AnalysisComponent _transitGatewayRouteTable;
        private TransitGatewayRouteTableRoute _transitGatewayRouteTableRoute;
        private AnalysisComponent _vpc;
        private AnalysisComponent _vpcEndpoint;
        private AnalysisComponent _vpcPeeringConnection;
        private AnalysisComponent _vpnConnection;
        private AnalysisComponent _vpnGateway;

        /// <summary>
        /// Gets and sets the property Acl. 
        /// <para>
        /// The network ACL.
        /// </para>
        /// </summary>
        public AnalysisComponent Acl
        {
            get { return this._acl; }
            set { this._acl = value; }
        }

        // Check to see if Acl property is set
        internal bool IsSetAcl()
        {
            return this._acl != null;
        }

        /// <summary>
        /// Gets and sets the property AclRule. 
        /// <para>
        /// The network ACL rule.
        /// </para>
        /// </summary>
        public AnalysisAclRule AclRule
        {
            get { return this._aclRule; }
            set { this._aclRule = value; }
        }

        // Check to see if AclRule property is set
        internal bool IsSetAclRule()
        {
            return this._aclRule != null;
        }

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The IPv4 address, in CIDR notation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// The IPv4 addresses, in CIDR notation.
        /// </para>
        /// </summary>
        public List<string> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this._addresses != null && this._addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The resource to which the component is attached.
        /// </para>
        /// </summary>
        public AnalysisComponent AttachedTo
        {
            get { return this._attachedTo; }
            set { this._attachedTo = value; }
        }

        // Check to see if AttachedTo property is set
        internal bool IsSetAttachedTo()
        {
            return this._attachedTo != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// The CIDR ranges.
        /// </para>
        /// </summary>
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && this._cidrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClassicLoadBalancerListener. 
        /// <para>
        /// The listener for a Classic Load Balancer.
        /// </para>
        /// </summary>
        public AnalysisLoadBalancerListener ClassicLoadBalancerListener
        {
            get { return this._classicLoadBalancerListener; }
            set { this._classicLoadBalancerListener = value; }
        }

        // Check to see if ClassicLoadBalancerListener property is set
        internal bool IsSetClassicLoadBalancerListener()
        {
            return this._classicLoadBalancerListener != null;
        }

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The component.
        /// </para>
        /// </summary>
        public AnalysisComponent Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentAccount. 
        /// <para>
        /// The Amazon Web Services account for the component.
        /// </para>
        /// </summary>
        public string ComponentAccount
        {
            get { return this._componentAccount; }
            set { this._componentAccount = value; }
        }

        // Check to see if ComponentAccount property is set
        internal bool IsSetComponentAccount()
        {
            return this._componentAccount != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentRegion. 
        /// <para>
        /// The Region for the component.
        /// </para>
        /// </summary>
        public string ComponentRegion
        {
            get { return this._componentRegion; }
            set { this._componentRegion = value; }
        }

        // Check to see if ComponentRegion property is set
        internal bool IsSetComponentRegion()
        {
            return this._componentRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerGateway. 
        /// <para>
        /// The customer gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent CustomerGateway
        {
            get { return this._customerGateway; }
            set { this._customerGateway = value; }
        }

        // Check to see if CustomerGateway property is set
        internal bool IsSetCustomerGateway()
        {
            return this._customerGateway != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        public AnalysisComponent Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationVpc. 
        /// <para>
        /// The destination VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent DestinationVpc
        {
            get { return this._destinationVpc; }
            set { this._destinationVpc = value; }
        }

        // Check to see if DestinationVpc property is set
        internal bool IsSetDestinationVpc()
        {
            return this._destinationVpc != null;
        }

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
        public string Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticLoadBalancerListener. 
        /// <para>
        /// The load balancer listener.
        /// </para>
        /// </summary>
        public AnalysisComponent ElasticLoadBalancerListener
        {
            get { return this._elasticLoadBalancerListener; }
            set { this._elasticLoadBalancerListener = value; }
        }

        // Check to see if ElasticLoadBalancerListener property is set
        internal bool IsSetElasticLoadBalancerListener()
        {
            return this._elasticLoadBalancerListener != null;
        }

        /// <summary>
        /// Gets and sets the property ExplanationCode. 
        /// <para>
        /// The explanation code.
        /// </para>
        /// </summary>
        public string ExplanationCode
        {
            get { return this._explanationCode; }
            set { this._explanationCode = value; }
        }

        // Check to see if ExplanationCode property is set
        internal bool IsSetExplanationCode()
        {
            return this._explanationCode != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallStatefulRule. 
        /// <para>
        /// The Network Firewall stateful rule.
        /// </para>
        /// </summary>
        public FirewallStatefulRule FirewallStatefulRule
        {
            get { return this._firewallStatefulRule; }
            set { this._firewallStatefulRule = value; }
        }

        // Check to see if FirewallStatefulRule property is set
        internal bool IsSetFirewallStatefulRule()
        {
            return this._firewallStatefulRule != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallStatelessRule. 
        /// <para>
        /// The Network Firewall stateless rule.
        /// </para>
        /// </summary>
        public FirewallStatelessRule FirewallStatelessRule
        {
            get { return this._firewallStatelessRule; }
            set { this._firewallStatelessRule = value; }
        }

        // Check to see if FirewallStatelessRule property is set
        internal bool IsSetFirewallStatelessRule()
        {
            return this._firewallStatelessRule != null;
        }

        /// <summary>
        /// Gets and sets the property IngressRouteTable. 
        /// <para>
        /// The route table.
        /// </para>
        /// </summary>
        public AnalysisComponent IngressRouteTable
        {
            get { return this._ingressRouteTable; }
            set { this._ingressRouteTable = value; }
        }

        // Check to see if IngressRouteTable property is set
        internal bool IsSetIngressRouteTable()
        {
            return this._ingressRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property InternetGateway. 
        /// <para>
        /// The internet gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent InternetGateway
        {
            get { return this._internetGateway; }
            set { this._internetGateway = value; }
        }

        // Check to see if InternetGateway property is set
        internal bool IsSetInternetGateway()
        {
            return this._internetGateway != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerListenerPort. 
        /// <para>
        /// The listener port of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int LoadBalancerListenerPort
        {
            get { return this._loadBalancerListenerPort.GetValueOrDefault(); }
            set { this._loadBalancerListenerPort = value; }
        }

        // Check to see if LoadBalancerListenerPort property is set
        internal bool IsSetLoadBalancerListenerPort()
        {
            return this._loadBalancerListenerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerTarget. 
        /// <para>
        /// The target.
        /// </para>
        /// </summary>
        public AnalysisLoadBalancerTarget LoadBalancerTarget
        {
            get { return this._loadBalancerTarget; }
            set { this._loadBalancerTarget = value; }
        }

        // Check to see if LoadBalancerTarget property is set
        internal bool IsSetLoadBalancerTarget()
        {
            return this._loadBalancerTarget != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetGroup. 
        /// <para>
        /// The target group.
        /// </para>
        /// </summary>
        public AnalysisComponent LoadBalancerTargetGroup
        {
            get { return this._loadBalancerTargetGroup; }
            set { this._loadBalancerTargetGroup = value; }
        }

        // Check to see if LoadBalancerTargetGroup property is set
        internal bool IsSetLoadBalancerTargetGroup()
        {
            return this._loadBalancerTargetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetGroups. 
        /// <para>
        /// The target groups.
        /// </para>
        /// </summary>
        public List<AnalysisComponent> LoadBalancerTargetGroups
        {
            get { return this._loadBalancerTargetGroups; }
            set { this._loadBalancerTargetGroups = value; }
        }

        // Check to see if LoadBalancerTargetGroups property is set
        internal bool IsSetLoadBalancerTargetGroups()
        {
            return this._loadBalancerTargetGroups != null && this._loadBalancerTargetGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerTargetPort. 
        /// <para>
        /// The target port.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int LoadBalancerTargetPort
        {
            get { return this._loadBalancerTargetPort.GetValueOrDefault(); }
            set { this._loadBalancerTargetPort = value; }
        }

        // Check to see if LoadBalancerTargetPort property is set
        internal bool IsSetLoadBalancerTargetPort()
        {
            return this._loadBalancerTargetPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissingComponent. 
        /// <para>
        /// The missing component.
        /// </para>
        /// </summary>
        public string MissingComponent
        {
            get { return this._missingComponent; }
            set { this._missingComponent = value; }
        }

        // Check to see if MissingComponent property is set
        internal bool IsSetMissingComponent()
        {
            return this._missingComponent != null;
        }

        /// <summary>
        /// Gets and sets the property NatGateway. 
        /// <para>
        /// The NAT gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent NatGateway
        {
            get { return this._natGateway; }
            set { this._natGateway = value; }
        }

        // Check to see if NatGateway property is set
        internal bool IsSetNatGateway()
        {
            return this._natGateway != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// The network interface.
        /// </para>
        /// </summary>
        public AnalysisComponent NetworkInterface
        {
            get { return this._networkInterface; }
            set { this._networkInterface = value; }
        }

        // Check to see if NetworkInterface property is set
        internal bool IsSetNetworkInterface()
        {
            return this._networkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property PacketField. 
        /// <para>
        /// The packet field.
        /// </para>
        /// </summary>
        public string PacketField
        {
            get { return this._packetField; }
            set { this._packetField = value; }
        }

        // Check to see if PacketField property is set
        internal bool IsSetPacketField()
        {
            return this._packetField != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The port ranges.
        /// </para>
        /// </summary>
        public List<PortRange> PortRanges
        {
            get { return this._portRanges; }
            set { this._portRanges = value; }
        }

        // Check to see if PortRanges property is set
        internal bool IsSetPortRanges()
        {
            return this._portRanges != null && this._portRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrefixList. 
        /// <para>
        /// The prefix list.
        /// </para>
        /// </summary>
        public AnalysisComponent PrefixList
        {
            get { return this._prefixList; }
            set { this._prefixList = value; }
        }

        // Check to see if PrefixList property is set
        internal bool IsSetPrefixList()
        {
            return this._prefixList != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols.
        /// </para>
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RouteTable. 
        /// <para>
        /// The route table.
        /// </para>
        /// </summary>
        public AnalysisComponent RouteTable
        {
            get { return this._routeTable; }
            set { this._routeTable = value; }
        }

        // Check to see if RouteTable property is set
        internal bool IsSetRouteTable()
        {
            return this._routeTable != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableRoute. 
        /// <para>
        /// The route table route.
        /// </para>
        /// </summary>
        public AnalysisRouteTableRoute RouteTableRoute
        {
            get { return this._routeTableRoute; }
            set { this._routeTableRoute = value; }
        }

        // Check to see if RouteTableRoute property is set
        internal bool IsSetRouteTableRoute()
        {
            return this._routeTableRoute != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroup. 
        /// <para>
        /// The security group.
        /// </para>
        /// </summary>
        public AnalysisComponent SecurityGroup
        {
            get { return this._securityGroup; }
            set { this._securityGroup = value; }
        }

        // Check to see if SecurityGroup property is set
        internal bool IsSetSecurityGroup()
        {
            return this._securityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRule. 
        /// <para>
        /// The security group rule.
        /// </para>
        /// </summary>
        public AnalysisSecurityGroupRule SecurityGroupRule
        {
            get { return this._securityGroupRule; }
            set { this._securityGroupRule = value; }
        }

        // Check to see if SecurityGroupRule property is set
        internal bool IsSetSecurityGroupRule()
        {
            return this._securityGroupRule != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups.
        /// </para>
        /// </summary>
        public List<AnalysisComponent> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceVpc. 
        /// <para>
        /// The source VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent SourceVpc
        {
            get { return this._sourceVpc; }
            set { this._sourceVpc = value; }
        }

        // Check to see if SourceVpc property is set
        internal bool IsSetSourceVpc()
        {
            return this._sourceVpc != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Subnet. 
        /// <para>
        /// The subnet.
        /// </para>
        /// </summary>
        public AnalysisComponent Subnet
        {
            get { return this._subnet; }
            set { this._subnet = value; }
        }

        // Check to see if Subnet property is set
        internal bool IsSetSubnet()
        {
            return this._subnet != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetRouteTable. 
        /// <para>
        /// The route table for the subnet.
        /// </para>
        /// </summary>
        public AnalysisComponent SubnetRouteTable
        {
            get { return this._subnetRouteTable; }
            set { this._subnetRouteTable = value; }
        }

        // Check to see if SubnetRouteTable property is set
        internal bool IsSetSubnetRouteTable()
        {
            return this._subnetRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGateway. 
        /// <para>
        /// The transit gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGateway
        {
            get { return this._transitGateway; }
            set { this._transitGateway = value; }
        }

        // Check to see if TransitGateway property is set
        internal bool IsSetTransitGateway()
        {
            return this._transitGateway != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachment. 
        /// <para>
        /// The transit gateway attachment.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGatewayAttachment
        {
            get { return this._transitGatewayAttachment; }
            set { this._transitGatewayAttachment = value; }
        }

        // Check to see if TransitGatewayAttachment property is set
        internal bool IsSetTransitGatewayAttachment()
        {
            return this._transitGatewayAttachment != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTable. 
        /// <para>
        /// The transit gateway route table.
        /// </para>
        /// </summary>
        public AnalysisComponent TransitGatewayRouteTable
        {
            get { return this._transitGatewayRouteTable; }
            set { this._transitGatewayRouteTable = value; }
        }

        // Check to see if TransitGatewayRouteTable property is set
        internal bool IsSetTransitGatewayRouteTable()
        {
            return this._transitGatewayRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableRoute. 
        /// <para>
        /// The transit gateway route table route.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableRoute TransitGatewayRouteTableRoute
        {
            get { return this._transitGatewayRouteTableRoute; }
            set { this._transitGatewayRouteTableRoute = value; }
        }

        // Check to see if TransitGatewayRouteTableRoute property is set
        internal bool IsSetTransitGatewayRouteTableRoute()
        {
            return this._transitGatewayRouteTableRoute != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The component VPC.
        /// </para>
        /// </summary>
        public AnalysisComponent Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpoint. 
        /// <para>
        /// The VPC endpoint.
        /// </para>
        /// </summary>
        public AnalysisComponent VpcEndpoint
        {
            get { return this._vpcEndpoint; }
            set { this._vpcEndpoint = value; }
        }

        // Check to see if VpcEndpoint property is set
        internal bool IsSetVpcEndpoint()
        {
            return this._vpcEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnection. 
        /// <para>
        /// The VPC peering connection.
        /// </para>
        /// </summary>
        public AnalysisComponent VpcPeeringConnection
        {
            get { return this._vpcPeeringConnection; }
            set { this._vpcPeeringConnection = value; }
        }

        // Check to see if VpcPeeringConnection property is set
        internal bool IsSetVpcPeeringConnection()
        {
            return this._vpcPeeringConnection != null;
        }

        /// <summary>
        /// Gets and sets the property VpnConnection. 
        /// <para>
        /// The VPN connection.
        /// </para>
        /// </summary>
        public AnalysisComponent VpnConnection
        {
            get { return this._vpnConnection; }
            set { this._vpnConnection = value; }
        }

        // Check to see if VpnConnection property is set
        internal bool IsSetVpnConnection()
        {
            return this._vpnConnection != null;
        }

        /// <summary>
        /// Gets and sets the property VpnGateway. 
        /// <para>
        /// The VPN gateway.
        /// </para>
        /// </summary>
        public AnalysisComponent VpnGateway
        {
            get { return this._vpnGateway; }
            set { this._vpnGateway = value; }
        }

        // Check to see if VpnGateway property is set
        internal bool IsSetVpnGateway()
        {
            return this._vpnGateway != null;
        }

    }
}