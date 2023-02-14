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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the OptOutSpeaker operation.
    /// Opts out a speaker from Voice ID. A speaker can be opted out regardless of whether
    /// or not they already exist in Voice ID. If they don't yet exist, a new speaker is created
    /// in an opted out state. If they already exist, their existing status is overridden
    /// and they are opted out. Enrollment and evaluation authentication requests are rejected
    /// for opted out speakers, and opted out speakers have no voice embeddings stored in
    /// Voice ID.
    /// </summary>
    public partial class OptOutSpeakerRequest : AmazonVoiceIDRequest
    {
        private string _domainId;
        private string _speakerId;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain containing the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property SpeakerId. 
        /// <para>
        /// The identifier of the speaker you want opted-out.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string SpeakerId
        {
            get { return this._speakerId; }
            set { this._speakerId = value; }
        }

        // Check to see if SpeakerId property is set
        internal bool IsSetSpeakerId()
        {
            return this._speakerId != null;
        }

    }
}