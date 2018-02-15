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
    /// An output object describes the settings for a single output file or stream in an output
    /// group.
    /// </summary>
    public partial class Output
    {
        private List<AudioDescription> _audioDescriptions = new List<AudioDescription>();
        private List<CaptionDescription> _captionDescriptions = new List<CaptionDescription>();
        private ContainerSettings _containerSettings;
        private string _extension;
        private string _nameModifier;
        private OutputSettings _outputSettings;
        private string _preset;
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
        /// Gets and sets the property CaptionDescriptions. (CaptionDescriptions) contains groups
        /// of captions settings. For each output that has captions, include one instance of (CaptionDescriptions).
        /// (CaptionDescriptions) can contain multiple groups of captions settings.
        /// </summary>
        public List<CaptionDescription> CaptionDescriptions
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
        /// Gets and sets the property Extension. Use Extension (Extension) to specify the file
        /// extension for outputs in File output groups. If you do not specify a value, the service
        /// will use default extensions by container type as follows * MPEG-2 transport stream,
        /// m2ts * Quicktime, mov * MXF container, mxf * MPEG-4 container, mp4 * No Container,
        /// the service will use codec extensions (e.g. AAC, H265, H265, AC3)
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        // Check to see if Extension property is set
        internal bool IsSetExtension()
        {
            return this._extension != null;
        }

        /// <summary>
        /// Gets and sets the property NameModifier. Use Name modifier (NameModifier) to have
        /// the service add a string to the end of each output filename. You specify the base
        /// filename as part of your destination URI. When you create multiple outputs in the
        /// same output group, Name modifier (NameModifier) is required. Name modifier also accepts
        /// format identifiers. For DASH ISO outputs, if you use the format identifiers $Number$
        /// or $Time$ in one output, you must use them in the same way in all outputs of the output
        /// group.
        /// </summary>
        public string NameModifier
        {
            get { return this._nameModifier; }
            set { this._nameModifier = value; }
        }

        // Check to see if NameModifier property is set
        internal bool IsSetNameModifier()
        {
            return this._nameModifier != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSettings.
        /// </summary>
        public OutputSettings OutputSettings
        {
            get { return this._outputSettings; }
            set { this._outputSettings = value; }
        }

        // Check to see if OutputSettings property is set
        internal bool IsSetOutputSettings()
        {
            return this._outputSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Preset. Use Preset (Preset) to specifiy a preset for your
        /// transcoding settings. Provide the system or custom preset name. You can specify either
        /// Preset (Preset) or Container settings (ContainerSettings), but not both.
        /// </summary>
        public string Preset
        {
            get { return this._preset; }
            set { this._preset = value; }
        }

        // Check to see if Preset property is set
        internal bool IsSetPreset()
        {
            return this._preset != null;
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