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
    /// The high-level properties of a firewall policy. This, along with the <a>FirewallPolicy</a>,
    /// define the policy. You can retrieve all objects for a firewall policy by calling <a>DescribeFirewallPolicy</a>.
    /// </summary>
    public partial class FirewallPolicyResponse
    {
        private string _description;
        private string _firewallPolicyArn;
        private string _firewallPolicyId;
        private string _firewallPolicyName;
        private ResourceStatus _firewallPolicyStatus;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
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
        /// Gets and sets the property FirewallPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall policy.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this response is for a create request that had <code>DryRun</code> set to <code>TRUE</code>,
        /// then this ARN is a placeholder that isn't attached to a valid resource.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property FirewallPolicyId. 
        /// <para>
        /// The unique identifier for the firewall policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// The descriptive name of the firewall policy. You can't change the name of a firewall
        /// policy after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property FirewallPolicyStatus. 
        /// <para>
        /// The current status of the firewall policy. You can retrieve this for a firewall policy
        /// by calling <a>DescribeFirewallPolicy</a> and providing the firewall policy's name
        /// or ARN.
        /// </para>
        /// </summary>
        public ResourceStatus FirewallPolicyStatus
        {
            get { return this._firewallPolicyStatus; }
            set { this._firewallPolicyStatus = value; }
        }

        // Check to see if FirewallPolicyStatus property is set
        internal bool IsSetFirewallPolicyStatus()
        {
            return this._firewallPolicyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
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

    }
}