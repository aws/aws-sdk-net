/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The Amazon Chime Voice Connector group configuration, including associated Amazon
    /// Chime Voice Connectors. You can include Amazon Chime Voice Connectors from different
    /// AWS Regions in your group. This creates a fault tolerant mechanism for fallback in
    /// case of availability events.
    /// </summary>
    public partial class VoiceConnectorGroup
    {
        private DateTime? _createdTimestamp;
        private string _name;
        private DateTime? _updatedTimestamp;
        private string _voiceConnectorGroupId;
        private List<VoiceConnectorItem> _voiceConnectorItems = new List<VoiceConnectorItem>();

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Amazon Chime Voice Connector group creation timestamp, in ISO 8601 format.
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
        /// The name of the Amazon Chime Voice Connector group.
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
        /// The updated Amazon Chime Voice Connector group timestamp, in ISO 8601 format.
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
        /// Gets and sets the property VoiceConnectorGroupId. 
        /// <para>
        /// The Amazon Chime Voice Connector group ID.
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
        /// The Amazon Chime Voice Connectors to which to route inbound calls.
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