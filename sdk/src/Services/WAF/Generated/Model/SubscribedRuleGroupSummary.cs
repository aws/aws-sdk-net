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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// A summary of the rule groups you are subscribed to.
    /// </summary>
    public partial class SubscribedRuleGroupSummary
    {
        private string _metricName;
        private string _name;
        private string _ruleGroupId;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <code>RuleGroup</code>. The
        /// name can contain only alphanumeric characters (A-Z, a-z, 0-9); the name can't contain
        /// whitespace. You can't change the name of the metric after you create the <code>RuleGroup</code>.
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
        /// A friendly name or description of the <code>RuleGroup</code>. You can't change the
        /// name of a <code>RuleGroup</code> after you create it.
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
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// A unique identifier for a <code>RuleGroup</code>.
        /// </para>
        /// </summary>
        public string RuleGroupId
        {
            get { return this._ruleGroupId; }
            set { this._ruleGroupId = value; }
        }

        // Check to see if RuleGroupId property is set
        internal bool IsSetRuleGroupId()
        {
            return this._ruleGroupId != null;
        }

    }
}