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
    /// A <code>RateBasedRule</code> is identical to a regular <a>Rule</a>, with one addition:
    /// a <code>RateBasedRule</code> counts the number of requests that arrive from a specified
    /// IP address every five minutes. For example, based on recent requests that you've seen
    /// from an attacker, you might create a <code>RateBasedRule</code> that includes the
    /// following conditions: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The requests come from 192.0.2.44.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// They contain the value <code>BadBot</code> in the <code>User-Agent</code> header.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In the rule, you also define the rate limit as 15,000.
    /// </para>
    ///  
    /// <para>
    /// Requests that meet both of these conditions and exceed 15,000 requests every five
    /// minutes trigger the rule's action (block or count), which is defined in the web ACL.
    /// </para>
    /// </summary>
    public partial class RateBasedRule
    {
        private List<Predicate> _matchPredicates = new List<Predicate>();
        private string _metricName;
        private string _name;
        private RateKey _rateKey;
        private long? _rateLimit;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property MatchPredicates. 
        /// <para>
        /// The <code>Predicates</code> object contains one <code>Predicate</code> element for
        /// each <a>ByteMatchSet</a>, <a>IPSet</a>, or <a>SqlInjectionMatchSet</a> object that
        /// you want to include in a <code>RateBasedRule</code>.
        /// </para>
        /// </summary>
        public List<Predicate> MatchPredicates
        {
            get { return this._matchPredicates; }
            set { this._matchPredicates = value; }
        }

        // Check to see if MatchPredicates property is set
        internal bool IsSetMatchPredicates()
        {
            return this._matchPredicates != null && this._matchPredicates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for a <code>RateBasedRule</code>. The
        /// name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain
        /// whitespace. You can't change the name of the metric after you create the <code>RateBasedRule</code>.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description for a <code>RateBasedRule</code>. You can't change
        /// the name of a <code>RateBasedRule</code> after you create it.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RateKey. 
        /// <para>
        /// The field that AWS WAF uses to determine if requests are likely arriving from single
        /// source and thus subject to rate monitoring. The only valid value for <code>RateKey</code>
        /// is <code>IP</code>. <code>IP</code> indicates that requests arriving from the same
        /// IP address are subject to the <code>RateLimit</code> that is specified in the <code>RateBasedRule</code>.
        /// </para>
        /// </summary>
        public RateKey RateKey
        {
            get { return this._rateKey; }
            set { this._rateKey = value; }
        }

        // Check to see if RateKey property is set
        internal bool IsSetRateKey()
        {
            return this._rateKey != null;
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
        /// A unique identifier for a <code>RateBasedRule</code>. You use <code>RuleId</code>
        /// to get more information about a <code>RateBasedRule</code> (see <a>GetRateBasedRule</a>),
        /// update a <code>RateBasedRule</code> (see <a>UpdateRateBasedRule</a>), insert a <code>RateBasedRule</code>
        /// into a <code>WebACL</code> or delete one from a <code>WebACL</code> (see <a>UpdateWebACL</a>),
        /// or delete a <code>RateBasedRule</code> from AWS WAF (see <a>DeleteRateBasedRule</a>).
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

    }
}