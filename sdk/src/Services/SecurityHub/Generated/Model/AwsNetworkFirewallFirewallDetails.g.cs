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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Network Firewall firewall.
    /// </summary>
    public partial class AwsNetworkFirewallFirewallDetails
    {
        /// <summary>
        /// Gets and sets the property DeleteProtection. 
        /// <para>
        /// Whether the firewall is protected from deletion. If set to <c>true</c>, then the firewall
        /// cannot be deleted.
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
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The ARN of the firewall.
        /// </para>
        /// </summary>
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FirewallId. 
        /// <para>
        /// The identifier of the firewall.
        /// </para>
        /// </summary>
        public string FirewallId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallId property is set.
        /// </summary>
        internal bool IsSetFirewallId() => this.FirewallId != null;

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// A descriptive name of the firewall.
        /// </para>
        /// </summary>
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The ARN of the firewall policy.
        /// </para>
        /// </summary>
        public string FirewallPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyArn property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyArn() => this.FirewallPolicyArn != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyChangeProtection. 
        /// <para>
        /// Whether the firewall is protected from a change to the firewall policy. If set to
        /// <c>true</c>, you cannot associate a different policy with the firewall.
        /// </para>
        /// </summary>
        public bool? FirewallPolicyChangeProtection { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyChangeProtection property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyChangeProtection() => this.FirewallPolicyChangeProtection.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetChangeProtection. 
        /// <para>
        /// Whether the firewall is protected from a change to the subnet associations. If set
        /// to <c>true</c>, you cannot map different subnets to the firewall.
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
        /// The public subnets that Network Firewall uses for the firewall. Each subnet must belong
        /// to a different Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsNetworkFirewallFirewallSubnetMappingsDetails> SubnetMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsNetworkFirewallFirewallSubnetMappingsDetails>() : null;

        /// <summary>
        /// Checks to see if the SubnetMappings property is set.
        /// </summary>
        internal bool IsSetSubnetMappings() => this.SubnetMappings != null && (this.SubnetMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC where the firewall is used.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
