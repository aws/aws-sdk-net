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
    /// The configuration for a rule type in a DNS Firewall rule. This is a union type — exactly
    /// one member should be set.
    /// </summary>
    public partial class FirewallRuleType
    {
        private DnsThreatProtectionRuleTypeConfig _dnsThreatProtection;
        private FirewallAdvancedContentCategoryConfig _firewallAdvancedContentCategory;
        private FirewallAdvancedThreatCategoryConfig _firewallAdvancedThreatCategory;

        /// <summary>
        /// Gets and sets the property DnsThreatProtection. 
        /// <para>
        /// The configuration for a DNS threat protection rule type, such as DGA or DNS tunneling
        /// detection.
        /// </para>
        /// </summary>
        public DnsThreatProtectionRuleTypeConfig DnsThreatProtection
        {
            get { return this._dnsThreatProtection; }
            set { this._dnsThreatProtection = value; }
        }

        // Check to see if DnsThreatProtection property is set
        internal bool IsSetDnsThreatProtection()
        {
            return this._dnsThreatProtection != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallAdvancedContentCategory. 
        /// <para>
        /// The configuration for a content category-based filtering rule.
        /// </para>
        /// </summary>
        public FirewallAdvancedContentCategoryConfig FirewallAdvancedContentCategory
        {
            get { return this._firewallAdvancedContentCategory; }
            set { this._firewallAdvancedContentCategory = value; }
        }

        // Check to see if FirewallAdvancedContentCategory property is set
        internal bool IsSetFirewallAdvancedContentCategory()
        {
            return this._firewallAdvancedContentCategory != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallAdvancedThreatCategory. 
        /// <para>
        /// The configuration for a threat category-based filtering rule.
        /// </para>
        /// </summary>
        public FirewallAdvancedThreatCategoryConfig FirewallAdvancedThreatCategory
        {
            get { return this._firewallAdvancedThreatCategory; }
            set { this._firewallAdvancedThreatCategory = value; }
        }

        // Check to see if FirewallAdvancedThreatCategory property is set
        internal bool IsSetFirewallAdvancedThreatCategory()
        {
            return this._firewallAdvancedThreatCategory != null;
        }

    }
}