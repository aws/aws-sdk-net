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
    /// Information about the replicated destination stage for a participant.
    /// </summary>
    public partial class ParticipantReplica
    {
        private string _destinationSessionId;
        private string _destinationStageArn;
        private string _participantId;
        private ReplicationState _replicationState;
        private string _sourceSessionId;
        private string _sourceStageArn;

        /// <summary>
        /// Gets and sets the property DestinationSessionId. 
        /// <para>
        /// ID of the session within the destination stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=16)]
        public string DestinationSessionId
        {
            get { return this._destinationSessionId; }
            set { this._destinationSessionId = value; }
        }

        // Check to see if DestinationSessionId property is set
        internal bool IsSetDestinationSessionId()
        {
            return this._destinationSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationStageArn. 
        /// <para>
        /// ARN of the stage where the participant is replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DestinationStageArn
        {
            get { return this._destinationStageArn; }
            set { this._destinationStageArn = value; }
        }

        // Check to see if DestinationStageArn property is set
        internal bool IsSetDestinationStageArn()
        {
            return this._destinationStageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Participant ID of the publisher that will be replicated. This is assigned by IVS and
        /// returned by <a>CreateParticipantToken</a> or the <c>jti</c> (JWT ID) used to <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/getting-started-distribute-tokens.html#getting-started-distribute-tokens-self-signed">
        /// create a self signed token</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
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
        /// Gets and sets the property ReplicationState. 
        /// <para>
        /// Replica’s current replication state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SourceSessionId. 
        /// <para>
        /// ID of the session within the source stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=16)]
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
        /// ARN of the stage from which this participant is replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

    }
}