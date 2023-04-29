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
    /// Container for the parameters to the DisconnectParticipant operation.
    /// Disconnects a specified participant and revokes the participant permanently from a
    /// specified stage.
    /// </summary>
    public partial class DisconnectParticipantRequest : AmazonIVSRealTimeRequest
    {
        private string _participantId;
        private string _reason;
        private string _stageArn;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Identifier of the participant to be disconnected. This is returned by <a>CreateParticipantToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// Description of why this participant is being disconnected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property StageArn. 
        /// <para>
        /// ARN of the stage to which the participant is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StageArn
        {
            get { return this._stageArn; }
            set { this._stageArn = value; }
        }

        // Check to see if StageArn property is set
        internal bool IsSetStageArn()
        {
            return this._stageArn != null;
        }

    }
}