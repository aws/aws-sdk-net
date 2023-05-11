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
        private ParticipantState _state;
        private string _userId;

        /// <summary>
        /// Gets and sets the property FirstJoinTime. 
        /// <para>
        /// ISO 8601 timestamp (returned as a string) when the participant first joined the stage
        /// session.
        /// </para>
        /// </summary>
        public DateTime FirstJoinTime
        {
            get { return this._firstJoinTime.GetValueOrDefault(); }
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
        public bool Published
        {
            get { return this._published.GetValueOrDefault(); }
            set { this._published = value; }
        }

        // Check to see if Published property is set
        internal bool IsSetPublished()
        {
            return this._published.HasValue; 
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