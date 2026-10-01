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
    /// Container for the parameters to the DisconnectParticipant operation. Disconnects a
    /// specified participant from a specified stage. If the participant is publishing using
    /// an <a>IngestConfiguration</a>, DisconnectParticipant also updates the <c>stageArn</c>
    /// in the IngestConfiguration to be an empty string.
    /// </summary>
    public partial class DisconnectParticipantRequest : AmazonIVSRealTimeRequest
    {
        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Identifier of the participant to be disconnected. IVS assigns this; it is returned
        /// by <a>CreateParticipantToken</a> (for streams using WebRTC ingest) or <a>CreateIngestConfiguration</a>
        /// (for streams using RTMP ingest).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Description of why this participant is being disconnected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// ARN of the stage to which the participant is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string StageArn { get; set; }

        /// <summary>
        /// Checks to see if the StageArn property is set.
        /// </summary>
        internal bool IsSetStageArn() => this.StageArn != null;
    }
}
