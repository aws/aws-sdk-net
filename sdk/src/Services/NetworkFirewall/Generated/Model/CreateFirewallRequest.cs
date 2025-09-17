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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
    /// Container for the parameters to the CreateFirewall operation.
    /// Creates an Network Firewall <a>Firewall</a> and accompanying <a>FirewallStatus</a>
    /// for a VPC. 
    /// 
    ///  
    /// <para>
    /// The firewall defines the configuration settings for an Network Firewall firewall.
    /// The settings that you can define at creation include the firewall policy, the subnets
    /// in your VPC to use for the firewall endpoints, and any tags that are attached to the
    /// firewall Amazon Web Services resource. 
    /// </para>
    ///  
    /// <para>
    /// After you create a firewall, you can provide additional settings, like the logging
    /// configuration. 
    /// </para>
    ///  
    /// <para>
    /// To update the settings for a firewall, you use the operations that apply to the settings
    /// themselves, for example <a>UpdateLoggingConfiguration</a>, <a>AssociateSubnets</a>,
    /// and <a>UpdateFirewallDeleteProtection</a>. 
    /// </para>
    ///  
    /// <para>
    /// To manage a firewall's tags, use the standard Amazon Web Services resource tagging
    /// operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
    /// </para>
    ///  
    /// <para>
    /// To retrieve information about firewalls, use <a>ListFirewalls</a> and <a>DescribeFirewall</a>.
    /// </para>
    ///  
    /// <para>
    /// To generate a report on the last 30 days of traffic monitored by a firewall, use <a>StartAnalysisReport</a>.
    /// </para>
    /// </summary>
    public partial class CreateFirewallRequest : AmazonNetworkFirewallRequest
    {
        private bool? _availabilityZoneChangeProtection;
        private List<AvailabilityZoneMapping> _availabilityZoneMappings = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneMapping>() : null;
        private bool? _deleteProtection;
        private string _description;
        private List<string> _enabledAnalysisTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _firewallName;
        private string _firewallPolicyArn;
        private bool? _firewallPolicyChangeProtection;
        private bool? _subnetChangeProtection;
        private List<SubnetMapping> _subnetMappings = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private string _vpcId;

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
        public bool? AvailabilityZoneChangeProtection
        {
            get { return this._availabilityZoneChangeProtection; }
            set { this._availabilityZoneChangeProtection = value; }
        }

        // Check to see if AvailabilityZoneChangeProtection property is set
        internal bool IsSetAvailabilityZoneChangeProtection()
        {
            return this._availabilityZoneChangeProtection.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneMapping> AvailabilityZoneMappings
        {
            get { return this._availabilityZoneMappings; }
            set { this._availabilityZoneMappings = value; }
        }

        // Check to see if AvailabilityZoneMappings property is set
        internal bool IsSetAvailabilityZoneMappings()
        {
            return this._availabilityZoneMappings != null && (this._availabilityZoneMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeleteProtection. 
        /// <para>
        /// A flag indicating whether it is possible to delete the firewall. A setting of <c>TRUE</c>
        /// indicates that the firewall is protected against deletion. Use this setting to protect
        /// against accidentally deleting a firewall that is in use. When you create a firewall,
        /// the operation initializes this flag to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? DeleteProtection
        {
            get { return this._deleteProtection; }
            set { this._deleteProtection = value; }
        }

        // Check to see if DeleteProtection property is set
        internal bool IsSetDeleteProtection()
        {
            return this._deleteProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledAnalysisTypes. 
        /// <para>
        /// An optional setting indicating the specific traffic analysis types to enable on the
        /// firewall. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledAnalysisTypes
        {
            get { return this._enabledAnalysisTypes; }
            set { this._enabledAnalysisTypes = value; }
        }

        // Check to see if EnabledAnalysisTypes property is set
        internal bool IsSetEnabledAnalysisTypes()
        {
            return this._enabledAnalysisTypes != null && (this._enabledAnalysisTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A complex type that contains settings for encryption of your firewall resources.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string FirewallName
        {
            get { return this._firewallName; }
            set { this._firewallName = value; }
        }

        // Check to see if FirewallName property is set
        internal bool IsSetFirewallName()
        {
            return this._firewallName != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <a>FirewallPolicy</a> that you want to use for
        /// the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FirewallPolicyArn
        {
            get { return this._firewallPolicyArn; }
            set { this._firewallPolicyArn = value; }
        }

        // Check to see if FirewallPolicyArn property is set
        internal bool IsSetFirewallPolicyArn()
        {
            return this._firewallPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyChangeProtection. 
        /// <para>
        /// A setting indicating whether the firewall is protected against a change to the firewall
        /// policy association. Use this setting to protect against accidentally modifying the
        /// firewall policy for a firewall that is in use. When you create a firewall, the operation
        /// initializes this setting to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? FirewallPolicyChangeProtection
        {
            get { return this._firewallPolicyChangeProtection; }
            set { this._firewallPolicyChangeProtection = value; }
        }

        // Check to see if FirewallPolicyChangeProtection property is set
        internal bool IsSetFirewallPolicyChangeProtection()
        {
            return this._firewallPolicyChangeProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetChangeProtection. 
        /// <para>
        /// A setting indicating whether the firewall is protected against changes to the subnet
        /// associations. Use this setting to protect against accidentally modifying the subnet
        /// associations for a firewall that is in use. When you create a firewall, the operation
        /// initializes this setting to <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? SubnetChangeProtection
        {
            get { return this._subnetChangeProtection; }
            set { this._subnetChangeProtection = value; }
        }

        // Check to see if SubnetChangeProtection property is set
        internal bool IsSetSubnetChangeProtection()
        {
            return this._subnetChangeProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The public subnets to use for your Network Firewall firewalls. Each subnet must belong
        /// to a different Availability Zone in the VPC. Network Firewall creates a firewall endpoint
        /// in each subnet. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubnetMapping> SubnetMappings
        {
            get { return this._subnetMappings; }
            set { this._subnetMappings = value; }
        }

        // Check to see if SubnetMappings property is set
        internal bool IsSetSubnetMappings()
        {
            return this._subnetMappings != null && (this._subnetMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}