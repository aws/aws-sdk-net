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
    /// 
    /// </summary>
    public partial class VoiceProfile
    {
        private DateTime? _createdTimestamp;
        private DateTime? _expirationTimestamp;
        private DateTime? _updatedTimestamp;
        private string _voiceProfileArn;
        private string _voiceProfileDomainId;
        private string _voiceProfileId;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp.
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
        /// Gets and sets the property ExpirationTimestamp.
        /// </summary>
        public DateTime ExpirationTimestamp
        {
            get { return this._expirationTimestamp.GetValueOrDefault(); }
            set { this._expirationTimestamp = value; }
        }

        // Check to see if ExpirationTimestamp property is set
        internal bool IsSetExpirationTimestamp()
        {
            return this._expirationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp.
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
        /// Gets and sets the property VoiceProfileArn.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string VoiceProfileArn
        {
            get { return this._voiceProfileArn; }
            set { this._voiceProfileArn = value; }
        }

        // Check to see if VoiceProfileArn property is set
        internal bool IsSetVoiceProfileArn()
        {
            return this._voiceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceProfileDomainId.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VoiceProfileDomainId
        {
            get { return this._voiceProfileDomainId; }
            set { this._voiceProfileDomainId = value; }
        }

        // Check to see if VoiceProfileDomainId property is set
        internal bool IsSetVoiceProfileDomainId()
        {
            return this._voiceProfileDomainId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceProfileId.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VoiceProfileId
        {
            get { return this._voiceProfileId; }
            set { this._voiceProfileId = value; }
        }

        // Check to see if VoiceProfileId property is set
        internal bool IsSetVoiceProfileId()
        {
            return this._voiceProfileId != null;
        }

    }
}