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
    /// Details about a firewall policy. A firewall policy defines the behavior of a network
    /// firewall.
    /// </summary>
    public partial class AwsNetworkFirewallFirewallPolicyDetails
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the firewall policy.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicy. 
        /// <para>
        /// The firewall policy configuration.
        /// </para>
        /// </summary>
        public FirewallPolicyDetails FirewallPolicy { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicy property is set.
        /// </summary>
        internal bool IsSetFirewallPolicy() => this.FirewallPolicy != null;

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
        /// Gets and sets the property FirewallPolicyId. 
        /// <para>
        /// The identifier of the firewall policy.
        /// </para>
        /// </summary>
        public string FirewallPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyId property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyId() => this.FirewallPolicyId != null;

        /// <summary>
        /// Gets and sets the property FirewallPolicyName. 
        /// <para>
        /// The name of the firewall policy.
        /// </para>
        /// </summary>
        public string FirewallPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallPolicyName property is set.
        /// </summary>
        internal bool IsSetFirewallPolicyName() => this.FirewallPolicyName != null;
    }
}
