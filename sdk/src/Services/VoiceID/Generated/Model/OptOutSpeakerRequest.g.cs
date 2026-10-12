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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the OptOutSpeaker operation. Opts out a speaker from
    /// Voice ID. A speaker can be opted out regardless of whether or not they already exist
    /// in Voice ID. If they don't yet exist, a new speaker is created in an opted out state.
    /// If they already exist, their existing status is overridden and they are opted out.
    /// Enrollment and evaluation authentication requests are rejected for opted out speakers,
    /// and opted out speakers have no voice embeddings stored in Voice ID.
    /// </summary>
    public partial class OptOutSpeakerRequest : AmazonVoiceIDRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property SpeakerId. 
        /// <para>
        /// The identifier of the speaker you want opted-out.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string SpeakerId { get; set; }

        /// <summary>
        /// Checks to see if the SpeakerId property is set.
        /// </summary>
        internal bool IsSetSpeakerId() => this.SpeakerId != null;
    }
}
