/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for preset
    /// </summary>
    public partial class PresetSettings
    {
        private List<AudioDescription> _audioDescriptions = new List<AudioDescription>();
        private List<CaptionDescriptionPreset> _captionDescriptions = new List<CaptionDescriptionPreset>();
        private ContainerSettings _containerSettings;
        private VideoDescription _videoDescription;

        /// <summary>
        /// Gets and sets the property AudioDescriptions. (AudioDescriptions) contains groups
        /// of audio encoding settings organized by audio codec. Include one instance of (AudioDescriptions)
        /// per output. (AudioDescriptions) can contain multiple groups of encoding settings.
        /// </summary>
        public List<AudioDescription> AudioDescriptions
        {
            get { return this._audioDescriptions; }
            set { this._audioDescriptions = value; }
        }

        // Check to see if AudioDescriptions property is set
        internal bool IsSetAudioDescriptions()
        {
            return this._audioDescriptions != null && this._audioDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptionDescriptions. Caption settings for this preset.
        /// There can be multiple caption settings in a single output.
        /// </summary>
        public List<CaptionDescriptionPreset> CaptionDescriptions
        {
            get { return this._captionDescriptions; }
            set { this._captionDescriptions = value; }
        }

        // Check to see if CaptionDescriptions property is set
        internal bool IsSetCaptionDescriptions()
        {
            return this._captionDescriptions != null && this._captionDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContainerSettings.
        /// </summary>
        public ContainerSettings ContainerSettings
        {
            get { return this._containerSettings; }
            set { this._containerSettings = value; }
        }

        // Check to see if ContainerSettings property is set
        internal bool IsSetContainerSettings()
        {
            return this._containerSettings != null;
        }

        /// <summary>
        /// Gets and sets the property VideoDescription. (VideoDescription) contains a group of
        /// video encoding settings. The specific video settings depend on the video codec you
        /// choose when you specify a value for Video codec (codec). Include one instance of (VideoDescription)
        /// per output.
        /// </summary>
        public VideoDescription VideoDescription
        {
            get { return this._videoDescription; }
            set { this._videoDescription = value; }
        }

        // Check to see if VideoDescription property is set
        internal bool IsSetVideoDescription()
        {
            return this._videoDescription != null;
        }

    }
}