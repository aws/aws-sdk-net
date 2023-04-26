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
    /// Describes a path component.
    /// </summary>
    public partial class PathComponent
    {
        private AnalysisAclRule _aclRule;
        private List<AdditionalDetail> _additionalDetails = new List<AdditionalDetail>();
        private AnalysisComponent _attachedTo;
        private AnalysisComponent _component;
        private AnalysisComponent _destinationVpc;
        private AnalysisComponent _elasticLoadBalancerListener;
        private List<Explanation> _explanations = new List<Explanation>();
        private FirewallStatefulRule _firewallStatefulRule;
        private FirewallStatelessRule _firewallStatelessRule;
        private AnalysisPacketHeader _inboundHeader;
        private AnalysisPacketHeader _outboundHeader;
        private AnalysisRouteTableRoute _routeTableRoute;
        private AnalysisSecurityGroupRule _securityGroupRule;
        private int? _sequenceNumber;
        private string _serviceName;
        private AnalysisComponent _sourceVpc;
        private AnalysisComponent _subnet;
        private AnalysisComponent _transitGateway;
        private TransitGatewayRouteTableRoute _transitGatewayRouteTableRoute;
        private AnalysisComponent _vpc;

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
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// The additional details.
        /// </para>
        /// </summary>
        public List<AdditionalDetail> AdditionalDetails
        {
            get { return this._additionalDetails; }
            set { this._additionalDetails = value; }
        }

        // Check to see if AdditionalDetails property is set
        internal bool IsSetAdditionalDetails()
        {
            return this._additionalDetails != null && this._additionalDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The resource to which the path component is attached.
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
        /// Gets and sets the property Explanations. 
        /// <para>
        /// The explanation codes.
        /// </para>
        /// </summary>
        public List<Explanation> Explanations
        {
            get { return this._explanations; }
            set { this._explanations = value; }
        }

        // Check to see if Explanations property is set
        internal bool IsSetExplanations()
        {
            return this._explanations != null && this._explanations.Count > 0; 
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
        /// Gets and sets the property InboundHeader. 
        /// <para>
        /// The inbound header.
        /// </para>
        /// </summary>
        public AnalysisPacketHeader InboundHeader
        {
            get { return this._inboundHeader; }
            set { this._inboundHeader = value; }
        }

        // Check to see if InboundHeader property is set
        internal bool IsSetInboundHeader()
        {
            return this._inboundHeader != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundHeader. 
        /// <para>
        /// The outbound header.
        /// </para>
        /// </summary>
        public AnalysisPacketHeader OutboundHeader
        {
            get { return this._outboundHeader; }
            set { this._outboundHeader = value; }
        }

        // Check to see if OutboundHeader property is set
        internal bool IsSetOutboundHeader()
        {
            return this._outboundHeader != null;
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
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number.
        /// </para>
        /// </summary>
        public int SequenceNumber
        {
            get { return this._sequenceNumber.GetValueOrDefault(); }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the VPC endpoint service.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
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
        /// Gets and sets the property TransitGatewayRouteTableRoute. 
        /// <para>
        /// The route in a transit gateway route table.
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

    }
}