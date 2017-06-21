/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRateBasedRule operation.
    /// Inserts or deletes <a>Predicate</a> objects in a rule and updates the <code>RateLimit</code>
    /// in the rule. 
    /// 
    ///  
    /// <para>
    /// Each <code>Predicate</code> object identifies a predicate, such as a <a>ByteMatchSet</a>
    /// or an <a>IPSet</a>, that specifies the web requests that you want to block or count.
    /// The <code>RateLimit</code> specifies the number of requests every five minutes that
    /// triggers the rule.
    /// </para>
    ///  
    /// <para>
    /// If you add more than one predicate to a <code>RateBasedRule</code>, a request must
    /// match all the predicates and exceed the <code>RateLimit</code> to be counted or blocked.
    /// For example, suppose you add the following to a <code>RateBasedRule</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44/32</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>ByteMatchSet</code> that matches <code>BadBot</code> in the <code>User-Agent</code>
    /// header
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Further, you specify a <code>RateLimit</code> of 15,000.
    /// </para>
    ///  
    /// <para>
    /// You then add the <code>RateBasedRule</code> to a <code>WebACL</code> and specify that
    /// you want to block requests that satisfy the rule. For a request to be blocked, it
    /// must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code> header
    /// in the request must contain the value <code>BadBot</code>. Further, requests that
    /// match these two conditions much be received at a rate of more than 15,000 every five
    /// minutes. If the rate drops below this limit, AWS WAF no longer blocks the requests.
    /// </para>
    ///  
    /// <para>
    /// As a second example, suppose you want to limit requests to a particular page on your
    /// site. To do this, you could add the following to a <code>RateBasedRule</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <code>ByteMatchSet</code> with <code>FieldToMatch</code> of <code>URI</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>PositionalConstraint</code> of <code>STARTS_WITH</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>TargetString</code> of <code>login</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Further, you specify a <code>RateLimit</code> of 15,000.
    /// </para>
    ///  
    /// <para>
    /// By adding this <code>RateBasedRule</code> to a <code>WebACL</code>, you could limit
    /// requests to your login page without affecting the rest of your site.
    /// </para>
    /// </summary>
    public partial class UpdateRateBasedRuleRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private long? _rateLimit;
        private string _ruleId;
        private List<RuleUpdate> _updates = new List<RuleUpdate>();

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property RateLimit. 
        /// <para>
        /// The maximum number of requests, which have an identical value in the field specified
        /// by the <code>RateKey</code>, allowed in a five-minute period. If the number of requests
        /// exceeds the <code>RateLimit</code> and the other predicates specified in the rule
        /// are also met, AWS WAF triggers the action that is specified for this rule.
        /// </para>
        /// </summary>
        public long RateLimit
        {
            get { return this._rateLimit.GetValueOrDefault(); }
            set { this._rateLimit = value; }
        }

        // Check to see if RateLimit property is set
        internal bool IsSetRateLimit()
        {
            return this._rateLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The <code>RuleId</code> of the <code>RateBasedRule</code> that you want to update.
        /// <code>RuleId</code> is returned by <code>CreateRateBasedRule</code> and by <a>ListRateBasedRules</a>.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>RuleUpdate</code> objects that you want to insert into or delete
        /// from a <a>RateBasedRule</a>. 
        /// </para>
        /// </summary>
        public List<RuleUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}