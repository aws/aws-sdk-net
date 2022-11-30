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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains information about the status of a notebook session.
    /// </summary>
    public partial class SessionStatus
    {
        private DateTime? _endDateTime;
        private DateTime? _idleSinceDateTime;
        private DateTime? _lastModifiedDateTime;
        private DateTime? _startDateTime;
        private SessionState _state;
        private string _stateChangeReason;

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that the session ended.
        /// </para>
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this._endDateTime.GetValueOrDefault(); }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdleSinceDateTime. 
        /// <para>
        /// The date and time starting at which the session became idle. Can be empty if the session
        /// is not currently idle.
        /// </para>
        /// </summary>
        public DateTime IdleSinceDateTime
        {
            get { return this._idleSinceDateTime.GetValueOrDefault(); }
            set { this._idleSinceDateTime = value; }
        }

        // Check to see if IdleSinceDateTime property is set
        internal bool IsSetIdleSinceDateTime()
        {
            return this._idleSinceDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDateTime. 
        /// <para>
        /// The most recent date and time that the session was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDateTime
        {
            get { return this._lastModifiedDateTime.GetValueOrDefault(); }
            set { this._lastModifiedDateTime = value; }
        }

        // Check to see if LastModifiedDateTime property is set
        internal bool IsSetLastModifiedDateTime()
        {
            return this._lastModifiedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that the session started.
        /// </para>
        /// </summary>
        public DateTime StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the session. A description of each state follows.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATING</code> - The session is being started, including acquiring resources.
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATED</code> - The session has been started.
        /// </para>
        ///  
        /// <para>
        ///  <code>IDLE</code> - The session is able to accept a calculation.
        /// </para>
        ///  
        /// <para>
        ///  <code>BUSY</code> - The session is processing another task and is unable to accept
        /// a calculation.
        /// </para>
        ///  
        /// <para>
        ///  <code>TERMINATING</code> - The session is in the process of shutting down.
        /// </para>
        ///  
        /// <para>
        ///  <code>TERMINATED</code> - The session and its resources are no longer running.
        /// </para>
        ///  
        /// <para>
        ///  <code>DEGRADED</code> - The session has no healthy coordinators.
        /// </para>
        ///  
        /// <para>
        ///  <code>FAILED</code> - Due to a failure, the session and its resources are no longer
        /// running.
        /// </para>
        /// </summary>
        public SessionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason for the session state change (for example, canceled because the session
        /// was terminated).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }

    }
}