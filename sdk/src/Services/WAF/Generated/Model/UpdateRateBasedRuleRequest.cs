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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRateBasedRule operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Inserts or deletes <a>Predicate</a> objects in a rule and updates the <c>RateLimit</c>
    /// in the rule. 
    /// </para>
    ///  
    /// <para>
    /// Each <c>Predicate</c> object identifies a predicate, such as a <a>ByteMatchSet</a>
    /// or an <a>IPSet</a>, that specifies the web requests that you want to block or count.
    /// The <c>RateLimit</c> specifies the number of requests every five minutes that triggers
    /// the rule.
    /// </para>
    ///  
    /// <para>
    /// If you add more than one predicate to a <c>RateBasedRule</c>, a request must match
    /// all the predicates and exceed the <c>RateLimit</c> to be counted or blocked. For example,
    /// suppose you add the following to a <c>RateBasedRule</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44/32</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>ByteMatchSet</c> that matches <c>BadBot</c> in the <c>User-Agent</c> header
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Further, you specify a <c>RateLimit</c> of 1,000.
    /// </para>
    ///  
    /// <para>
    /// You then add the <c>RateBasedRule</c> to a <c>WebACL</c> and specify that you want
    /// to block requests that satisfy the rule. For a request to be blocked, it must come
    /// from the IP address 192.0.2.44 <i>and</i> the <c>User-Agent</c> header in the request
    /// must contain the value <c>BadBot</c>. Further, requests that match these two conditions
    /// much be received at a rate of more than 1,000 every five minutes. If the rate drops
    /// below this limit, AWS WAF no longer blocks the requests.
    /// </para>
    ///  
    /// <para>
    /// As a second example, suppose you want to limit requests to a particular page on your
    /// site. To do this, you could add the following to a <c>RateBasedRule</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <c>ByteMatchSet</c> with <c>FieldToMatch</c> of <c>URI</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>PositionalConstraint</c> of <c>STARTS_WITH</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>TargetString</c> of <c>login</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Further, you specify a <c>RateLimit</c> of 1,000.
    /// </para>
    ///  
    /// <para>
    /// By adding this <c>RateBasedRule</c> to a <c>WebACL</c>, you could limit requests to
    /// your login page without affecting the rest of your site.
    /// </para>
    /// </summary>
    public partial class UpdateRateBasedRuleRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private long? _rateLimit;
        private string _ruleId;
        private List<RuleUpdate> _updates = AWSConfigs.InitializeCollections ? new List<RuleUpdate>() : null;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// by the <c>RateKey</c>, allowed in a five-minute period. If the number of requests
        /// exceeds the <c>RateLimit</c> and the other predicates specified in the rule are also
        /// met, AWS WAF triggers the action that is specified for this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=100, Max=2000000000)]
        public long? RateLimit
        {
            get { return this._rateLimit; }
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
        /// The <c>RuleId</c> of the <c>RateBasedRule</c> that you want to update. <c>RuleId</c>
        /// is returned by <c>CreateRateBasedRule</c> and by <a>ListRateBasedRules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// An array of <c>RuleUpdate</c> objects that you want to insert into or delete from
        /// a <a>RateBasedRule</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RuleUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}