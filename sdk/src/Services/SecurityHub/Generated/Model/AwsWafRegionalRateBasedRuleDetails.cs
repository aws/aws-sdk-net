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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// contains details about a rate-based rule for Regional resources. A rate-based rule
    /// provides settings to indicate when to allow, block, or count a request. Rate-based
    /// rules include the number of requests that arrive over a specified period of time.
    /// </summary>
    public partial class AwsWafRegionalRateBasedRuleDetails
    {
        private List<AwsWafRegionalRateBasedRuleMatchPredicate> _matchPredicates = AWSConfigs.InitializeCollections ? new List<AwsWafRegionalRateBasedRuleMatchPredicate>() : null;
        private string _metricName;
        private string _name;
        private string _rateKey;
        private long? _rateLimit;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property MatchPredicates. 
        /// <para>
        /// The predicates to include in the rate-based rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafRegionalRateBasedRuleMatchPredicate> MatchPredicates
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
        /// The name of the metrics for the rate-based rule.
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
        /// The name of the rate-based rule.
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
        /// The field that WAF uses to determine whether requests are likely arriving from single
        /// source and are subject to rate monitoring.
        /// </para>
        /// </summary>
        public string RateKey
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
        /// The maximum number of requests that have an identical value for the field specified
        /// in <c>RateKey</c> that are allowed within a five-minute period. If the number of requests
        /// exceeds <c>RateLimit</c> and the other predicates specified in the rule are met, WAF
        /// triggers the action for the rule.
        /// </para>
        /// </summary>
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
        /// The unique identifier for the rate-based rule.
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