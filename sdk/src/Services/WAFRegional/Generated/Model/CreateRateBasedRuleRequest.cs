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
    /// Container for the parameters to the CreateRateBasedRule operation.
    /// Creates a <a>RateBasedRule</a>. The <code>RateBasedRule</code> contains a <code>RateLimit</code>,
    /// which specifies the maximum number of requests that AWS WAF allows from a specified
    /// IP address in a five-minute period. The <code>RateBasedRule</code> also contains the
    /// <code>IPSet</code> objects, <code>ByteMatchSet</code> objects, and other predicates
    /// that identify the requests that you want to count or block if these requests exceed
    /// the <code>RateLimit</code>.
    /// 
    ///  
    /// <para>
    /// If you add more than one predicate to a <code>RateBasedRule</code>, a request not
    /// only must exceed the <code>RateLimit</code>, but it also must match all the specifications
    /// to be counted or blocked. For example, suppose you add the following to a <code>RateBasedRule</code>:
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
    /// you want to block requests that meet the conditions in the rule. For a request to
    /// be blocked, it must come from the IP address 192.0.2.44 <i>and</i> the <code>User-Agent</code>
    /// header in the request must contain the value <code>BadBot</code>. Further, requests
    /// that match these two conditions must be received at a rate of more than 15,000 requests
    /// every five minutes. If both conditions are met and the rate is exceeded, AWS WAF blocks
    /// the requests. If the rate drops below 15,000 for a five-minute period, AWS WAF no
    /// longer blocks the requests.
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
    ///  
    /// <para>
    /// To create and configure a <code>RateBasedRule</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the predicates that you want to include in the rule. For more information,
    /// see <a>CreateByteMatchSet</a>, <a>CreateIPSet</a>, and <a>CreateSqlInjectionMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of a <code>CreateRule</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a <code>CreateRateBasedRule</code> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateRule</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateRateBasedRule</code> request to specify the predicates that
    /// you want to include in the rule.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update a <code>WebACL</code> that contains the <code>RateBasedRule</code>.
    /// For more information, see <a>CreateWebACL</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateRateBasedRuleRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _metricName;
        private string _name;
        private RateKey _rateKey;
        private long? _rateLimit;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The <code>ChangeToken</code> that you used to submit the <code>CreateRateBasedRule</code>
        /// request. You can also use this value to query the status of the request. For more
        /// information, see <a>GetChangeTokenStatus</a>.
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <code>RateBasedRule</code>.
        /// The name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't
        /// contain whitespace. You can't change the name of the metric after you create the <code>RateBasedRule</code>.
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
        /// A friendly name or description of the <a>RateBasedRule</a>. You can't change the name
        /// of a <code>RateBasedRule</code> after you create it.
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
        /// The field that AWS WAF uses to determine if requests are likely arriving from a single
        /// source and thus subject to rate monitoring. The only valid value for <code>RateKey</code>
        /// is <code>IP</code>. <code>IP</code> indicates that requests that arrive from the same
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
        /// The maximum number of requests, which have an identical value in the field that is
        /// specified by <code>RateKey</code>, allowed in a five-minute period. If the number
        /// of requests exceeds the <code>RateLimit</code> and the other predicates specified
        /// in the rule are also met, AWS WAF triggers the action that is specified for this rule.
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

    }
}