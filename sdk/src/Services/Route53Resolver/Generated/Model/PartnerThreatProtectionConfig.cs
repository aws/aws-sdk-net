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
    /// The configuration for a partner threat-protection rule. To enumerate the partners
    /// available in your account, call <a>ListFirewallRuleTypes</a> with <c>RuleType</c>
    /// set to <c>PartnerThreatProtection</c> — each returned <a>FirewallRuleTypeDefinition</a>
    /// includes a <a>SubscriptionInfo</a> identifying the AWS Marketplace product that backs
    /// it.
    /// </summary>
    public partial class PartnerThreatProtectionConfig
    {
        private string _partner;

        /// <summary>
        /// Gets and sets the property Partner. 
        /// <para>
        /// The identifier of the partner threat-protection product, exactly as returned in the
        /// <c>Value</c> field of a <a>FirewallRuleTypeDefinition</a> with <c>RuleType</c> set
        /// to <c>PartnerThreatProtection</c>. The calling account must hold an active AWS Marketplace
        /// subscription to this product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Partner
        {
            get { return this._partner; }
            set { this._partner = value; }
        }

        // Check to see if Partner property is set
        internal bool IsSetPartner()
        {
            return this._partner != null;
        }

    }
}