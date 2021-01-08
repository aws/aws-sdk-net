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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the EnableInsightRules operation.
    /// Enables the specified Contributor Insights rules. When rules are enabled, they immediately
    /// begin analyzing log data.
    /// </summary>
    public partial class EnableInsightRulesRequest : AmazonCloudWatchRequest
    {
        private List<string> _ruleNames = new List<string>();

        /// <summary>
        /// Gets and sets the property RuleNames. 
        /// <para>
        /// An array of the rule names to enable. If you need to find out the names of your rules,
        /// use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeInsightRules.html">DescribeInsightRules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RuleNames
        {
            get { return this._ruleNames; }
            set { this._ruleNames = value; }
        }

        // Check to see if RuleNames property is set
        internal bool IsSetRuleNames()
        {
            return this._ruleNames != null && this._ruleNames.Count > 0; 
        }

    }
}