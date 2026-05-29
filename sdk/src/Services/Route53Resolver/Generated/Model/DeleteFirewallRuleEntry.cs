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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// The details for deleting a single firewall rule in a batch operation.
    /// </summary>
    public partial class DeleteFirewallRuleEntry
    {
        private string _firewallDomainListId;
        private string _firewallRuleGroupId;
        private string _firewallThreatProtectionId;
        private string _qtype;

        /// <summary>
        /// Gets and sets the property FirewallDomainListId. 
        /// <para>
        /// The ID of the domain list that's used in the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FirewallDomainListId
        {
            get { return this._firewallDomainListId; }
            set { this._firewallDomainListId = value; }
        }

        // Check to see if FirewallDomainListId property is set
        internal bool IsSetFirewallDomainListId()
        {
            return this._firewallDomainListId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupId. 
        /// <para>
        /// The unique identifier of the firewall rule group for the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallRuleGroupId
        {
            get { return this._firewallRuleGroupId; }
            set { this._firewallRuleGroupId = value; }
        }

        // Check to see if FirewallRuleGroupId property is set
        internal bool IsSetFirewallRuleGroupId()
        {
            return this._firewallRuleGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallThreatProtectionId. 
        /// <para>
        /// The ID of the DNS Firewall Advanced rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FirewallThreatProtectionId
        {
            get { return this._firewallThreatProtectionId; }
            set { this._firewallThreatProtectionId = value; }
        }

        // Check to see if FirewallThreatProtectionId property is set
        internal bool IsSetFirewallThreatProtectionId()
        {
            return this._firewallThreatProtectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Qtype. 
        /// <para>
        /// The DNS query type that the rule evaluates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string Qtype
        {
            get { return this._qtype; }
            set { this._qtype = value; }
        }

        // Check to see if Qtype property is set
        internal bool IsSetQtype()
        {
            return this._qtype != null;
        }

    }
}