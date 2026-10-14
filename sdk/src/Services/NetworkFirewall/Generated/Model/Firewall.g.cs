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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A firewall defines the behavior of a firewall, the main VPC where the firewall is
    /// used, the Availability Zones where the firewall can be used, and one subnet to use
    /// for a firewall endpoint within each of the Availability Zones. The Availability Zones
    /// are defined implicitly in the subnet specifications.
    /// 
    ///  
    /// <para>
    /// In addition to the firewall endpoints that you define in this <c>Firewall</c> specification,
    /// you can create firewall endpoints in <c>VpcEndpointAssociation</c> resources for any
    /// VPC, in any Availability Zone where the firewall is already in use. 
    /// </para>
    ///  
    /// <para>
    /// The status of the firewall, for example whether it's ready to filter network traffic,
    /// is provided in the corresponding <a>FirewallStatus</a>. You can retrieve both the
    /// firewall and firewall status by calling <a>DescribeFirewall</a>.
    /// </para>
    /// </summary>
    public partial class Firewall
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneChangeProtection. 
        /// <para>
        /// A setting indicating whether the firewall is protected against changes to its Availability
        /// Zone configuration. When set to <c>TRUE</c>, you must first disable this protection
        /// before adding or removing Availability Zones.
        /// </para>
        /// </summary>
        public bool? AvailabilityZoneChangeProtection { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneChangeProtection property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneChangeProtection() => this.AvailabilityZoneChangeProtection.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneMappings. 
        /// <para>
        /// The Availability Zones where the firewall endpoints are created for a transit gateway-attached
        /// firewall. Each mapping specifies an Availability Zone where the firewall processes
        /// traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneMapping> AvailabilityZoneMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneMapping>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZoneMappings property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneMappings() => this.AvailabilityZoneMappings != null && (this.AvailabilityZoneMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeleteProtection. 
        /// <para>
        /// A flag indicating whether it is possible to delete the firewall. A setting of <c>TRUE</c>
        /// indicates that the firewall is protected against deletion. Use this setting to protect
        /// against accidentally deleting a firewall that is in use. When you create a firewall,
        /// the operation initializes this flag to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? DeleteProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeleteProtection property is set.
        /// </summary>
        internal bool IsSetDeleteProtection() => this.DeleteProtection.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnabledAnalysisTypes. 
        /// <para>
        /// An optional setting indicating the specific traffic analysis types to enable on the
        /// firewall. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledAnalysisTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledAnalysisTypes property is set.
        /// </summary>
        internal bool IsSetEnabledAnalysisTypes() => this.EnabledAnalysisTypes != null && (this.EnabledAnalysisTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains the Amazon Web Services KMS encryption configuration
        /// settings for your firewall.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FirewallId. 
        /// <para>
        /// The unique identifier for the firewall. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string FirewallId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallId property is set.
        /// </summary>
        internal bool IsSetFirewallId() => this.FirewallId != null;

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        ///  
        /// <para>
        /// The relationship of firewall to firewall policy is many to one. Each firewall requires
        /// one firewall policy association, and you can use the same firewall policy for multiple
        /// firewalls. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FirewallPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyArn property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyArn() => this.FirewallPolicyArn != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyChangeProtection. 
        /// <para>
        /// A setting indicating whether the firewall is protected against a change to the firewall
        /// policy association. Use this setting to protect against accidentally modifying the
        /// firewall policy for a firewall that is in use. When you create a firewall, the operation
        /// initializes this setting to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? FirewallPolicyChangeProtection { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyChangeProtection property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyChangeProtection() => this.FirewallPolicyChangeProtection.HasValue;

        /// <summary>
        /// Gets and sets the property NatGatewayMappings. 
        /// <para>
        /// The NAT gateways that the firewall uses to proxy traffic. This is set for proxy mode
        /// firewalls, where <c>NoSourcePreservation</c> is <c>TRUE</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NatGatewayMapping> NatGatewayMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<NatGatewayMapping>() : null;

        /// <summary>
        /// Checks to see if the NatGatewayMappings property is set.
        /// </summary>
        internal bool IsSetNatGatewayMappings() => this.NatGatewayMappings != null && (this.NatGatewayMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoSourcePreservation. 
        /// <para>
        /// Indicates whether the firewall operates in proxy mode, in which the source IP address
        /// of the traffic is not preserved. When this value is <c>TRUE</c>, the firewall proxies
        /// traffic through a NAT gateway and uses the NAT gateway's IP address as the source
        /// for traffic reaching the destination. 
        /// </para>
        /// </summary>
        public bool? NoSourcePreservation { get; set; }

        /// <summary>
        /// Checks to see if the NoSourcePreservation property is set.
        /// </summary>
        internal bool IsSetNoSourcePreservation() => this.NoSourcePreservation.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssociations. 
        /// <para>
        /// The number of <c>VpcEndpointAssociation</c> resources that use this firewall. 
        /// </para>
        /// </summary>
        public int? NumberOfAssociations { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociations property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociations() => this.NumberOfAssociations.HasValue;

        /// <summary>
        /// Gets and sets the property ProxySettings. 
        /// <para>
        /// The listener configuration for the firewall's proxy. This is set for proxy mode firewalls,
        /// where <c>NoSourcePreservation</c> is <c>TRUE</c>. 
        /// </para>
        /// </summary>
        public ProxySettings ProxySettings { get; set; }

        /// <summary>
        /// Checks to see if the ProxySettings property is set.
        /// </summary>
        internal bool IsSetProxySettings() => this.ProxySettings != null;

        /// <summary>
        /// Gets and sets the property SubnetChangeProtection. 
        /// <para>
        /// A setting indicating whether the firewall is protected against changes to the subnet
        /// associations. Use this setting to protect against accidentally modifying the subnet
        /// associations for a firewall that is in use. When you create a firewall, the operation
        /// initializes this setting to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? SubnetChangeProtection { get; set; }

        /// <summary>
        /// Checks to see if the SubnetChangeProtection property is set.
        /// </summary>
        internal bool IsSetSubnetChangeProtection() => this.SubnetChangeProtection.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The primary public subnets that Network Firewall is using for the firewall. Network
        /// Firewall creates a firewall endpoint in each subnet. Create a subnet mapping for each
        /// Availability Zone where you want to use the firewall.
        /// </para>
        ///  
        /// <para>
        /// These subnets are all defined for a single, primary VPC, and each must belong to a
        /// different Availability Zone. Each of these subnets establishes the availability of
        /// the firewall in its Availability Zone. 
        /// </para>
        ///  
        /// <para>
        /// In addition to these subnets, you can define other endpoints for the firewall in <c>VpcEndpointAssociation</c>
        /// resources. You can define these additional endpoints for any VPC, and for any of the
        /// Availability Zones where the firewall resource already has a subnet mapping. VPC endpoint
        /// associations give you the ability to protect multiple VPCs using a single firewall,
        /// and to define multiple firewall endpoints for a VPC in a single Availability Zone.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SubnetMapping> SubnetMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;

        /// <summary>
        /// Checks to see if the SubnetMappings property is set.
        /// </summary>
        internal bool IsSetSubnetMappings() => this.SubnetMappings != null && (this.SubnetMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The unique identifier of the transit gateway associated with this firewall. This field
        /// is only present for transit gateway-attached firewalls.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayOwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the transit gateway. This may be different
        /// from the firewall owner's account ID when using a shared transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string TransitGatewayOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayOwnerAccountId() => this.TransitGatewayOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpoint. 
        /// <para>
        /// The VPC and subnets for the firewall endpoint. This is set for proxy mode firewalls,
        /// where <c>NoSourcePreservation</c> is <c>TRUE</c>. 
        /// </para>
        /// </summary>
        public VpcEndpoint VpcEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpoint property is set.
        /// </summary>
        internal bool IsSetVpcEndpoint() => this.VpcEndpoint != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC where the firewall is in use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
