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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for AudioSilenceFailoverSettings
    /// </summary>
    public partial class AudioSilenceFailoverSettings
    {
        private string _audioSelectorName;
        private int? _audioSilenceThresholdMsec;

        /// <summary>
        /// Gets and sets the property AudioSelectorName. The name of the audio selector in the
        /// input that MediaLive should monitor to detect silence. Select your most important
        /// rendition. If you didn't create an audio selector in this input, leave blank.
        /// </summary>
        [AWSProperty(Required=true)]
        public string AudioSelectorName
        {
            get { return this._audioSelectorName; }
            set { this._audioSelectorName = value; }
        }

        // Check to see if AudioSelectorName property is set
        internal bool IsSetAudioSelectorName()
        {
            return this._audioSelectorName != null;
        }

        /// <summary>
        /// Gets and sets the property AudioSilenceThresholdMsec. The amount of time (in milliseconds)
        /// that the active input must be silent before automatic input failover occurs. Silence
        /// is defined as audio loss or audio quieter than -50 dBFS.
        /// </summary>
        [AWSProperty(Min=1000)]
        public int? AudioSilenceThresholdMsec
        {
            get { return this._audioSilenceThresholdMsec; }
            set { this._audioSilenceThresholdMsec = value; }
        }

        // Check to see if AudioSilenceThresholdMsec property is set
        internal bool IsSetAudioSilenceThresholdMsec()
        {
            return this._audioSilenceThresholdMsec.HasValue; 
        }

    }
}