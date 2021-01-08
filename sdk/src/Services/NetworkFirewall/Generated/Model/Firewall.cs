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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The firewall defines the configuration settings for an AWS Network Firewall firewall.
    /// These settings include the firewall policy, the subnets in your VPC to use for the
    /// firewall endpoints, and any tags that are attached to the firewall AWS resource. 
    /// 
    ///  
    /// <para>
    /// The status of the firewall, for example whether it's ready to filter network traffic,
    /// is provided in the corresponding <a>FirewallStatus</a>. You can retrieve both objects
    /// by calling <a>DescribeFirewall</a>.
    /// </para>
    /// </summary>
    public partial class Firewall
    {
        private bool? _deleteProtection;
        private string _description;
        private string _firewallArn;
        private string _firewallId;
        private string _firewallName;
        private string _firewallPolicyArn;
        private bool? _firewallPolicyChangeProtection;
        private bool? _subnetChangeProtection;
        private List<SubnetMapping> _subnetMappings = new List<SubnetMapping>();
        private List<Tag> _tags = new List<Tag>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DeleteProtection. 
        /// <para>
        /// A flag indicating whether it is possible to delete the firewall. A setting of <code>TRUE</code>
        /// indicates that the firewall is protected against deletion. Use this setting to protect
        /// against accidentally deleting a firewall that is in use. When you create a firewall,
        /// the operation initializes this flag to <code>TRUE</code>.
        /// </para>
        /// </summary>
        public bool DeleteProtection
        {
            get { return this._deleteProtection.GetValueOrDefault(); }
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
        /// initializes this setting to <code>TRUE</code>.
        /// </para>
        /// </summary>
        public bool FirewallPolicyChangeProtection
        {
            get { return this._firewallPolicyChangeProtection.GetValueOrDefault(); }
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
        /// initializes this setting to <code>TRUE</code>.
        /// </para>
        /// </summary>
        public bool SubnetChangeProtection
        {
            get { return this._subnetChangeProtection.GetValueOrDefault(); }
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
        /// The public subnets that Network Firewall is using for the firewall. Each subnet must
        /// belong to a different Availability Zone. 
        /// </para>
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
            return this._subnetMappings != null && this._subnetMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags.
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
            return this._tags != null && this._tags.Count > 0; 
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