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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure contains the definition for a Contributor Insights rule. For more information
    /// about this rule, see<a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights.html">
    /// Using Constributor Insights to analyze high-cardinality data</a> in the <i>Amazon
    /// CloudWatch User Guide</i>.
    /// </summary>
    public partial class InsightRule
    {
        private bool? _applyOnTransformedLogs;
        private string _definition;
        private bool? _managedRule;
        private string _name;
        private string _schema;
        private string _state;

        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// Displays whether the rule is evaluated on the transformed versions of logs, for log
        /// groups that have <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">Log
        /// transformation</a> enabled. If this is <c>false</c>, log events are evaluated before
        /// they are transformed.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs
        {
            get { return this._applyOnTransformedLogs; }
            set { this._applyOnTransformedLogs = value; }
        }

        // Check to see if ApplyOnTransformedLogs property is set
        internal bool IsSetApplyOnTransformedLogs()
        {
            return this._applyOnTransformedLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the rule, as a JSON object. The definition contains the keywords
        /// used to define contributors, the value to aggregate on if this rule returns a sum
        /// instead of a count, and the filters. For details on the valid syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights-RuleSyntax.html">Contributor
        /// Insights Rule Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedRule. 
        /// <para>
        ///  An optional built-in rule that Amazon Web Services manages. 
        /// </para>
        /// </summary>
        public bool? ManagedRule
        {
            get { return this._managedRule; }
            set { this._managedRule = value; }
        }

        // Check to see if ManagedRule property is set
        internal bool IsSetManagedRule()
        {
            return this._managedRule.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Schema. 
        /// <para>
        /// For rules that you create, this is always <c>{"Name": "CloudWatchLogRule", "Version":
        /// 1}</c>. For managed rules, this is <c>{"Name": "ServiceLogRule", "Version": 1}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the rule is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}