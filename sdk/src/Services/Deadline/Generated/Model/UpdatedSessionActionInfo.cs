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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The updated session action information as it relates to completion and progress of
    /// the session.
    /// </summary>
    public partial class UpdatedSessionActionInfo
    {
        private CompletedStatus _completedStatus;
        private DateTime? _endedAt;
        private int? _processExitCode;
        private string _progressMessage;
        private float? _progressPercent;
        private DateTime? _startedAt;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CompletedStatus. 
        /// <para>
        /// The status of the session upon completion.
        /// </para>
        /// </summary>
        public CompletedStatus CompletedStatus
        {
            get { return this._completedStatus; }
            set { this._completedStatus = value; }
        }

        // Check to see if CompletedStatus property is set
        internal bool IsSetCompletedStatus()
        {
            return this._completedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessExitCode. 
        /// <para>
        /// The process exit code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int ProcessExitCode
        {
            get { return this._processExitCode.GetValueOrDefault(); }
            set { this._processExitCode = value; }
        }

        // Check to see if ProcessExitCode property is set
        internal bool IsSetProcessExitCode()
        {
            return this._processExitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressMessage. 
        /// <para>
        /// A message to indicate the progress of the updated session action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string ProgressMessage
        {
            get { return this._progressMessage; }
            set { this._progressMessage = value; }
        }

        // Check to see if ProgressMessage property is set
        internal bool IsSetProgressMessage()
        {
            return this._progressMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The percentage completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float ProgressPercent
        {
            get { return this._progressPercent.GetValueOrDefault(); }
            set { this._progressPercent = value; }
        }

        // Check to see if ProgressPercent property is set
        internal bool IsSetProgressPercent()
        {
            return this._progressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The updated time.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}