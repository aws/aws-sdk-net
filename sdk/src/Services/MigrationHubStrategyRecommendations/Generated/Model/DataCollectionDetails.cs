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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Detailed information about an assessment.
    /// </summary>
    public partial class DataCollectionDetails
    {
        private DateTime? _completionTime;
        private int? _failed;
        private int? _inProgress;
        private int? _servers;
        private DateTime? _startTime;
        private AssessmentStatus _status;
        private string _statusMessage;
        private int? _success;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        ///  The time the assessment completes. 
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        ///  The number of failed servers in the assessment. 
        /// </para>
        /// </summary>
        public int Failed
        {
            get { return this._failed.GetValueOrDefault(); }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InProgress. 
        /// <para>
        ///  The number of servers with the assessment status <code>IN_PROGESS</code>. 
        /// </para>
        /// </summary>
        public int InProgress
        {
            get { return this._inProgress.GetValueOrDefault(); }
            set { this._inProgress = value; }
        }

        // Check to see if InProgress property is set
        internal bool IsSetInProgress()
        {
            return this._inProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        ///  The total number of servers in the assessment. 
        /// </para>
        /// </summary>
        public int Servers
        {
            get { return this._servers.GetValueOrDefault(); }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of assessment. 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the assessment. 
        /// </para>
        /// </summary>
        public AssessmentStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        ///  The number of successful servers in the assessment. 
        /// </para>
        /// </summary>
        public int Success
        {
            get { return this._success.GetValueOrDefault(); }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success.HasValue; 
        }

    }
}