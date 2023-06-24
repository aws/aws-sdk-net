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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Information about the streaming session backup.
    /// </summary>
    public partial class StreamingSessionBackup
    {
        private string _arn;
        private string _backupId;
        private DateTime? _createdAt;
        private string _launchProfileId;
        private string _ownedBy;
        private string _sessionId;
        private StreamingSessionState _state;
        private StreamingSessionStatusCode _statusCode;
        private string _statusMessage;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is assigned to a studio resource and uniquely
        /// identifies it. ARNs are unique across all Regions.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup.
        /// </para>
        /// </summary>
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO timestamp in for when the resource was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileId. 
        /// <para>
        /// The ID of the launch profile which allowed the backups for the streaming session.
        /// </para>
        /// </summary>
        public string LaunchProfileId
        {
            get { return this._launchProfileId; }
            set { this._launchProfileId = value; }
        }

        // Check to see if LaunchProfileId property is set
        internal bool IsSetLaunchProfileId()
        {
            return this._launchProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnedBy. 
        /// <para>
        /// The user ID of the user that owns the streaming session.
        /// </para>
        /// </summary>
        public string OwnedBy
        {
            get { return this._ownedBy; }
            set { this._ownedBy = value; }
        }

        // Check to see if OwnedBy property is set
        internal bool IsSetOwnedBy()
        {
            return this._ownedBy != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The streaming session ID for the <code>StreamingSessionBackup</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State.
        /// </summary>
        public StreamingSessionState State
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code.
        /// </para>
        /// </summary>
        public StreamingSessionStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the streaming session backup.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of labels, in the form of key-value pairs, that apply to this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}