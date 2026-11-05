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
        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// Displays whether the rule is evaluated on the transformed versions of logs, for log
        /// groups that have <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">Log
        /// transformation</a> enabled. If this is <c>false</c>, log events are evaluated before
        /// they are transformed.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs { get; set; }

        /// <summary>
        /// Checks to see if the ApplyOnTransformedLogs property is set.
        /// </summary>
        internal bool IsSetApplyOnTransformedLogs() => this.ApplyOnTransformedLogs.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of the rule, as a JSON object. The definition contains the keywords
        /// used to define contributors, the value to aggregate on if this rule returns a sum
        /// instead of a count, and the filters. For details on the valid syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights-RuleSyntax.html">Contributor
        /// Insights Rule Syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property ManagedRule. 
        /// <para>
        ///  An optional built-in rule that Amazon Web Services manages. 
        /// </para>
        /// </summary>
        public bool? ManagedRule { get; set; }

        /// <summary>
        /// Checks to see if the ManagedRule property is set.
        /// </summary>
        internal bool IsSetManagedRule() => this.ManagedRule.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// For rules that you create, this is always <c>{"Name": "CloudWatchLogRule", "Version":
        /// 1}</c>. For managed rules, this is <c>{"Name": "ServiceLogRule", "Version": 1}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the rule is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
