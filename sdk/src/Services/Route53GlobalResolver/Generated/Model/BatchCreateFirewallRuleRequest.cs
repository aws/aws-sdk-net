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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
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
namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateFirewallRule operation.
    /// Creates multiple DNS firewall rules in a single operation. This is more efficient
    /// than creating rules individually when you need to set up multiple rules at once.
    /// </summary>
    public partial class BatchCreateFirewallRuleRequest : AmazonRoute53GlobalResolverRequest
    {
        private List<BatchCreateFirewallRuleInputItem> _firewallRules = AWSConfigs.InitializeCollections ? new List<BatchCreateFirewallRuleInputItem>() : null;

        /// <summary>
        /// Gets and sets the property FirewallRules. 
        /// <para>
        /// The <c>BatchCreateFirewallRuleInputItem</c> objects contain the information for each
        /// Firewall rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchCreateFirewallRuleInputItem> FirewallRules
        {
            get { return this._firewallRules; }
            set { this._firewallRules = value; }
        }

        // Check to see if FirewallRules property is set
        internal bool IsSetFirewallRules()
        {
            return this._firewallRules != null && (this._firewallRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}