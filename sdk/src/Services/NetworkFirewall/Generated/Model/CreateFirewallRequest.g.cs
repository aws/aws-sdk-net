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
    /// Container for the parameters to the CreateFirewall operation. Creates an Network Firewall
    /// <a>Firewall</a> and accompanying <a>FirewallStatus</a> for a VPC. <para> The firewall
    /// defines the configuration settings for an Network Firewall firewall. The settings
    /// that you can define at creation include the firewall policy, the subnets in your VPC
    /// to use for the firewall endpoints, and any tags that are attached to the firewall
    /// Amazon Web Services resource. </para> <para> After you create a firewall, you can
    /// provide additional settings, like the logging configuration. </para> <para> To update
    /// the settings for a firewall, you use the operations that apply to the settings themselves,
    /// for example <a>UpdateLoggingConfiguration</a>, <a>AssociateSubnets</a>, and <a>UpdateFirewallDeleteProtection</a>.
    /// </para> <para> To manage a firewall's tags, use the standard Amazon Web Services resource
    /// tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
    /// </para> <para> To retrieve information about firewalls, use <a>ListFirewalls</a> and
    /// <a>DescribeFirewall</a>. </para> <para> To generate a report on the last 30 days of
    /// traffic monitored by a firewall, use <a>StartAnalysisReport</a>. </para> <para> To
    /// create a proxy mode firewall, specify <c>VpcEndpoint</c> and <c>NatGatewayCreateMappings</c>
    /// instead of <c>VpcId</c> and <c>SubnetMappings</c>. A proxy mode firewall is an explicit
    /// forward proxy. Your clients send HTTP and HTTPS proxy requests to the firewall's proxy
    /// DNS name, which <c>DescribeFirewall</c> returns in each Availability Zone's <c>Attachment</c>.
    /// The firewall evaluates proxy traffic with the stateful rules in its firewall policy,
    /// and sends allowed traffic out through the NAT gateway in the same Availability Zone.
    /// Your clients don't need route table changes. In each Availability Zone, the firewall
    /// has one endpoint and one NAT gateway, which Network Firewall creates for you. </para>
    /// </summary>
    public partial class CreateFirewallRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneChangeProtection. 
        /// <para>
        /// Optional. A setting indicating whether the firewall is protected against changes to
        /// its Availability Zone configuration. When set to <c>TRUE</c>, you cannot add or remove
        /// Availability Zones without first disabling this protection using <a>UpdateAvailabilityZoneChangeProtection</a>.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>FALSE</c> 
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
        /// Required. The Availability Zones where you want to create firewall endpoints for a
        /// transit gateway-attached firewall. You must specify at least one Availability Zone.
        /// Consider enabling the firewall in every Availability Zone where you have workloads
        /// to maintain Availability Zone isolation.
        /// </para>
        ///  
        /// <para>
        /// You can modify Availability Zones later using <a>AssociateAvailabilityZones</a> or
        /// <a>DisassociateAvailabilityZones</a>, but this may briefly disrupt traffic. The <c>AvailabilityZoneChangeProtection</c>
        /// setting controls whether you can make these modifications.
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
        /// A complex type that contains settings for encryption of your firewall resources.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a>FirewallPolicy</a> that you want to use for
        /// the firewall.
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
        /// Gets and sets the property NatGatewayCreateMappings. 
        /// <para>
        /// The NAT gateways that Network Firewall creates for a proxy mode firewall, one for
        /// each Availability Zone. When you specify this, you create a proxy mode firewall. Destinations
        /// see the IP address of the NAT gateway in the client's Availability Zone as the source
        /// of the traffic.
        /// </para>
        ///  
        /// <para>
        /// Specify one mapping for each Availability Zone in <c>VpcEndpoint</c>, and no other
        /// Availability Zones. Each NAT gateway subnet must be in the <c>VpcEndpoint</c> VPC
        /// and can't be one of the firewall endpoint subnets.
        /// </para>
        ///  
        /// <para>
        /// You need permission to call the Amazon EC2 <c>CreateNatGateway</c> action.
        /// </para>
        ///  
        /// <para>
        /// If Network Firewall can't set up an Availability Zone, for example because Amazon
        /// EC2 rejects the NAT gateway, it removes the Availability Zone from the firewall. It
        /// also deletes the NAT gateway that it created there. The Availability Zone's <c>Attachment</c>
        /// status is <c>FAILED</c>, and its status message explains why. You can add the Availability
        /// Zone again with <c>AssociateSubnets</c>. If no Availability Zone can be set up, the
        /// firewall status is <c>FAILED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<NatGatewayCreateMapping> NatGatewayCreateMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<NatGatewayCreateMapping>() : null;

        /// <summary>
        /// Checks to see if the NatGatewayCreateMappings property is set.
        /// </summary>
        internal bool IsSetNatGatewayCreateMappings() => this.NatGatewayCreateMappings != null && (this.NatGatewayCreateMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProxySettings. 
        /// <para>
        /// The proxy settings for a proxy mode firewall: the ports and protocols on which the
        /// firewall's proxy listens for traffic, and optionally your own domain name and certificate.
        /// If you don't specify listeners, the firewall listens for HTTP on port 3128 and HTTPS
        /// on port 8443.
        /// </para>
        ///  
        /// <para>
        /// To change the listeners later, use <c>UpdateProxySettings</c>.
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
        /// The public subnets to use for your Network Firewall firewalls. Each subnet must belong
        /// to a different Availability Zone in the VPC. Network Firewall creates a firewall endpoint
        /// in each subnet. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetMapping> SubnetMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;

        /// <summary>
        /// Checks to see if the SubnetMappings property is set.
        /// </summary>
        internal bool IsSetSubnetMappings() => this.SubnetMappings != null && (this.SubnetMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
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
        /// Required when creating a transit gateway-attached firewall. The unique identifier
        /// of the transit gateway to attach to this firewall. You can provide either a transit
        /// gateway from your account or one that has been shared with you through Resource Access
        /// Manager.
        /// </para>
        ///  <important> 
        /// <para>
        /// After creating the firewall, you cannot change the transit gateway association. To
        /// use a different transit gateway, you must create a new firewall.
        /// </para>
        ///  </important> 
        /// <para>
        /// For information about creating firewalls, see <a>CreateFirewall</a>. For specific
        /// guidance about transit gateway-attached firewalls, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tgw-firewall-considerations.html">Considerations
        /// for transit gateway-attached firewalls</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property TransparentFilteringNatScope. 
        /// <para>
        /// How a proxy mode firewall handles traffic that isn't sent to its proxy listener. If
        /// you don't specify a value, the firewall uses <c>NAT_ALL</c>. You can choose from the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NAT_ALL</c> - After inspection, the firewall sends this traffic out through its
        /// NAT gateway, which translates the source address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAT_NONE</c> - After inspection, the firewall returns this traffic to the firewall
        /// endpoint without address translation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify this only for a proxy mode firewall, and you can't change it after
        /// you create the firewall.
        /// </para>
        /// </summary>
        public TransparentFilteringNatScope TransparentFilteringNatScope { get; set; }

        /// <summary>
        /// Checks to see if the TransparentFilteringNatScope property is set.
        /// </summary>
        internal bool IsSetTransparentFilteringNatScope() => this.TransparentFilteringNatScope != null;

        /// <summary>
        /// Gets and sets the property VpcEndpoint. 
        /// <para>
        /// The VPC and subnets for the endpoints of a proxy mode firewall. Network Firewall creates
        /// a firewall endpoint in each subnet that you specify. It also creates the firewall's
        /// NAT gateways in this VPC, in the subnets that you specify in <c>NatGatewayCreateMappings</c>.
        /// </para>
        ///  
        /// <para>
        /// To create a proxy mode firewall, you must specify <c>VpcEndpoint</c> and <c>NatGatewayCreateMappings</c>,
        /// and you must not specify the top-level <c>VpcId</c> and <c>SubnetMappings</c>. Specify
        /// one subnet for each Availability Zone where you want to use the firewall.
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
        /// The unique identifier of the VPC where Network Firewall should create the firewall.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can't change this setting after you create the firewall. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
