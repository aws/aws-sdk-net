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
    /// Audio Selector Settings
    /// </summary>
    public partial class AudioSelectorSettings
    {
        private AudioHlsRenditionSelection _audioHlsRenditionSelection;
        private AudioLanguageSelection _audioLanguageSelection;
        private AudioPidSelection _audioPidSelection;
        private AudioTrackSelection _audioTrackSelection;

        /// <summary>
        /// Gets and sets the property AudioHlsRenditionSelection.
        /// </summary>
        public AudioHlsRenditionSelection AudioHlsRenditionSelection
        {
            get { return this._audioHlsRenditionSelection; }
            set { this._audioHlsRenditionSelection = value; }
        }

        // Check to see if AudioHlsRenditionSelection property is set
        internal bool IsSetAudioHlsRenditionSelection()
        {
            return this._audioHlsRenditionSelection != null;
        }

        /// <summary>
        /// Gets and sets the property AudioLanguageSelection.
        /// </summary>
        public AudioLanguageSelection AudioLanguageSelection
        {
            get { return this._audioLanguageSelection; }
            set { this._audioLanguageSelection = value; }
        }

        // Check to see if AudioLanguageSelection property is set
        internal bool IsSetAudioLanguageSelection()
        {
            return this._audioLanguageSelection != null;
        }

        /// <summary>
        /// Gets and sets the property AudioPidSelection.
        /// </summary>
        public AudioPidSelection AudioPidSelection
        {
            get { return this._audioPidSelection; }
            set { this._audioPidSelection = value; }
        }

        // Check to see if AudioPidSelection property is set
        internal bool IsSetAudioPidSelection()
        {
            return this._audioPidSelection != null;
        }

        /// <summary>
        /// Gets and sets the property AudioTrackSelection.
        /// </summary>
        public AudioTrackSelection AudioTrackSelection
        {
            get { return this._audioTrackSelection; }
            set { this._audioTrackSelection = value; }
        }

        // Check to see if AudioTrackSelection property is set
        internal bool IsSetAudioTrackSelection()
        {
            return this._audioTrackSelection != null;
        }

    }
}