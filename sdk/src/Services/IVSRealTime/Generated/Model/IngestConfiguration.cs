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
    /// Object specifying an ingest configuration.
    /// </summary>
    public partial class IngestConfiguration
    {
        private string _arn;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IngestProtocol _ingestProtocol;
        private string _name;
        private string _participantId;
        private string _stageArn;
        private IngestConfigurationState _state;
        private string _streamKey;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Ingest configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to to store in the IngestConfiguration and attach
        /// to a stage. Map keys and values can contain UTF-8 encoded text. The maximum length
        /// of this field is 1 KB total. <i>This field is exposed to all stage participants and
        /// should not be used for personally identifying, confidential, or sensitive information.</i>
        /// 
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
        /// Gets and sets the property IngestProtocol. 
        /// <para>
        /// Type of ingest protocol that the user employs for broadcasting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestProtocol IngestProtocol
        {
            get { return this._ingestProtocol; }
            set { this._ingestProtocol = value; }
        }

        // Check to see if IngestProtocol property is set
        internal bool IsSetIngestProtocol()
        {
            return this._ingestProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Ingest name
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// ID of the participant within the stage.
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
        /// Gets and sets the property StageArn. 
        /// <para>
        /// ARN of the stage with which the IngestConfiguration is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the ingest configuration. It is <c>ACTIVE</c> if a publisher currently is
        /// publishing to the stage associated with the ingest configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestConfigurationState State
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
        /// Gets and sets the property StreamKey. 
        /// <para>
        /// Ingest-key value for the RTMP(S) protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string StreamKey
        {
            get { return this._streamKey; }
            set { this._streamKey = value; }
        }

        // Check to see if StreamKey property is set
        internal bool IsSetStreamKey()
        {
            return this._streamKey != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of maps, each of the form <c>string:string (key:value)</c>.
        /// See <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
        /// practices and strategies</a> in <i>Tagging AWS Resources and Tag Editor</i> for details,
        /// including restrictions that apply to tags and "Tag naming limits and requirements";
        /// Amazon IVS has no constraints on tags beyond what is documented there.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Customer-assigned name to help identify the participant using the IngestConfiguration;
        /// this can be used to link a participant to a user in the customer’s own systems. This
        /// can be any UTF-8 encoded text. <i>This field is exposed to all stage participants
        /// and should not be used for personally identifying, confidential, or sensitive information.</i>
        /// 
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