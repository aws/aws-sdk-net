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
    /// Provides information about an WAF Regional rule. This rule identifies the web requests
    /// that you want to allow, block, or count.
    /// </summary>
    public partial class AwsWafRegionalRuleDetails
    {
        private string _metricName;
        private string _name;
        private List<AwsWafRegionalRulePredicateListDetails> _predicateList = AWSConfigs.InitializeCollections ? new List<AwsWafRegionalRulePredicateListDetails>() : null;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A name for the metrics for the rule. 
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
        /// A descriptive name for the rule. 
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
        /// Gets and sets the property PredicateList. 
        /// <para>
        /// Specifies the <c>ByteMatchSet</c>, <c>IPSet</c>, <c>SqlInjectionMatchSet</c>, <c>XssMatchSet</c>,
        /// <c>RegexMatchSet</c>, <c>GeoMatchSet</c>, and <c>SizeConstraintSet</c> objects that
        /// you want to add to a rule and, for each object, indicates whether you want to negate
        /// the settings. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafRegionalRulePredicateListDetails> PredicateList
        {
            get { return this._predicateList; }
            set { this._predicateList = value; }
        }

        // Check to see if PredicateList property is set
        internal bool IsSetPredicateList()
        {
            return this._predicateList != null && (this._predicateList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The ID of the rule. 
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