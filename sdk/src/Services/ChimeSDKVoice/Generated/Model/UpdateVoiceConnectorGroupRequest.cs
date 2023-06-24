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
    /// Container for the parameters to the UpdateVoiceConnectorGroup operation.
    /// Updates the settings for the specified Amazon Chime SDK Voice Connector group.
    /// </summary>
    public partial class UpdateVoiceConnectorGroupRequest : AmazonChimeSDKVoiceRequest
    {
        private string _name;
        private string _voiceConnectorGroupId;
        private List<VoiceConnectorItem> _voiceConnectorItems = new List<VoiceConnectorItem>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Voice Connector group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property VoiceConnectorGroupId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The <code>VoiceConnectorItems</code> to associate with the Voice Connector group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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