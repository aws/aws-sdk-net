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
    /// A streaming session is a virtual workstation created using a particular launch profile.
    /// </summary>
    public partial class StreamingSession
    {
        private string _arn;
        private AutomaticTerminationMode _automaticTerminationMode;
        private SessionBackupMode _backupMode;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _ec2InstanceType;
        private string _launchProfileId;
        private int? _maxBackupsToRetain;
        private string _ownedBy;
        private string _sessionId;
        private SessionPersistenceMode _sessionPersistenceMode;
        private DateTime? _startedAt;
        private string _startedBy;
        private string _startedFromBackupId;
        private StreamingSessionState _state;
        private StreamingSessionStatusCode _statusCode;
        private string _statusMessage;
        private DateTime? _stopAt;
        private DateTime? _stoppedAt;
        private string _stoppedBy;
        private string _streamingImageId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private DateTime? _terminateAt;
        private DateTime? _updatedAt;
        private string _updatedBy;
        private VolumeConfiguration _volumeConfiguration;
        private VolumeRetentionMode _volumeRetentionMode;

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
        /// Gets and sets the property AutomaticTerminationMode. 
        /// <para>
        /// Indicates if a streaming session created from this launch profile should be terminated
        /// automatically or retained without termination after being in a <code>STOPPED</code>
        /// state.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <code>ACTIVATED</code>, the streaming session is scheduled for termination after
        /// being in the <code>STOPPED</code> state for the time specified in <code>maxStoppedSessionLengthInMinutes</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <code>DEACTIVATED</code>, the streaming session can remain in the <code>STOPPED</code>
        /// state indefinitely.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This parameter is only allowed when <code>sessionPersistenceMode</code> is <code>ACTIVATED</code>.
        /// When allowed, the default value for this parameter is <code>DEACTIVATED</code>.
        /// </para>
        /// </summary>
        public AutomaticTerminationMode AutomaticTerminationMode
        {
            get { return this._automaticTerminationMode; }
            set { this._automaticTerminationMode = value; }
        }

        // Check to see if AutomaticTerminationMode property is set
        internal bool IsSetAutomaticTerminationMode()
        {
            return this._automaticTerminationMode != null;
        }

        /// <summary>
        /// Gets and sets the property BackupMode. 
        /// <para>
        /// Shows the current backup setting of the session.
        /// </para>
        /// </summary>
        public SessionBackupMode BackupMode
        {
            get { return this._backupMode; }
            set { this._backupMode = value; }
        }

        // Check to see if BackupMode property is set
        internal bool IsSetBackupMode()
        {
            return this._backupMode != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the resource was created.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user ID of the user that created the streaming session.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceType. 
        /// <para>
        /// The EC2 Instance type used for the streaming session.
        /// </para>
        /// </summary>
        public string Ec2InstanceType
        {
            get { return this._ec2InstanceType; }
            set { this._ec2InstanceType = value; }
        }

        // Check to see if Ec2InstanceType property is set
        internal bool IsSetEc2InstanceType()
        {
            return this._ec2InstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchProfileId. 
        /// <para>
        /// The ID of the launch profile used to control access from the streaming session.
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
        /// Gets and sets the property MaxBackupsToRetain. 
        /// <para>
        /// The maximum number of backups of a streaming session that you can have. When the maximum
        /// number of backups is reached, the oldest backup is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int MaxBackupsToRetain
        {
            get { return this._maxBackupsToRetain.GetValueOrDefault(); }
            set { this._maxBackupsToRetain = value; }
        }

        // Check to see if MaxBackupsToRetain property is set
        internal bool IsSetMaxBackupsToRetain()
        {
            return this._maxBackupsToRetain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnedBy. 
        /// <para>
        /// The user ID of the user that owns the streaming session. The user that owns the session
        /// will be logging into the session and interacting with the virtual workstation.
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
        /// The session ID.
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
        /// Gets and sets the property SessionPersistenceMode. 
        /// <para>
        /// Determine if a streaming session created from this launch profile can configure persistent
        /// storage. This means that <code>volumeConfiguration</code> and <code>automaticTerminationMode</code>
        /// are configured.
        /// </para>
        /// </summary>
        public SessionPersistenceMode SessionPersistenceMode
        {
            get { return this._sessionPersistenceMode; }
            set { this._sessionPersistenceMode = value; }
        }

        // Check to see if SessionPersistenceMode property is set
        internal bool IsSetSessionPersistenceMode()
        {
            return this._sessionPersistenceMode != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the session entered <code>START_IN_PROGRESS</code> state.
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
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The user ID of the user that started the streaming session.
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartedFromBackupId. 
        /// <para>
        /// The backup ID used to restore a streaming session.
        /// </para>
        /// </summary>
        public string StartedFromBackupId
        {
            get { return this._startedFromBackupId; }
            set { this._startedFromBackupId = value; }
        }

        // Check to see if StartedFromBackupId property is set
        internal bool IsSetStartedFromBackupId()
        {
            return this._startedFromBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
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
        /// The status message for the streaming session.
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
        /// Gets and sets the property StopAt. 
        /// <para>
        /// The time the streaming session will automatically be stopped if the user doesn’t stop
        /// the session themselves. 
        /// </para>
        /// </summary>
        public DateTime StopAt
        {
            get { return this._stopAt.GetValueOrDefault(); }
            set { this._stopAt = value; }
        }

        // Check to see if StopAt property is set
        internal bool IsSetStopAt()
        {
            return this._stopAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The time the session entered <code>STOP_IN_PROGRESS</code> state.
        /// </para>
        /// </summary>
        public DateTime StoppedAt
        {
            get { return this._stoppedAt.GetValueOrDefault(); }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoppedBy. 
        /// <para>
        /// The user ID of the user that stopped the streaming session.
        /// </para>
        /// </summary>
        public string StoppedBy
        {
            get { return this._stoppedBy; }
            set { this._stoppedBy = value; }
        }

        // Check to see if StoppedBy property is set
        internal bool IsSetStoppedBy()
        {
            return this._stoppedBy != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingImageId. 
        /// <para>
        /// The ID of the streaming image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string StreamingImageId
        {
            get { return this._streamingImageId; }
            set { this._streamingImageId = value; }
        }

        // Check to see if StreamingImageId property is set
        internal bool IsSetStreamingImageId()
        {
            return this._streamingImageId != null;
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

        /// <summary>
        /// Gets and sets the property TerminateAt. 
        /// <para>
        /// The time the streaming session will automatically terminate if not terminated by the
        /// user.
        /// </para>
        /// </summary>
        public DateTime TerminateAt
        {
            get { return this._terminateAt.GetValueOrDefault(); }
            set { this._terminateAt = value; }
        }

        // Check to see if TerminateAt property is set
        internal bool IsSetTerminateAt()
        {
            return this._terminateAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO timestamp in seconds for when the resource was updated.
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

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user ID of the user that most recently updated the resource.
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
        /// Gets and sets the property VolumeConfiguration. 
        /// <para>
        /// Custom volume configuration for the root volumes that are attached to streaming sessions.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only allowed when <code>sessionPersistenceMode</code> is <code>ACTIVATED</code>.
        /// </para>
        /// </summary>
        public VolumeConfiguration VolumeConfiguration
        {
            get { return this._volumeConfiguration; }
            set { this._volumeConfiguration = value; }
        }

        // Check to see if VolumeConfiguration property is set
        internal bool IsSetVolumeConfiguration()
        {
            return this._volumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeRetentionMode. 
        /// <para>
        /// Determine if an EBS volume created from this streaming session will be backed up.
        /// </para>
        /// </summary>
        public VolumeRetentionMode VolumeRetentionMode
        {
            get { return this._volumeRetentionMode; }
            set { this._volumeRetentionMode = value; }
        }

        // Check to see if VolumeRetentionMode property is set
        internal bool IsSetVolumeRetentionMode()
        {
            return this._volumeRetentionMode != null;
        }

    }
}