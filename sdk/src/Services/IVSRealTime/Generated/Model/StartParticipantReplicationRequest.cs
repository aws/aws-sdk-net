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
    /// Container for the parameters to the StartParticipantReplication operation.
    /// Starts replicating a publishing participant from a source stage to a destination stage.
    /// </summary>
    public partial class StartParticipantReplicationRequest : AmazonIVSRealTimeRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _destinationStageArn;
        private string _participantId;
        private int? _reconnectWindowSeconds;
        private string _sourceStageArn;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to set on the replicated participant in the destination
        /// stage. Map keys and values can contain UTF-8 encoded text. The maximum length of this
        /// field is 1 KB total. <i>This field is exposed to all stage participants and should
        /// not be used for personally identifying, confidential, or sensitive information.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        /// These attributes are merged with any attributes set for this participant when creating
        /// the token. If there is overlap in keys, the values in these attributes are replaced.
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
        /// Gets and sets the property DestinationStageArn. 
        /// <para>
        /// ARN of the stage to which the participant will be replicated.
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
        /// returned by <a>CreateParticipantToken</a> or the <c>jti</c> (JWT ID) used to <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/getting-started-distribute-tokens.html#getting-started-distribute-tokens-self-signed">create
        /// a self signed token</a>. 
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
        /// Gets and sets the property ReconnectWindowSeconds. 
        /// <para>
        /// If the participant disconnects and then reconnects within the specified interval,
        /// replication will continue to be <c>ACTIVE</c>. Default: 0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public int? ReconnectWindowSeconds
        {
            get { return this._reconnectWindowSeconds; }
            set { this._reconnectWindowSeconds = value; }
        }

        // Check to see if ReconnectWindowSeconds property is set
        internal bool IsSetReconnectWindowSeconds()
        {
            return this._reconnectWindowSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceStageArn. 
        /// <para>
        /// ARN of the stage where the participant is publishing.
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