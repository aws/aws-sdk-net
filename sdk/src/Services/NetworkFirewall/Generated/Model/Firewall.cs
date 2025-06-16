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
        private bool? _availabilityZoneChangeProtection;
        private List<AvailabilityZoneMapping> _availabilityZoneMappings = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneMapping>() : null;
        private bool? _deleteProtection;
        private string _description;
        private List<string> _enabledAnalysisTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _firewallArn;
        private string _firewallId;
        private string _firewallName;
        private string _firewallPolicyArn;
        private bool? _firewallPolicyChangeProtection;
        private int? _numberOfAssociations;
        private bool? _subnetChangeProtection;
        private List<SubnetMapping> _subnetMappings = AWSConfigs.InitializeCollections ? new List<SubnetMapping>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private string _transitGatewayOwnerAccountId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneChangeProtection. 
        /// <para>
        /// A setting indicating whether the firewall is protected against changes to its Availability
        /// Zone configuration. When set to <c>TRUE</c>, you must first disable this protection
        /// before adding or removing Availability Zones.
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
        /// The Availability Zones where the firewall endpoints are created for a transit gateway-attached
        /// firewall. Each mapping specifies an Availability Zone where the firewall processes
        /// traffic.
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
        /// A complex type that contains the Amazon Web Services KMS encryption configuration
        /// settings for your firewall.
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
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FirewallArn
        {
            get { return this._firewallArn; }
            set { this._firewallArn = value; }
        }

        // Check to see if FirewallArn property is set
        internal bool IsSetFirewallArn()
        {
            return this._firewallArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallId. 
        /// <para>
        /// The unique identifier for the firewall. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string FirewallId
        {
            get { return this._firewallId; }
            set { this._firewallId = value; }
        }

        // Check to see if FirewallId property is set
        internal bool IsSetFirewallId()
        {
            return this._firewallId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        ///  
        /// <para>
        /// The relationship of firewall to firewall policy is many to one. Each firewall requires
        /// one firewall policy association, and you can use the same firewall policy for multiple
        /// firewalls. 
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
        /// Gets and sets the property NumberOfAssociations. 
        /// <para>
        /// The number of <c>VpcEndpointAssociation</c> resources that use this firewall. 
        /// </para>
        /// </summary>
        public int? NumberOfAssociations
        {
            get { return this._numberOfAssociations; }
            set { this._numberOfAssociations = value; }
        }

        // Check to see if NumberOfAssociations property is set
        internal bool IsSetNumberOfAssociations()
        {
            return this._numberOfAssociations.HasValue; 
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The unique identifier of the transit gateway associated with this firewall. This field
        /// is only present for transit gateway-attached firewalls.
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
        /// Gets and sets the property TransitGatewayOwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the transit gateway. This may be different
        /// from the firewall owner's account ID when using a shared transit gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string TransitGatewayOwnerAccountId
        {
            get { return this._transitGatewayOwnerAccountId; }
            set { this._transitGatewayOwnerAccountId = value; }
        }

        // Check to see if TransitGatewayOwnerAccountId property is set
        internal bool IsSetTransitGatewayOwnerAccountId()
        {
            return this._transitGatewayOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The unique identifier of the VPC where the firewall is in use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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