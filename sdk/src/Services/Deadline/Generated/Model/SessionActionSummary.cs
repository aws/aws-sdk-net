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
    /// The details of a session action.
    /// </summary>
    public partial class SessionActionSummary
    {
        private SessionActionDefinitionSummary _definition;
        private DateTime? _endedAt;
        private float? _progressPercent;
        private string _sessionActionId;
        private DateTime? _startedAt;
        private SessionActionStatus _status;
        private DateTime? _workerUpdatedAt;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The session action definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionActionDefinitionSummary Definition
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
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The completion percentage for the session action.
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
        /// Gets and sets the property SessionActionId. 
        /// <para>
        /// The session action ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionActionId
        {
            get { return this._sessionActionId; }
            set { this._sessionActionId = value; }
        }

        // Check to see if SessionActionId property is set
        internal bool IsSetSessionActionId()
        {
            return this._sessionActionId != null;
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the session action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionActionStatus Status
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
        /// Gets and sets the property WorkerUpdatedAt. 
        /// <para>
        /// The Linux timestamp of the last date and time that the session action was updated.
        /// </para>
        /// </summary>
        public DateTime WorkerUpdatedAt
        {
            get { return this._workerUpdatedAt.GetValueOrDefault(); }
            set { this._workerUpdatedAt = value; }
        }

        // Check to see if WorkerUpdatedAt property is set
        internal bool IsSetWorkerUpdatedAt()
        {
            return this._workerUpdatedAt.HasValue; 
        }

    }
}