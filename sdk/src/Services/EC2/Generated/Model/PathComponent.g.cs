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
    /// Describes a path component.
    /// </summary>
    public partial class PathComponent
    {
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
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// The additional details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalDetail> AdditionalDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalDetail>() : null;

        /// <summary>
        /// Checks to see if the AdditionalDetails property is set.
        /// </summary>
        internal bool IsSetAdditionalDetails() => this.AdditionalDetails != null && (this.AdditionalDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The resource to which the path component is attached.
        /// </para>
        /// </summary>
        public AnalysisComponent AttachedTo { get; set; }

        /// <summary>
        /// Checks to see if the AttachedTo property is set.
        /// </summary>
        internal bool IsSetAttachedTo() => this.AttachedTo != null;

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
        /// Gets and sets the property Explanations. 
        /// <para>
        /// The explanation codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Explanation> Explanations { get; set; } = AWSConfigs.InitializeCollections ? new List<Explanation>() : null;

        /// <summary>
        /// Checks to see if the Explanations property is set.
        /// </summary>
        internal bool IsSetExplanations() => this.Explanations != null && (this.Explanations.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property InboundHeader. 
        /// <para>
        /// The inbound header.
        /// </para>
        /// </summary>
        public AnalysisPacketHeader InboundHeader { get; set; }

        /// <summary>
        /// Checks to see if the InboundHeader property is set.
        /// </summary>
        internal bool IsSetInboundHeader() => this.InboundHeader != null;

        /// <summary>
        /// Gets and sets the property OutboundHeader. 
        /// <para>
        /// The outbound header.
        /// </para>
        /// </summary>
        public AnalysisPacketHeader OutboundHeader { get; set; }

        /// <summary>
        /// Checks to see if the OutboundHeader property is set.
        /// </summary>
        internal bool IsSetOutboundHeader() => this.OutboundHeader != null;

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
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number.
        /// </para>
        /// </summary>
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the VPC endpoint service.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

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
        /// Gets and sets the property TransitGatewayPolicyTableEntry. 
        /// <para>
        /// The entry in a transit gateway policy table.
        /// </para>
        /// </summary>
        public AnalysisTransitGatewayPolicyTableEntry TransitGatewayPolicyTableEntry { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayPolicyTableEntry property is set.
        /// </summary>
        internal bool IsSetTransitGatewayPolicyTableEntry() => this.TransitGatewayPolicyTableEntry != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableRoute. 
        /// <para>
        /// The route in a transit gateway route table.
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
    }
}
