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
    /// Container for the parameters to the StopParticipantReplication operation. Stops a
    /// replicated participant session.
    /// </summary>
    public partial class StopParticipantReplicationRequest : AmazonIVSRealTimeRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationStageArn. 
        /// <para>
        /// ARN of the stage where the participant has been replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DestinationStageArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationStageArn property is set.
        /// </summary>
        internal bool IsSetDestinationStageArn() => this.DestinationStageArn != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// Participant ID of the publisher that has been replicated. This is assigned by IVS
        /// and returned by <a>CreateParticipantToken</a> or the <c>jti</c> (JWT ID) used to <a
        /// href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/getting-started-distribute-tokens.html#getting-started-distribute-tokens-self-signed">
        /// create a self signed token</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property SourceStageArn. 
        /// <para>
        /// ARN of the stage where the participant is publishing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SourceStageArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceStageArn property is set.
        /// </summary>
        internal bool IsSetSourceStageArn() => this.SourceStageArn != null;
    }
}
