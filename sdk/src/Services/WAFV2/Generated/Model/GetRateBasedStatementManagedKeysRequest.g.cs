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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetRateBasedStatementManagedKeys operation. Retrieves
    /// the IP addresses that are currently blocked by a rate-based rule instance. This is
    /// only available for rate-based rules that aggregate solely on the IP address or on
    /// the forwarded IP address. <para> The maximum number of addresses that can be blocked
    /// for a single rate-based rule instance is 10,000. If more than 10,000 addresses exceed
    /// the rate limit, those with the highest rates are blocked. </para> <para> For a rate-based
    /// rule that you've defined inside a rule group, provide the name of the rule group reference
    /// statement in your request, in addition to the rate-based rule name and the web ACL
    /// name. </para> <para> WAF monitors web requests and manages keys independently for
    /// each unique combination of web ACL, optional rule group, and rate-based rule. For
    /// example, if you define a rate-based rule inside a rule group, and then use the rule
    /// group in a web ACL, WAF monitors web requests and manages keys for that web ACL, rule
    /// group reference statement, and rate-based rule instance. If you use the same rule
    /// group in a second web ACL, WAF monitors web requests and manages keys for this second
    /// usage completely independent of your first. </para>
    /// </summary>
    public partial class GetRateBasedStatementManagedKeysRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property RuleGroupRuleName. 
        /// <para>
        /// The name of the rule group reference statement in your web ACL. This is required only
        /// when you have the rate-based rule nested inside a rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RuleGroupRuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupRuleName property is set.
        /// </summary>
        internal bool IsSetRuleGroupRuleName() => this.RuleGroupRuleName != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rate-based rule to get the keys for. If you have the rule defined
        /// inside a rule group that you're using in your web ACL, also provide the name of the
        /// rule group reference statement in the request parameter <c>RuleGroupRuleName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// The unique identifier for the web ACL. This ID is returned in the responses to create
        /// and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string WebACLId { get; set; }

        /// <summary>
        /// Checks to see if the WebACLId property is set.
        /// </summary>
        internal bool IsSetWebACLId() => this.WebACLId != null;

        /// <summary>
        /// Gets and sets the property WebACLName. 
        /// <para>
        /// The name of the web ACL. You cannot change the name of a web ACL after you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string WebACLName { get; set; }

        /// <summary>
        /// Checks to see if the WebACLName property is set.
        /// </summary>
        internal bool IsSetWebACLName() => this.WebACLName != null;
    }
}
