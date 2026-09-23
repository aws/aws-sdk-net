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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property FirstJoinTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) when the participant first joined the stage
        /// session.
        /// </para>
        /// </summary>
        public DateTime? FirstJoinTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstJoinTime property is set.
        /// </summary>
        internal bool IsSetFirstJoinTime() => this.FirstJoinTime.HasValue;

        /// <summary>
        /// Gets and sets the property IngestConfigurationArn. 
        /// <para>
        /// The participant’s ingest configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IngestConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the IngestConfigurationArn property is set.
        /// </summary>
        internal bool IsSetIngestConfigurationArn() => this.IngestConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for this participant, assigned by IVS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property Published. 
        /// <para>
        /// Whether the participant ever published to the stage session.
        /// </para>
        /// </summary>
        public bool? Published { get; set; }

        /// <summary>
        /// Checks to see if the Published property is set.
        /// </summary>
        internal bool IsSetPublished() => this.Published.HasValue;

        /// <summary>
        /// Gets and sets the property RecordingState. 
        /// <para>
        /// The participant’s recording state.
        /// </para>
        /// </summary>
        public ParticipantRecordingState RecordingState { get; set; }

        /// <summary>
        /// Checks to see if the RecordingState property is set.
        /// </summary>
        internal bool IsSetRecordingState() => this.RecordingState != null;

        /// <summary>
        /// Gets and sets the property RedundantIngest. 
        /// <para>
        /// Indicates whether redundant ingest is enabled for the participant.
        /// </para>
        /// </summary>
        public bool? RedundantIngest { get; set; }

        /// <summary>
        /// Checks to see if the RedundantIngest property is set.
        /// </summary>
        internal bool IsSetRedundantIngest() => this.RedundantIngest.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationState. 
        /// <para>
        /// The participant's replication state.
        /// </para>
        /// </summary>
        public ReplicationState ReplicationState { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationState property is set.
        /// </summary>
        internal bool IsSetReplicationState() => this.ReplicationState != null;

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// Indicates if the participant has been replicated to another stage or is a replica
        /// from another stage. Default: <c>NONE</c>. 
        /// </para>
        /// </summary>
        public ReplicationType ReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationType property is set.
        /// </summary>
        internal bool IsSetReplicationType() => this.ReplicationType != null;

        /// <summary>
        /// Gets and sets the property SourceSessionId. 
        /// <para>
        /// ID of the session within the source stage, if <c>replicationType</c> is <c>REPLICA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 16)]
        public string SourceSessionId { get; set; }

        /// <summary>
        /// Checks to see if the SourceSessionId property is set.
        /// </summary>
        internal bool IsSetSourceSessionId() => this.SourceSessionId != null;

        /// <summary>
        /// Gets and sets the property SourceStageArn. 
        /// <para>
        /// Source stage ARN from which this participant is replicated, if <c>replicationType</c>
        /// is <c>REPLICA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SourceStageArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceStageArn property is set.
        /// </summary>
        internal bool IsSetSourceStageArn() => this.SourceStageArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Whether the participant is connected to or disconnected from the stage.
        /// </para>
        /// </summary>
        public ParticipantState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Customer-assigned name to help identify the token; this can be used to link a participant
        /// to a user in the customer’s own systems. This can be any UTF-8 encoded text. <i>This
        /// field is exposed to all stage participants and should not be used for personally identifying,
        /// confidential, or sensitive information</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
