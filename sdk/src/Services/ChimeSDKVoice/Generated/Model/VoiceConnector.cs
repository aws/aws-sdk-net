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
    /// The Amazon Chime SDK Voice Connector configuration, including outbound host name and
    /// encryption settings.
    /// </summary>
    public partial class VoiceConnector
    {
        private VoiceConnectorAwsRegion _awsRegion;
        private DateTime? _createdTimestamp;
        private string _name;
        private string _outboundHostName;
        private bool? _requireEncryption;
        private DateTime? _updatedTimestamp;
        private string _voiceConnectorArn;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region in which the Voice Connector is created. Default: us-east-1.
        /// </para>
        /// </summary>
        public VoiceConnectorAwsRegion AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Voice Connector's creation timestamp, in ISO 8601 format.
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
        /// The Voice Connector's name.
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
        /// Gets and sets the property OutboundHostName. 
        /// <para>
        /// The outbound host name for the Voice Connector.
        /// </para>
        /// </summary>
        public string OutboundHostName
        {
            get { return this._outboundHostName; }
            set { this._outboundHostName = value; }
        }

        // Check to see if OutboundHostName property is set
        internal bool IsSetOutboundHostName()
        {
            return this._outboundHostName != null;
        }

        /// <summary>
        /// Gets and sets the property RequireEncryption. 
        /// <para>
        /// Enables or disables encryption for the Voice Connector.
        /// </para>
        /// </summary>
        public bool RequireEncryption
        {
            get { return this._requireEncryption.GetValueOrDefault(); }
            set { this._requireEncryption = value; }
        }

        // Check to see if RequireEncryption property is set
        internal bool IsSetRequireEncryption()
        {
            return this._requireEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The Voice Connector's updated timestamp, in ISO 8601 format.
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
        /// Gets and sets the property VoiceConnectorArn. 
        /// <para>
        /// The ARN of the Voice Connector.
        /// </para>
        /// </summary>
        public string VoiceConnectorArn
        {
            get { return this._voiceConnectorArn; }
            set { this._voiceConnectorArn = value; }
        }

        // Check to see if VoiceConnectorArn property is set
        internal bool IsSetVoiceConnectorArn()
        {
            return this._voiceConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector's ID.
        /// </para>
        /// </summary>
        public string VoiceConnectorId
        {
            get { return this._voiceConnectorId; }
            set { this._voiceConnectorId = value; }
        }

        // Check to see if VoiceConnectorId property is set
        internal bool IsSetVoiceConnectorId()
        {
            return this._voiceConnectorId != null;
        }

    }
}