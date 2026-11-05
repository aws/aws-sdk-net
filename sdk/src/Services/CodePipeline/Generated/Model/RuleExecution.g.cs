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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about each time a rule is run as part of the pipeline execution
    /// for a pipeline configured with conditions.
    /// </summary>
    public partial class RuleExecution
    {
        /// <summary>
        /// Gets and sets the property ErrorDetails.
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The external ID of the run of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1500)]
        public string ExternalExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalExecutionId property is set.
        /// </summary>
        internal bool IsSetExternalExecutionId() => this.ExternalExecutionId != null;

        /// <summary>
        /// Gets and sets the property ExternalExecutionUrl. 
        /// <para>
        /// The URL of a resource external to Amazon Web Services that is used when running the
        /// rule (for example, an external repository URL).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExternalExecutionUrl { get; set; }

        /// <summary>
        /// Checks to see if the ExternalExecutionUrl property is set.
        /// </summary>
        internal bool IsSetExternalExecutionUrl() => this.ExternalExecutionUrl != null;

        /// <summary>
        /// Gets and sets the property LastStatusChange. 
        /// <para>
        /// The last status change of the rule.
        /// </para>
        /// </summary>
        public DateTime? LastStatusChange { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusChange property is set.
        /// </summary>
        internal bool IsSetLastStatusChange() => this.LastStatusChange.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The ARN of the user who last changed the rule.
        /// </para>
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property RuleExecutionId. 
        /// <para>
        /// The execution ID for the run of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string RuleExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the RuleExecutionId property is set.
        /// </summary>
        internal bool IsSetRuleExecutionId() => this.RuleExecutionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the run of the rule, such as FAILED.
        /// </para>
        /// </summary>
        public RuleExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A summary of the run of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The system-generated token used to identify a unique request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;
    }
}
