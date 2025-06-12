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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
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
    /// A <c>RateBasedRule</c> is identical to a regular <a>Rule</a>, with one addition: a
    /// <c>RateBasedRule</c> counts the number of requests that arrive from a specified IP
    /// address every five minutes. For example, based on recent requests that you've seen
    /// from an attacker, you might create a <c>RateBasedRule</c> that includes the following
    /// conditions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The requests come from 192.0.2.44.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// They contain the value <c>BadBot</c> in the <c>User-Agent</c> header.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In the rule, you also define the rate limit as 1,000.
    /// </para>
    ///  
    /// <para>
    /// Requests that meet both of these conditions and exceed 1,000 requests every five minutes
    /// trigger the rule's action (block or count), which is defined in the web ACL.
    /// </para>
    /// </summary>
    public partial class RateBasedRule
    {
        private List<Predicate> _matchPredicates = AWSConfigs.InitializeCollections ? new List<Predicate>() : null;
        private string _metricName;
        private string _name;
        private RateKey _rateKey;
        private long? _rateLimit;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property MatchPredicates. 
        /// <para>
        /// The <c>Predicates</c> object contains one <c>Predicate</c> element for each <a>ByteMatchSet</a>,
        /// <a>IPSet</a>, or <a>SqlInjectionMatchSet</a> object that you want to include in a
        /// <c>RateBasedRule</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Predicate> MatchPredicates
        {
            get { return this._matchPredicates; }
            set { this._matchPredicates = value; }
        }

        // Check to see if MatchPredicates property is set
        internal bool IsSetMatchPredicates()
        {
            return this._matchPredicates != null && (this._matchPredicates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for a <c>RateBasedRule</c>. The name
        /// can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length 128
        /// and minimum length one. It can't contain whitespace or metric names reserved for AWS
        /// WAF, including "All" and "Default_Action." You can't change the name of the metric
        /// after you create the <c>RateBasedRule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// A friendly name or description for a <c>RateBasedRule</c>. You can't change the name
        /// of a <c>RateBasedRule</c> after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// source and thus subject to rate monitoring. The only valid value for <c>RateKey</c>
        /// is <c>IP</c>. <c>IP</c> indicates that requests arriving from the same IP address
        /// are subject to the <c>RateLimit</c> that is specified in the <c>RateBasedRule</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A unique identifier for a <c>RateBasedRule</c>. You use <c>RuleId</c> to get more
        /// information about a <c>RateBasedRule</c> (see <a>GetRateBasedRule</a>), update a <c>RateBasedRule</c>
        /// (see <a>UpdateRateBasedRule</a>), insert a <c>RateBasedRule</c> into a <c>WebACL</c>
        /// or delete one from a <c>WebACL</c> (see <a>UpdateWebACL</a>), or delete a <c>RateBasedRule</c>
        /// from AWS WAF (see <a>DeleteRateBasedRule</a>).
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

    }
}