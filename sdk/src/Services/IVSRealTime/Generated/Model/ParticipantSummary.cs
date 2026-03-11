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
    /// Summary object describing a participant that has joined a stage.
    /// </summary>
    public partial class ParticipantSummary
    {
        private DateTime? _firstJoinTime;
        private string _participantId;
        private bool? _published;
        private ParticipantRecordingState _recordingState;
        private ReplicationState _replicationState;
        private ReplicationType _replicationType;
        private string _sourceSessionId;
        private string _sourceStageArn;
        private ParticipantState _state;
        private string _userId;

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