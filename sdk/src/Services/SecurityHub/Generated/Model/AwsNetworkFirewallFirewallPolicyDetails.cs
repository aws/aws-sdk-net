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
    /// Details about a firewall policy. A firewall policy defines the behavior of a network
    /// firewall.
    /// </summary>
    public partial class AwsNetworkFirewallFirewallPolicyDetails
    {
        private string _description;
        private FirewallPolicyDetails _firewallPolicy;
        private string _firewallPolicyArn;
        private string _firewallPolicyId;
        private string _firewallPolicyName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
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
        /// Gets and sets the property FirewallPolicy. 
        /// <para>
        /// The firewall policy configuration.
        /// </para>
        /// </summary>
        public FirewallPolicyDetails FirewallPolicy
        {
            get { return this._firewallPolicy; }
            set { this._firewallPolicy = value; }
        }

        // Check to see if FirewallPolicy property is set
        internal bool IsSetFirewallPolicy()
        {
            return this._firewallPolicy != null;
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
        /// Gets and sets the property FirewallPolicyId. 
        /// <para>
        /// The identifier of the firewall policy.
        /// </para>
        /// </summary>
        public string FirewallPolicyId
        {
            get { return this._firewallPolicyId; }
            set { this._firewallPolicyId = value; }
        }

        // Check to see if FirewallPolicyId property is set
        internal bool IsSetFirewallPolicyId()
        {
            return this._firewallPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallPolicyName. 
        /// <para>
        /// The name of the firewall policy.
        /// </para>
        /// </summary>
        public string FirewallPolicyName
        {
            get { return this._firewallPolicyName; }
            set { this._firewallPolicyName = value; }
        }

        // Check to see if FirewallPolicyName property is set
        internal bool IsSetFirewallPolicyName()
        {
            return this._firewallPolicyName != null;
        }

    }
}