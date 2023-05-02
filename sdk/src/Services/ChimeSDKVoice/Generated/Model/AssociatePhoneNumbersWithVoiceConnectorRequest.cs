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
    /// Container for the parameters to the AssociatePhoneNumbersWithVoiceConnector operation.
    /// Associates phone numbers with the specified Amazon Chime SDK Voice Connector.
    /// </summary>
    public partial class AssociatePhoneNumbersWithVoiceConnectorRequest : AmazonChimeSDKVoiceRequest
    {
        private List<string> _e164PhoneNumbers = new List<string>();
        private bool? _forceAssociate;
        private string _voiceConnectorId;

        /// <summary>
        /// Gets and sets the property E164PhoneNumbers. 
        /// <para>
        /// List of phone numbers, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> E164PhoneNumbers
        {
            get { return this._e164PhoneNumbers; }
            set { this._e164PhoneNumbers = value; }
        }

        // Check to see if E164PhoneNumbers property is set
        internal bool IsSetE164PhoneNumbers()
        {
            return this._e164PhoneNumbers != null && this._e164PhoneNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForceAssociate. 
        /// <para>
        /// If true, associates the provided phone numbers with the provided Amazon Chime SDK
        /// Voice Connector and removes any previously existing associations. If false, does not
        /// associate any phone numbers that have previously existing associations.
        /// </para>
        /// </summary>
        public bool ForceAssociate
        {
            get { return this._forceAssociate.GetValueOrDefault(); }
            set { this._forceAssociate = value; }
        }

        // Check to see if ForceAssociate property is set
        internal bool IsSetForceAssociate()
        {
            return this._forceAssociate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceConnectorId. 
        /// <para>
        /// The Voice Connector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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