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
    /// Container for the parameters to the PutInsightRule operation.
    /// Creates a Contributor Insights rule. Rules evaluate log events in a CloudWatch Logs
    /// log group, enabling you to find contributor data for the log events in that log group.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights.html">Using
    /// Contributor Insights to Analyze High-Cardinality Data</a>.
    /// 
    ///  
    /// <para>
    /// If you create a rule, delete it, and then re-create it with the same name, historical
    /// data from the first time the rule was created might not be available.
    /// </para>
    /// </summary>
    public partial class PutInsightRuleRequest : AmazonCloudWatchRequest
    {
        private string _ruleDefinition;
        private string _ruleName;
        private string _ruleState;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property RuleDefinition. 
        /// <para>
        /// The definition of the rule, as a JSON object. For details on the valid syntax, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights-RuleSyntax.html">Contributor
        /// Insights Rule Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string RuleDefinition
        {
            get { return this._ruleDefinition; }
            set { this._ruleDefinition = value; }
        }

        // Check to see if RuleDefinition property is set
        internal bool IsSetRuleDefinition()
        {
            return this._ruleDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// A unique name for the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleState. 
        /// <para>
        /// The state of the rule. Valid values are ENABLED and DISABLED.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string RuleState
        {
            get { return this._ruleState; }
            set { this._ruleState = value; }
        }

        // Check to see if RuleState property is set
        internal bool IsSetRuleState()
        {
            return this._ruleState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the Contributor Insights rule. You can
        /// associate as many as 50 tags with a rule.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only the
        /// resources that have certain tag values.
        /// </para>
        ///  
        /// <para>
        /// To be able to associate tags with a rule, you must have the <code>cloudwatch:TagResource</code>
        /// permission in addition to the <code>cloudwatch:PutInsightRule</code> permission.
        /// </para>
        ///  
        /// <para>
        /// If you are using this operation to update an existing Contributor Insights rule, any
        /// tags you specify in this parameter are ignored. To change the tags of an existing
        /// rule, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}