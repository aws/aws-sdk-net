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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The Amazon Chime SDK Voice Connector group configuration, including associated Voice
    /// Connectors. You can include Voice Connectors from different AWS Regions in a group.
    /// This creates a fault tolerant mechanism for fallback in case of availability events.
    /// </summary>
    public partial class VoiceConnectorGroup
    {
        private DateTime? _createdTimestamp;
        private string _name;
        private DateTime? _updatedTimestamp;
        private string _voiceConnectorGroupArn;
        private string _voiceConnectorGroupId;
        private List<VoiceConnectorItem> _voiceConnectorItems = new List<VoiceConnectorItem>();

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Voice Connector group's creation time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a Voice Connector group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The Voice Connector group's creation time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorGroupArn. 
        /// <para>
        /// The ARN of the Voice Connector group.
        /// </para>
        /// </summary>
        public string VoiceConnectorGroupArn
        {
            get { return this._voiceConnectorGroupArn; }
            set { this._voiceConnectorGroupArn = value; }
        }

        // Check to see if VoiceConnectorGroupArn property is set
        internal bool IsSetVoiceConnectorGroupArn()
        {
            return this._voiceConnectorGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorGroupId. 
        /// <para>
        /// The ID of a Voice Connector group.
        /// </para>
        /// </summary>
        public string VoiceConnectorGroupId
        {
            get { return this._voiceConnectorGroupId; }
            set { this._voiceConnectorGroupId = value; }
        }

        // Check to see if VoiceConnectorGroupId property is set
        internal bool IsSetVoiceConnectorGroupId()
        {
            return this._voiceConnectorGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorItems. 
        /// <para>
        /// The Voice Connectors to which you route inbound calls.
        /// </para>
        /// </summary>
        public List<VoiceConnectorItem> VoiceConnectorItems
        {
            get { return this._voiceConnectorItems; }
            set { this._voiceConnectorItems = value; }
        }

        // Check to see if VoiceConnectorItems property is set
        internal bool IsSetVoiceConnectorItems()
        {
            return this._voiceConnectorItems != null && this._voiceConnectorItems.Count > 0; 
        }

    }
}