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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rate-based rule counts incoming requests and rate limits requests when they are
    /// coming at too fast a rate. The rule categorizes requests according to your aggregation
    /// criteria, collects them into aggregation instances, and counts and rate limits the
    /// requests for each instance. 
    /// 
    ///  <note> 
    /// <para>
    /// If you change any of these settings in a rule that's currently in use, the change
    /// resets the rule's rate limiting counts. This can pause the rule's rate limiting activities
    /// for up to a minute. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You can specify individual aggregation keys, like IP address or HTTP method. You can
    /// also specify aggregation key combinations, like IP address and HTTP method, or HTTP
    /// method, query argument, and cookie. 
    /// </para>
    ///  
    /// <para>
    /// Each unique set of values for the aggregation keys that you specify is a separate
    /// aggregation instance, with the value from each key contributing to the aggregation
    /// instance definition. 
    /// </para>
    ///  
    /// <para>
    /// For example, assume the rule evaluates web requests with the following IP address
    /// and HTTP method values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// IP address 10.1.1.1, HTTP method POST
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP address 10.1.1.1, HTTP method GET
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP address 127.0.0.0, HTTP method POST
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP address 10.1.1.1, HTTP method GET
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The rule would create different aggregation instances according to your aggregation
    /// criteria, for example: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the aggregation criteria is just the IP address, then each individual address is
    /// an aggregation instance, and WAF counts requests separately for each. The aggregation
    /// instances and request counts for our example would be the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// IP address 10.1.1.1: count 3
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP address 127.0.0.0: count 1
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// If the aggregation criteria is HTTP method, then each individual HTTP method is an
    /// aggregation instance. The aggregation instances and request counts for our example
    /// would be the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// HTTP method POST: count 2
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP method GET: count 2
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// If the aggregation criteria is IP address and HTTP method, then each IP address and
    /// each HTTP method would contribute to the combined aggregation instance. The aggregation
    /// instances and request counts for our example would be the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// IP address 10.1.1.1, HTTP method POST: count 1
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP address 10.1.1.1, HTTP method GET: count 2
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IP address 127.0.0.0, HTTP method POST: count 1
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For any n-tuple of aggregation keys, each unique combination of values for the keys
    /// defines a separate aggregation instance, which WAF counts and rate-limits individually.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can optionally nest another statement inside the rate-based statement, to narrow
    /// the scope of the rule so that it only counts and rate limits requests that match the
    /// nested statement. You can use this nested scope-down statement in conjunction with
    /// your aggregation key specifications or you can just count and rate limit all requests
    /// that match the scope-down statement, without additional aggregation. When you choose
    /// to just manage all requests that match a scope-down statement, the aggregation instance
    /// is singular for the rule. 
    /// </para>
    ///  
    /// <para>
    /// You cannot nest a <c>RateBasedStatement</c> inside another statement, for example
    /// inside a <c>NotStatement</c> or <c>OrStatement</c>. You can define a <c>RateBasedStatement</c>
    /// inside a web ACL and inside a rule group. 
    /// </para>
    ///  
    /// <para>
    /// For additional information about the options, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rate-based-rules.html">Rate
    /// limiting web requests using rate-based rules</a> in the <i>WAF Developer Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If you only aggregate on the individual IP address or forwarded IP address, you can
    /// retrieve the list of IP addresses that WAF is currently rate limiting for a rule through
    /// the API call <c>GetRateBasedStatementManagedKeys</c>. This option is not available
    /// for other aggregation configurations.
    /// </para>
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
    /// </summary>
    public partial class RateBasedStatement
    {
        private RateBasedStatementAggregateKeyType _aggregateKeyType;
        private List<RateBasedStatementCustomKey> _customKeys = AWSConfigs.InitializeCollections ? new List<RateBasedStatementCustomKey>() : null;
        private long? _evaluationWindowSec;
        private ForwardedIPConfig _forwardedIPConfig;
        private long? _limit;
        private Statement _scopeDownStatement;

        /// <summary>
        /// Gets and sets the property AggregateKeyType. 
        /// <para>
        /// Setting that indicates how to aggregate the request counts. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Web requests that are missing any of the components specified in the aggregation keys
        /// are omitted from the rate-based rule evaluation and handling. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>CONSTANT</c> - Count and limit the requests that match the rate-based rule's scope-down
        /// statement. With this option, the counted requests aren't further aggregated. The scope-down
        /// statement is the only specification used. When the count of all requests that satisfy
        /// the scope-down statement goes over the limit, WAF applies the rule action to all requests
        /// that satisfy the scope-down statement. 
        /// </para>
        ///  
        /// <para>
        /// With this option, you must configure the <c>ScopeDownStatement</c> property. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_KEYS</c> - Aggregate the request counts using one or more web request components
        /// as the aggregate keys.
        /// </para>
        ///  
        /// <para>
        /// With this option, you must specify the aggregate keys in the <c>CustomKeys</c> property.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To aggregate on only the IP address or only the forwarded IP address, don't use custom
        /// keys. Instead, set the aggregate key type to <c>IP</c> or <c>FORWARDED_IP</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORWARDED_IP</c> - Aggregate the request counts on the first IP address in an
        /// HTTP header. 
        /// </para>
        ///  
        /// <para>
        /// With this option, you must specify the header to use in the <c>ForwardedIPConfig</c>
        /// property. 
        /// </para>
        ///  
        /// <para>
        /// To aggregate on a combination of the forwarded IP address with other aggregate keys,
        /// use <c>CUSTOM_KEYS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IP</c> - Aggregate the request counts on the IP address from the web request origin.
        /// </para>
        ///  
        /// <para>
        /// To aggregate on a combination of the IP address with other aggregate keys, use <c>CUSTOM_KEYS</c>.
        /// 
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
        /// Gets and sets the property CustomKeys. 
        /// <para>
        /// Specifies the aggregate keys to use in a rate-base rule. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<RateBasedStatementCustomKey> CustomKeys
        {
            get { return this._customKeys; }
            set { this._customKeys = value; }
        }

        // Check to see if CustomKeys property is set
        internal bool IsSetCustomKeys()
        {
            return this._customKeys != null && (this._customKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationWindowSec. 
        /// <para>
        /// The amount of time, in seconds, that WAF should include in its request counts, looking
        /// back from the current time. For example, for a setting of 120, when WAF checks the
        /// rate, it counts the requests for the 2 minutes immediately preceding the current time.
        /// Valid settings are 60, 120, 300, and 600. 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't determine how often WAF checks the rate, but how far back it
        /// looks each time it checks. WAF checks the rate about every 10 seconds.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>300</c> (5 minutes)
        /// </para>
        /// </summary>
        public long? EvaluationWindowSec
        {
            get { return this._evaluationWindowSec; }
            set { this._evaluationWindowSec = value; }
        }

        // Check to see if EvaluationWindowSec property is set
        internal bool IsSetEvaluationWindowSec()
        {
            return this._evaluationWindowSec.HasValue; 
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
        /// This is required if you specify a forwarded IP in the rule's aggregate key settings.
        /// 
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
        /// The limit on requests during the specified evaluation window for a single aggregation
        /// instance for the rate-based rule. If the rate-based statement includes a <c>ScopeDownStatement</c>,
        /// this limit is applied only to the requests that match the statement.
        /// </para>
        ///  
        /// <para>
        /// Examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you aggregate on just the IP address, this is the limit on requests from any single
        /// IP address. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you aggregate on the HTTP method and the query argument name "city", then this
        /// is the limit on requests for any single method, city pair. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=2000000000)]
        public long? Limit
        {
            get { return this._limit; }
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
        /// and managed by the rate-based statement. When you use a scope-down statement, the
        /// rate-based rule only tracks and rate limits requests that match the scope-down statement.
        /// You can use any nestable <a>Statement</a> in the scope-down statement, and you can
        /// nest statements at any level, the same as you can for a rule statement. 
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