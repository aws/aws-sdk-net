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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rate-based rule tracks the rate of requests for each originating IP address, and
    /// triggers the rule action when the rate exceeds a limit that you specify on the number
    /// of requests in any 5-minute time span. You can use this to put a temporary block on
    /// requests from an IP address that is sending excessive requests. 
    /// 
    ///  
    /// <para>
    /// WAF tracks and manages web requests separately for each instance of a rate-based rule
    /// that you use. For example, if you provide the same rate-based rule settings in two
    /// web ACLs, each of the two rule statements represents a separate instance of the rate-based
    /// rule and gets its own tracking and management by WAF. If you define a rate-based rule
    /// inside a rule group, and then use that rule group in multiple places, each use creates
    /// a separate instance of the rate-based rule that gets its own tracking and management
    /// by WAF. 
    /// </para>
    ///  
    /// <para>
    /// When the rule action triggers, WAF blocks additional requests from the IP address
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
    /// An IP match statement with an IP set that specifies the address 192.0.2.44.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A string match statement that searches in the User-Agent header for the string BadBot.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In this rate-based rule, you also define a rate limit. For this example, the rate
    /// limit is 1,000. Requests that meet the criteria of both of the nested statements are
    /// counted. If the count exceeds 1,000 requests per five minutes, the rule action triggers.
    /// Requests that do not meet the criteria of both of the nested statements are not counted
    /// towards the rate limit and are not affected by this rule.
    /// </para>
    ///  
    /// <para>
    /// You cannot nest a <code>RateBasedStatement</code> inside another statement, for example
    /// inside a <code>NotStatement</code> or <code>OrStatement</code>. You can define a <code>RateBasedStatement</code>
    /// inside a web ACL and inside a rule group. 
    /// </para>
    /// </summary>
    public partial class RateBasedStatement
    {
        private RateBasedStatementAggregateKeyType _aggregateKeyType;
        private ForwardedIPConfig _forwardedIPConfig;
        private long? _limit;
        private Statement _scopeDownStatement;

        /// <summary>
        /// Gets and sets the property AggregateKeyType. 
        /// <para>
        /// Setting that indicates how to aggregate the request counts. The options are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IP - Aggregate the request counts on the IP address from the web request origin.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORWARDED_IP - Aggregate the request counts on the first IP address in an HTTP header.
        /// If you use this, configure the <code>ForwardedIPConfig</code>, to specify the header
        /// to use. 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ForwardedIPConfig. 
        /// <para>
        /// The configuration for inspecting IP addresses in an HTTP header that you specify,
        /// instead of using the IP address that's reported by the web request origin. Commonly,
        /// this is the X-Forwarded-For (XFF) header, but you can specify any header name. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the specified header isn't present in the request, WAF doesn't apply the rule to
        /// the web request at all.
        /// </para>
        ///  </note> 
        /// <para>
        /// This is required if <code>AggregateKeyType</code> is set to <code>FORWARDED_IP</code>.
        /// </para>
        /// </summary>
        public ForwardedIPConfig ForwardedIPConfig
        {
            get { return this._forwardedIPConfig; }
            set { this._forwardedIPConfig = value; }
        }

        // Check to see if ForwardedIPConfig property is set
        internal bool IsSetForwardedIPConfig()
        {
            return this._forwardedIPConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The limit on requests per 5-minute period for a single originating IP address. If
        /// the statement includes a <code>ScopeDownStatement</code>, this limit is applied only
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
        /// An optional nested statement that narrows the scope of the web requests that are evaluated
        /// by the rate-based statement. Requests are only tracked by the rate-based statement
        /// if they match the scope-down statement. You can use any nestable <a>Statement</a>
        /// in the scope-down statement, and you can nest statements at any level, the same as
        /// you can for a rule statement. 
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