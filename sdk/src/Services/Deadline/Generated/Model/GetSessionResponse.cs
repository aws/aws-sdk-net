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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        private DateTime? _endedAt;
        private string _fleetId;
        private HostPropertiesResponse _hostProperties;
        private SessionLifecycleStatus _lifecycleStatus;
        private LogConfiguration _log;
        private string _sessionId;
        private DateTime? _startedAt;
        private SessionLifecycleTargetStatus _targetLifecycleStatus;
        private DateTime? _updatedAt;
        private string _updatedBy;
        private string _workerId;
        private LogConfiguration _workerLog;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property HostProperties. 
        /// <para>
        /// Provides the Amazon EC2 properties of the host.
        /// </para>
        /// </summary>
        public HostPropertiesResponse HostProperties
        {
            get { return this._hostProperties; }
            set { this._hostProperties = value; }
        }

        // Check to see if HostProperties property is set
        internal bool IsSetHostProperties()
        {
            return this._hostProperties != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleStatus. 
        /// <para>
        /// The life cycle status of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionLifecycleStatus LifecycleStatus
        {
            get { return this._lifecycleStatus; }
            set { this._lifecycleStatus = value; }
        }

        // Check to see if LifecycleStatus property is set
        internal bool IsSetLifecycleStatus()
        {
            return this._lifecycleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Log. 
        /// <para>
        /// The session log.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogConfiguration Log
        {
            get { return this._log; }
            set { this._log = value; }
        }

        // Check to see if Log property is set
        internal bool IsSetLog()
        {
            return this._log != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetLifecycleStatus. 
        /// <para>
        /// The life cycle status with which the session started.
        /// </para>
        /// </summary>
        public SessionLifecycleTargetStatus TargetLifecycleStatus
        {
            get { return this._targetLifecycleStatus; }
            set { this._targetLifecycleStatus = value; }
        }

        // Check to see if TargetLifecycleStatus property is set
        internal bool IsSetTargetLifecycleStatus()
        {
            return this._targetLifecycleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The worker ID for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerLog. 
        /// <para>
        /// The worker log for the session.
        /// </para>
        /// </summary>
        public LogConfiguration WorkerLog
        {
            get { return this._workerLog; }
            set { this._workerLog = value; }
        }

        // Check to see if WorkerLog property is set
        internal bool IsSetWorkerLog()
        {
            return this._workerLog != null;
        }

    }
}