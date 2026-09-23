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
    /// An occurrence during a stage session.
    /// </summary>
    public partial class Event
    {
        /// <summary>
        /// Gets and sets the property DestinationSessionId. 
        /// <para>
        /// ID of the session within the destination stage. Applicable only if the event name
        /// is <c>REPLICATION_STARTED</c> or <c>REPLICATION_STOPPED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 16)]
        public string DestinationSessionId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationSessionId property is set.
        /// </summary>
        internal bool IsSetDestinationSessionId() => this.DestinationSessionId != null;

        /// <summary>
        /// Gets and sets the property DestinationStageArn. 
        /// <para>
        /// ARN of the stage where the participant is replicated. Applicable only if the event
        /// name is <c>REPLICATION_STARTED</c> or <c>REPLICATION_STOPPED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DestinationStageArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationStageArn property is set.
        /// </summary>
        internal bool IsSetDestinationStageArn() => this.DestinationStageArn != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// If the event is an error event, the error code is provided to give insight into the
        /// specific error that occurred. If the event is not an error event, this field is null.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>B_FRAME_PRESENT</c> — The participant's stream includes B-frames. For details,
        /// see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/rt-rtmp-publishing.html">
        /// IVS RTMP Publishing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BITRATE_EXCEEDED</c> — The participant exceeded the maximum supported bitrate.
        /// For details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/service-quotas.html">
        /// Service Quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_CAPABILITIES</c> — The participant tried to take an action that the
        /// participant’s token is not allowed to do. For details on participant capabilities,
        /// see the <c>capabilities</c> field in <a>CreateParticipantToken</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_SERVER_EXCEPTION</c> — The participant failed to publish to the stage
        /// due to an internal server error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_AUDIO_CODEC</c> — The participant is using an invalid audio codec. For
        /// details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/rt-stream-ingest.html">
        /// Stream Ingest</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_INPUT</c> — The participant is using an invalid input stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_PROTOCOL</c> — The participant's IngestConfiguration resource is configured
        /// for RTMPS but they tried streaming with RTMP. For details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/rt-rtmp-publishing.html">
        /// IVS RTMP Publishing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_STREAM_KEY</c> — The participant is using an invalid stream key. For details,
        /// see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/rt-rtmp-publishing.html">
        /// IVS RTMP Publishing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_VIDEO_CODEC</c> — The participant is using an invalid video codec. For
        /// details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/rt-stream-ingest.html">
        /// Stream Ingest</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLISHER_NOT_FOUND</c> — The participant tried to subscribe to a publisher that
        /// doesn’t exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUOTA_EXCEEDED</c> — The number of participants who want to publish/subscribe
        /// to a stage exceeds the quota. For details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/service-quotas.html">
        /// Service Quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOLUTION_EXCEEDED</c> — The participant exceeded the maximum supported resolution.
        /// For details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/service-quotas.html">
        /// Service Quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REUSE_OF_STREAM_KEY</c> — The participant tried to use a stream key that is associated
        /// with another active stage session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STREAM_DURATION_EXCEEDED</c> — The participant exceeded the maximum allowed stream
        /// duration. For details, see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/service-quotas.html">
        /// Service Quotas</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EventErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) for when the event occurred.
        /// </para>
        /// </summary>
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// Checks to see if the EventTime property is set.
        /// </summary>
        internal bool IsSetEventTime() => this.EventTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event.
        /// </para>
        /// </summary>
        public EventName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NewToken. 
        /// <para>
        /// Participant token created during <c>TOKEN_EXCHANGED</c> event.
        /// </para>
        /// </summary>
        public ExchangedParticipantToken NewToken { get; set; }

        /// <summary>
        /// Checks to see if the NewToken property is set.
        /// </summary>
        internal bool IsSetNewToken() => this.NewToken != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Unique identifier for the participant who triggered the event. This is assigned by
        /// IVS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property PreviousToken. 
        /// <para>
        /// Source participant token for <c>TOKEN_EXCHANGED</c> event.
        /// </para>
        /// </summary>
        public ExchangedParticipantToken PreviousToken { get; set; }

        /// <summary>
        /// Checks to see if the PreviousToken property is set.
        /// </summary>
        internal bool IsSetPreviousToken() => this.PreviousToken != null;

        /// <summary>
        /// Gets and sets the property RemoteParticipantId. 
        /// <para>
        /// Unique identifier for the remote participant. For a subscribe event, this is the publisher.
        /// For a publish or join event, this is null. This is assigned by IVS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RemoteParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the RemoteParticipantId property is set.
        /// </summary>
        internal bool IsSetRemoteParticipantId() => this.RemoteParticipantId != null;

        /// <summary>
        /// Gets and sets the property Replica. 
        /// <para>
        /// If true, this indicates the <c>participantId</c> is a replicated participant. If this
        /// is a subscribe event, then this flag refers to <c>remoteParticipantId</c>. Default:
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Replica { get; set; }

        /// <summary>
        /// Checks to see if the Replica property is set.
        /// </summary>
        internal bool IsSetReplica() => this.Replica.HasValue;
    }
}
