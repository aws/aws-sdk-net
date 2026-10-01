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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The combination of a voice print and caller ID.
    /// </summary>
    public partial class VoiceProfile
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the voice profile was created and enrolled.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationTimestamp. 
        /// <para>
        /// The time at which a voice profile expires unless you re-enroll the caller via the
        /// <c>UpdateVoiceProfile</c> API.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTimestamp property is set.
        /// </summary>
        internal bool IsSetExpirationTimestamp() => this.ExpirationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which the voice profile was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceProfileArn. 
        /// <para>
        /// The ARN of the voice profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string VoiceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the VoiceProfileArn property is set.
        /// </summary>
        internal bool IsSetVoiceProfileArn() => this.VoiceProfileArn != null;

        /// <summary>
        /// Gets and sets the property VoiceProfileDomainId. 
        /// <para>
        /// The ID of the domain that contains the voice profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string VoiceProfileDomainId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceProfileDomainId property is set.
        /// </summary>
        internal bool IsSetVoiceProfileDomainId() => this.VoiceProfileDomainId != null;

        /// <summary>
        /// Gets and sets the property VoiceProfileId. 
        /// <para>
        /// The ID of the voice profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string VoiceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceProfileId property is set.
        /// </summary>
        internal bool IsSetVoiceProfileId() => this.VoiceProfileId != null;
    }
}
