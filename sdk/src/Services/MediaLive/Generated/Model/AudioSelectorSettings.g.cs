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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Selector Settings
    /// </summary>
    public partial class AudioSelectorSettings
    {
        /// <summary>
        /// Gets and sets the property AudioHlsRenditionSelection.
        /// </summary>
        public AudioHlsRenditionSelection AudioHlsRenditionSelection { get; set; }

        /// <summary>
        /// Checks to see if the AudioHlsRenditionSelection property is set.
        /// </summary>
        internal bool IsSetAudioHlsRenditionSelection() => this.AudioHlsRenditionSelection != null;

        /// <summary>
        /// Gets and sets the property AudioLanguageSelection.
        /// </summary>
        public AudioLanguageSelection AudioLanguageSelection { get; set; }

        /// <summary>
        /// Checks to see if the AudioLanguageSelection property is set.
        /// </summary>
        internal bool IsSetAudioLanguageSelection() => this.AudioLanguageSelection != null;

        /// <summary>
        /// Gets and sets the property AudioPidSelection.
        /// </summary>
        public AudioPidSelection AudioPidSelection { get; set; }

        /// <summary>
        /// Checks to see if the AudioPidSelection property is set.
        /// </summary>
        internal bool IsSetAudioPidSelection() => this.AudioPidSelection != null;

        /// <summary>
        /// Gets and sets the property AudioTrackSelection.
        /// </summary>
        public AudioTrackSelection AudioTrackSelection { get; set; }

        /// <summary>
        /// Checks to see if the AudioTrackSelection property is set.
        /// </summary>
        internal bool IsSetAudioTrackSelection() => this.AudioTrackSelection != null;
    }
}
