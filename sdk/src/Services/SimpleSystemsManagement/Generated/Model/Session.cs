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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about a Session Manager connection to a managed node.
    /// </summary>
    public partial class Session
    {
        private string _details;
        private string _documentName;
        private DateTime? _endDate;
        private string _maxSessionDuration;
        private SessionManagerOutputUrl _outputUrl;
        private string _owner;
        private string _reason;
        private string _sessionId;
        private DateTime? _startDate;
        private SessionStatus _status;
        private string _target;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the Session Manager SSM document used to define the parameters and plugin
        /// settings for the session. For example, <code>SSM-SessionManagerRunShell</code>.
        /// </para>
        /// </summary>
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, when the session was terminated.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum duration of a session before it terminates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public string MaxSessionDuration
        {
            get { return this._maxSessionDuration; }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUrl. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SessionManagerOutputUrl OutputUrl
        {
            get { return this._outputUrl; }
            set { this._outputUrl = value; }
        }

        // Check to see if OutputUrl property is set
        internal bool IsSetOutputUrl()
        {
            return this._outputUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The ID of the Amazon Web Services user that started the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for connecting to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=96)]
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, when the session began.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the session. For example, "Connected" or "Terminated".
        /// </para>
        /// </summary>
        public SessionStatus Status
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The managed node that the Session Manager session connected to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}