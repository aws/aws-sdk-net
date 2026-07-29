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
    /// Container for the parameters to the ListFirewallRuleTypes operation.
    /// Retrieves the rule-type variants that can be used in the <c>FirewallRuleType</c> field
    /// of <a>CreateFirewallRule</a> and <a>UpdateFirewallRule</a>. Each returned <a>FirewallRuleTypeDefinition</a>
    /// identifies one variant + value combination — for example, <c>FirewallAdvancedContentCategory</c>
    /// + <c>VIOLENCE_AND_HATE_SPEECH</c>, or <c>PartnerThreatProtection</c> + a partner-managed
    /// feed.
    /// 
    ///  
    /// <para>
    /// The supported <c>RuleType</c> filter values are <c>FirewallAdvancedContentCategory</c>,
    /// <c>FirewallAdvancedThreatCategory</c>, <c>DnsThreatProtection</c>, and <c>PartnerThreatProtection</c>.
    /// When a returned definition's variant requires an external subscription (currently
    /// only <c>PartnerThreatProtection</c>), the response also includes a <a>SubscriptionInfo</a>
    /// identifying the AWS Marketplace product that backs it; absence of <c>SubscriptionInfo</c>
    /// means the variant is fully managed by AWS and requires no separate subscription.
    /// </para>
    /// </summary>
    public partial class ListFirewallRuleTypesRequest : AmazonRoute53ResolverRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _ruleType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Resolver to return for this request. If
        /// more objects are available, in the response, Resolver provides a <c>NextToken</c>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For the first call to this list request, omit this value. When you request a list
        /// of objects, Resolver returns at most the number of objects specified in <c>MaxResults</c>.
        /// If more objects are available for retrieval, Resolver provides a <c>NextToken</c>
        /// value in the response. To retrieve the next batch of objects, use the token that was
        /// returned for the prior request in your next request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// An optional filter that restricts the response to a single <a>FirewallRuleType</a>
        /// variant. Supported values: <c>FirewallAdvancedContentCategory</c>, <c>FirewallAdvancedThreatCategory</c>,
        /// <c>DnsThreatProtection</c>, and <c>PartnerThreatProtection</c>. If omitted, definitions
        /// across all variants are returned.
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

    }
}