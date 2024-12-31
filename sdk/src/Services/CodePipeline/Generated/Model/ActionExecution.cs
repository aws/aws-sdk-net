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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
        private string _actionExecutionId;
        private ErrorDetails _errorDetails;
        private string _externalExecutionId;
        private string _externalExecutionUrl;
        private DateTime? _lastStatusChange;
        private string _lastUpdatedBy;
        private string _logStreamARN;
        private int? _percentComplete;
        private ActionExecutionStatus _status;
        private string _summary;
        private string _token;

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
        public string ActionExecutionId
        {
            get { return this._actionExecutionId; }
            set { this._actionExecutionId = value; }
        }

        // Check to see if ActionExecutionId property is set
        internal bool IsSetActionExecutionId()
        {
            return this._actionExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The details of an error returned by a URL external to Amazon Web Services.
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The external ID of the run of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1500)]
        public string ExternalExecutionId
        {
            get { return this._externalExecutionId; }
            set { this._externalExecutionId = value; }
        }

        // Check to see if ExternalExecutionId property is set
        internal bool IsSetExternalExecutionId()
        {
            return this._externalExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalExecutionUrl. 
        /// <para>
        /// The URL of a resource external to Amazon Web Services that is used when running the
        /// action (for example, an external repository URL).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExternalExecutionUrl
        {
            get { return this._externalExecutionUrl; }
            set { this._externalExecutionUrl = value; }
        }

        // Check to see if ExternalExecutionUrl property is set
        internal bool IsSetExternalExecutionUrl()
        {
            return this._externalExecutionUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatusChange. 
        /// <para>
        /// The last status change of the action.
        /// </para>
        /// </summary>
        public DateTime? LastStatusChange
        {
            get { return this._lastStatusChange; }
            set { this._lastStatusChange = value; }
        }

        // Check to see if LastStatusChange property is set
        internal bool IsSetLastStatusChange()
        {
            return this._lastStatusChange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The ARN of the user who last changed the pipeline.
        /// </para>
        /// </summary>
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LogStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log stream for the action compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string LogStreamARN
        {
            get { return this._logStreamARN; }
            set { this._logStreamARN = value; }
        }

        // Check to see if LogStreamARN property is set
        internal bool IsSetLogStreamARN()
        {
            return this._logStreamARN != null;
        }

        /// <summary>
        /// Gets and sets the property PercentComplete. 
        /// <para>
        /// A percentage of completeness of the action as it runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }

        // Check to see if PercentComplete property is set
        internal bool IsSetPercentComplete()
        {
            return this._percentComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action, or for a completed action, the last status of the action.
        /// </para>
        /// </summary>
        public ActionExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A summary of the run of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The system-generated token used to identify a unique approval request. The token for
        /// each open approval request can be obtained using the <c>GetPipelineState</c> command.
        /// It is used to validate that the approval request corresponding to this token is still
        /// valid.
        /// </para>
        /// </summary>
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}