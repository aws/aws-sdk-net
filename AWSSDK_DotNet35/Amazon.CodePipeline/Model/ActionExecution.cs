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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about how an action runs.
    /// </summary>
    public partial class ActionExecution
    {
        private ErrorDetails _errorDetails;
        private string _externalExecutionId;
        private string _externalExecutionUrl;
        private DateTime? _lastStatusChange;
        private int? _percentComplete;
        private ActionExecutionStatus _status;
        private string _summary;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The details of an error returned by a URL external to AWS.
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
        /// The URL of a resource external to AWS that will be used when running the action, for
        /// example an external repository URL.
        /// </para>
        /// </summary>
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
        public DateTime LastStatusChange
        {
            get { return this._lastStatusChange.GetValueOrDefault(); }
            set { this._lastStatusChange = value; }
        }

        // Check to see if LastStatusChange property is set
        internal bool IsSetLastStatusChange()
        {
            return this._lastStatusChange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentComplete. 
        /// <para>
        /// A percentage of completeness of the action as it runs.
        /// </para>
        /// </summary>
        public int PercentComplete
        {
            get { return this._percentComplete.GetValueOrDefault(); }
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

    }
}