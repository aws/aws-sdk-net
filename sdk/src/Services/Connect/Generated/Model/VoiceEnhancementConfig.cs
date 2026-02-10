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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration settings for voice enhancement.
    /// </summary>
    public partial class VoiceEnhancementConfig
    {
        private Channel _channel;
        private VoiceEnhancementMode _voiceEnhancementMode;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel for this voice enhancement configuration. <b>Only <c>VOICE</c> is supported
        /// for this data type.</b> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceEnhancementMode. 
        /// <para>
        /// The voice enhancement mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VoiceEnhancementMode VoiceEnhancementMode
        {
            get { return this._voiceEnhancementMode; }
            set { this._voiceEnhancementMode = value; }
        }

        // Check to see if VoiceEnhancementMode property is set
        internal bool IsSetVoiceEnhancementMode()
        {
            return this._voiceEnhancementMode != null;
        }

    }
}