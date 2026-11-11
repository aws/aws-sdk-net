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
    /// Represents information about the run of an action.
    /// </summary>
    public partial class ActionExecution
    {
        /// <summary>
        /// Gets and sets the property ActionExecutionId. 
        /// <para>
        /// ID of the workflow action execution in the current stage. Use the <a>GetPipelineState</a>
        /// action to retrieve the current action execution details of the current stage.
        /// </para>
        ///  <note> 
        /// <para>
        /// For older executions, this field might be empty. The action execution ID is available
        /// for executions run on or after March 2020.
        /// </para>
        ///  </note>
        /// </summary>
        public string ActionExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionExecutionId property is set.
        /// </summary>
        internal bool IsSetActionExecutionId() => this.ActionExecutionId != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The details of an error returned by a URL external to Amazon Web Services.
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The external ID of the run of the action.
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
        /// action (for example, an external repository URL).
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
        /// The last status change of the action.
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
        /// The ARN of the user who last changed the pipeline.
        /// </para>
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property LogStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log stream for the action compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string LogStreamARN { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamARN property is set.
        /// </summary>
        internal bool IsSetLogStreamARN() => this.LogStreamARN != null;

        /// <summary>
        /// Gets and sets the property PercentComplete. 
        /// <para>
        /// A percentage of completeness of the action as it runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Checks to see if the PercentComplete property is set.
        /// </summary>
        internal bool IsSetPercentComplete() => this.PercentComplete.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action, or for a completed action, the last status of the action.
        /// </para>
        /// </summary>
        public ActionExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A summary of the run of the action.
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
        /// The system-generated token used to identify a unique approval request. The token for
        /// each open approval request can be obtained using the <c>GetPipelineState</c> command.
        /// It is used to validate that the approval request corresponding to this token is still
        /// valid.
        /// </para>
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;
    }
}
