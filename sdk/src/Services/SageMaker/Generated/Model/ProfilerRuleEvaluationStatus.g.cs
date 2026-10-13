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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the status of the rule evaluation.
    /// </summary>
    public partial class ProfilerRuleEvaluationStatus
    {
        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Timestamp when the rule evaluation status was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RuleConfigurationName. 
        /// <para>
        /// The name of the rule configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RuleConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the RuleConfigurationName property is set.
        /// </summary>
        internal bool IsSetRuleConfigurationName() => this.RuleConfigurationName != null;

        /// <summary>
        /// Gets and sets the property RuleEvaluationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RuleEvaluationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleEvaluationJobArn property is set.
        /// </summary>
        internal bool IsSetRuleEvaluationJobArn() => this.RuleEvaluationJobArn != null;

        /// <summary>
        /// Gets and sets the property RuleEvaluationStatus. 
        /// <para>
        /// Status of the rule evaluation.
        /// </para>
        /// </summary>
        public RuleEvaluationStatus RuleEvaluationStatus { get; set; }

        /// <summary>
        /// Checks to see if the RuleEvaluationStatus property is set.
        /// </summary>
        internal bool IsSetRuleEvaluationStatus() => this.RuleEvaluationStatus != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Details from the rule evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;
    }
}
