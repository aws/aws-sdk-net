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
    /// The definition of an available rule type that can be used in DNS Firewall rules. This
    /// is returned by <a>ListFirewallRuleTypes</a>.
    /// </summary>
    public partial class FirewallRuleTypeDefinition
    {
        private string _description;
        private string _displayName;
        private string _ruleType;
        private SubscriptionInfo _subscriptionInfo;
        private string _value;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the rule type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The category or class of the rule type, such as <c>FirewallAdvancedContentCategory</c>
        /// or <c>FirewallAdvancedThreatCategory</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionInfo. 
        /// <para>
        /// For rule types that require an external subscription (today, only the <c>PartnerThreatProtection</c>
        /// variant), describes the AWS Marketplace product that backs the rule type. Absent for
        /// rule types that are managed by AWS and do not require a separate subscription. See
        /// <a>SubscriptionInfo</a>.
        /// </para>
        /// </summary>
        public SubscriptionInfo SubscriptionInfo
        {
            get { return this._subscriptionInfo; }
            set { this._subscriptionInfo = value; }
        }

        // Check to see if SubscriptionInfo property is set
        internal bool IsSetSubscriptionInfo()
        {
            return this._subscriptionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The specific identifier within the rule type category, such as <c>VIOLENCE_AND_HATE_SPEECH</c>
        /// or <c>PHISHING</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}