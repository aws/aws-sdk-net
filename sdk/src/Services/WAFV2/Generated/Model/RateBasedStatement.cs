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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// A rate-based rule tracks the rate of requests for each originating IP address, and
    /// triggers the rule action when the rate exceeds a limit that you specify on the number
    /// of requests in any 5-minute time span. You can use this to put a temporary block on
    /// requests from an IP address that is sending excessive requests.
    /// </para>
    ///  
    /// <para>
    /// When the rule action triggers, AWS WAF blocks additional requests from the IP address
    /// until the request rate falls below the limit.
    /// </para>
    ///  
    /// <para>
    /// You can optionally nest another statement inside the rate-based statement, to narrow
    /// the scope of the rule so that it only counts requests that match the nested statement.
    /// For example, based on recent requests that you have seen from an attacker, you might
    /// create a rate-based rule with a nested AND rule statement that contains the following
    /// nested statements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An IP match statement with an IP set that specified the address 192.0.2.44.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A string match statement that searches in the User-Agent header for the string BadBot.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In this rate-based rule, you also define a rate limit. For this example, the rate
    /// limit is 1,000. Requests that meet both of the conditions in the statements are counted.
    /// If the count exceeds 1,000 requests per five minutes, the rule action triggers. Requests
    /// that do not meet both conditions are not counted towards the rate limit and are not
    /// affected by this rule.
    /// </para>
    ///  
    /// <para>
    /// You cannot nest a <code>RateBasedStatement</code>, for example for use inside a <code>NotStatement</code>
    /// or <code>OrStatement</code>. It can only be referenced as a top-level statement within
    /// a rule.
    /// </para>
    /// </summary>
    public partial class RateBasedStatement
    {
        private RateBasedStatementAggregateKeyType _aggregateKeyType;
        private long? _limit;
        private Statement _scopeDownStatement;

        /// <summary>
        /// Gets and sets the property AggregateKeyType. 
        /// <para>
        /// Setting that indicates how to aggregate the request counts. Currently, you must set
        /// this to <code>IP</code>. The request counts are aggregated on IP addresses. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RateBasedStatementAggregateKeyType AggregateKeyType
        {
            get { return this._aggregateKeyType; }
            set { this._aggregateKeyType = value; }
        }

        // Check to see if AggregateKeyType property is set
        internal bool IsSetAggregateKeyType()
        {
            return this._aggregateKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The limit on requests per 5-minute period for a single originating IP address. If
        /// the statement includes a <code>ScopDownStatement</code>, this limit is applied only
        /// to the requests that match the statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=100, Max=2000000000)]
        public long Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScopeDownStatement. 
        /// <para>
        /// An optional nested statement that narrows the scope of the rate-based statement to
        /// matching web requests. This can be any nestable statement, and you can nest statements
        /// at any level below this scope-down statement.
        /// </para>
        /// </summary>
        public Statement ScopeDownStatement
        {
            get { return this._scopeDownStatement; }
            set { this._scopeDownStatement = value; }
        }

        // Check to see if ScopeDownStatement property is set
        internal bool IsSetScopeDownStatement()
        {
            return this._scopeDownStatement != null;
        }

    }
}