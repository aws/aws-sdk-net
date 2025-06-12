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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Object describing a participant that has joined a stage.
    /// </summary>
    public partial class Participant
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _browserName;
        private string _browserVersion;
        private DateTime? _firstJoinTime;
        private string _ispName;
        private string _osName;
        private string _osVersion;
        private string _participantId;
        private ParticipantProtocol _protocol;
        private bool? _published;
        private string _recordings3BucketName;
        private string _recordings3Prefix;
        private ParticipantRecordingState _recordingState;
        private ReplicationState _replicationState;
        private ReplicationType _replicationType;
        private string _sdkVersion;
        private string _sourceSessionId;
        private string _sourceStageArn;
        private ParticipantState _state;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to encode into the token and attach to a stage. Map
        /// keys and values can contain UTF-8 encoded text. The maximum length of this field is
        /// 1 KB total. <i>This field is exposed to all stage participants and should not be used
        /// for personally identifying, confidential, or sensitive information</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BrowserName. 
        /// <para>
        /// The participant’s browser.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string BrowserName
        {
            get { return this._browserName; }
            set { this._browserName = value; }
        }

        // Check to see if BrowserName property is set
        internal bool IsSetBrowserName()
        {
            return this._browserName != null;
        }

        /// <summary>
        /// Gets and sets the property BrowserVersion. 
        /// <para>
        /// The participant’s browser version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string BrowserVersion
        {
            get { return this._browserVersion; }
            set { this._browserVersion = value; }
        }

        // Check to see if BrowserVersion property is set
        internal bool IsSetBrowserVersion()
        {
            return this._browserVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FirstJoinTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) when the participant first joined the stage
        /// session.
        /// </para>
        /// </summary>
        public DateTime? FirstJoinTime
        {
            get { return this._firstJoinTime; }
            set { this._firstJoinTime = value; }
        }

        // Check to see if FirstJoinTime property is set
        internal bool IsSetFirstJoinTime()
        {
            return this._firstJoinTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IspName. 
        /// <para>
        /// The participant’s Internet Service Provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string IspName
        {
            get { return this._ispName; }
            set { this._ispName = value; }
        }

        // Check to see if IspName property is set
        internal bool IsSetIspName()
        {
            return this._ispName != null;
        }

        /// <summary>
        /// Gets and sets the property OsName. 
        /// <para>
        /// The participant’s operating system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string OsName
        {
            get { return this._osName; }
            set { this._osName = value; }
        }

        // Check to see if OsName property is set
        internal bool IsSetOsName()
        {
            return this._osName != null;
        }

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The participant’s operating system version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for this participant, assigned by IVS.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// Type of ingest protocol that the participant employs for broadcasting.
        /// </para>
        /// </summary>
        public ParticipantProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Published. 
        /// <para>
        /// Whether the participant ever published to the stage session.
        /// </para>
        /// </summary>
        public bool? Published
        {
            get { return this._published; }
            set { this._published = value; }
        }

        // Check to see if Published property is set
        internal bool IsSetPublished()
        {
            return this._published.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordingS3BucketName. 
        /// <para>
        /// Name of the S3 bucket to where the participant is being recorded, if individual participant
        /// recording is enabled, or <c>""</c> (empty string), if recording is not enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string RecordingS3BucketName
        {
            get { return this._recordings3BucketName; }
            set { this._recordings3BucketName = value; }
        }

        // Check to see if RecordingS3BucketName property is set
        internal bool IsSetRecordingS3BucketName()
        {
            return this._recordings3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingS3Prefix. 
        /// <para>
        /// S3 prefix of the S3 bucket where the participant is being recorded, if individual
        /// participant recording is enabled, or <c>""</c> (empty string), if recording is not
        /// enabled. If individual participant recording merge is enabled, and if a stage publisher
        /// disconnects from a stage and then reconnects, IVS tries to record to the same S3 prefix
        /// as the previous session. See <a href="/ivs/latest/RealTimeUserGuide/rt-individual-participant-recording.html#ind-part-rec-merge-frag">
        /// Merge Fragmented Individual Participant Recordings</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string RecordingS3Prefix
        {
            get { return this._recordings3Prefix; }
            set { this._recordings3Prefix = value; }
        }

        // Check to see if RecordingS3Prefix property is set
        internal bool IsSetRecordingS3Prefix()
        {
            return this._recordings3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingState. 
        /// <para>
        /// The participant’s recording state.
        /// </para>
        /// </summary>
        public ParticipantRecordingState RecordingState
        {
            get { return this._recordingState; }
            set { this._recordingState = value; }
        }

        // Check to see if RecordingState property is set
        internal bool IsSetRecordingState()
        {
            return this._recordingState != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationState. 
        /// <para>
        /// The participant's replication state.
        /// </para>
        /// </summary>
        public ReplicationState ReplicationState
        {
            get { return this._replicationState; }
            set { this._replicationState = value; }
        }

        // Check to see if ReplicationState property is set
        internal bool IsSetReplicationState()
        {
            return this._replicationState != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// Indicates if the participant has been replicated to another stage or is a replica
        /// from another stage. Default: <c>NONE</c>. 
        /// </para>
        /// </summary>
        public ReplicationType ReplicationType
        {
            get { return this._replicationType; }
            set { this._replicationType = value; }
        }

        // Check to see if ReplicationType property is set
        internal bool IsSetReplicationType()
        {
            return this._replicationType != null;
        }

        /// <summary>
        /// Gets and sets the property SdkVersion. 
        /// <para>
        /// The participant’s SDK version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string SdkVersion
        {
            get { return this._sdkVersion; }
            set { this._sdkVersion = value; }
        }

        // Check to see if SdkVersion property is set
        internal bool IsSetSdkVersion()
        {
            return this._sdkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSessionId. 
        /// <para>
        /// ID of the session within the source stage, if <c>replicationType</c> is <c>REPLICA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=16)]
        public string SourceSessionId
        {
            get { return this._sourceSessionId; }
            set { this._sourceSessionId = value; }
        }

        // Check to see if SourceSessionId property is set
        internal bool IsSetSourceSessionId()
        {
            return this._sourceSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceStageArn. 
        /// <para>
        /// Source stage ARN from which this participant is replicated, if <c>replicationType</c>
        /// is <c>REPLICA</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SourceStageArn
        {
            get { return this._sourceStageArn; }
            set { this._sourceStageArn = value; }
        }

        // Check to see if SourceStageArn property is set
        internal bool IsSetSourceStageArn()
        {
            return this._sourceStageArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Whether the participant is connected to or disconnected from the stage.
        /// </para>
        /// </summary>
        public ParticipantState State
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// Customer-assigned name to help identify the token; this can be used to link a participant
        /// to a user in the customer’s own systems. This can be any UTF-8 encoded text. <i>This
        /// field is exposed to all stage participants and should not be used for personally identifying,
        /// confidential, or sensitive information</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}