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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// The definition of an available rule type that can be used in DNS Firewall rules. This
    /// is returned by <a>ListFirewallRuleTypes</a>.
    /// </summary>
    public partial class FirewallRuleTypeDefinition
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the rule type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The category or class of the rule type, such as <c>FirewallAdvancedContentCategory</c>
        /// or <c>FirewallAdvancedThreatCategory</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property SubscriptionInfo. 
        /// <para>
        /// For rule types that require an external subscription (today, only the <c>PartnerThreatProtection</c>
        /// variant), describes the Amazon Web Services Marketplace product that backs the rule
        /// type. Absent for rule types that are managed by Amazon Web Services and do not require
        /// a separate subscription. See <a>SubscriptionInfo</a>.
        /// </para>
        /// </summary>
        public SubscriptionInfo SubscriptionInfo { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionInfo property is set.
        /// </summary>
        internal bool IsSetSubscriptionInfo() => this.SubscriptionInfo != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The specific identifier within the rule type category, such as <c>VIOLENCE_AND_HATE_SPEECH</c>
        /// or <c>PHISHING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
