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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Network Firewall firewall.
    /// </summary>
    public partial class AwsNetworkFirewallFirewallDetails
    {
        private bool? _deleteProtection;
        private string _description;
        private string _firewallArn;
        private string _firewallId;
        private string _firewallName;
        private string _firewallPolicyArn;
        private bool? _firewallPolicyChangeProtection;
        private bool? _subnetChangeProtection;
        private List<AwsNetworkFirewallFirewallSubnetMappingsDetails> _subnetMappings = AWSConfigs.InitializeCollections ? new List<AwsNetworkFirewallFirewallSubnetMappingsDetails>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DeleteProtection. 
        /// <para>
        /// Whether the firewall is protected from deletion. If set to <c>true</c>, then the firewall
        /// cannot be deleted.
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
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The ARN of the firewall.
        /// </para>
        /// </summary>
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
        /// The identifier of the firewall.
        /// </para>
        /// </summary>
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
        /// A descriptive name of the firewall.
        /// </para>
        /// </summary>
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
        /// The ARN of the firewall policy.
        /// </para>
        /// </summary>
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
        /// Whether the firewall is protected from a change to the firewall policy. If set to
        /// <c>true</c>, you cannot associate a different policy with the firewall.
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
        /// Whether the firewall is protected from a change to the subnet associations. If set
        /// to <c>true</c>, you cannot map different subnets to the firewall.
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
        /// The public subnets that Network Firewall uses for the firewall. Each subnet must belong
        /// to a different Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsNetworkFirewallFirewallSubnetMappingsDetails> SubnetMappings
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC where the firewall is used.
        /// </para>
        /// </summary>
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