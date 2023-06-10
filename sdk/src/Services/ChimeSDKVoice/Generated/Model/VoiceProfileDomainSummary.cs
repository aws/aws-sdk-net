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
    /// A high-level overview of a voice profile domain.
    /// </summary>
    public partial class VoiceProfileDomainSummary
    {
        private DateTime? _createdTimestamp;
        private string _description;
        private string _name;
        private DateTime? _updatedTimestamp;
        private string _voiceProfileDomainArn;
        private string _voiceProfileDomainId;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which the voice profile domain summary was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the voice profile domain summary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the voice profile domain summary.
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
        /// The time at which the voice profile domain summary was last updated.
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
        /// Gets and sets the property VoiceProfileDomainArn. 
        /// <para>
        /// The ARN of a voice profile in a voice profile domain summary.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string VoiceProfileDomainArn
        {
            get { return this._voiceProfileDomainArn; }
            set { this._voiceProfileDomainArn = value; }
        }

        // Check to see if VoiceProfileDomainArn property is set
        internal bool IsSetVoiceProfileDomainArn()
        {
            return this._voiceProfileDomainArn != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceProfileDomainId. 
        /// <para>
        /// The ID of the voice profile domain summary.
        /// </para>
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

    }
}