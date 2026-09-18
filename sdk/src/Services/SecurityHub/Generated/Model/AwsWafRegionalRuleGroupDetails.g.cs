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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides information about an WAF Regional rule group. The rule group is a collection
    /// of rules for inspecting and controlling web requests.
    /// </summary>
    public partial class AwsWafRegionalRuleGroupDetails
    {
        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A name for the metrics for this rule group. 
        /// </para>
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The descriptive name of the rule group. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The ID of the rule group. 
        /// </para>
        /// </summary>
        public string RuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupId property is set.
        /// </summary>
        internal bool IsSetRuleGroupId() => this.RuleGroupId != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Provides information about the rule statements used to identify the web requests that
        /// you want to allow, block, or count. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafRegionalRuleGroupRulesDetails> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsWafRegionalRuleGroupRulesDetails>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
