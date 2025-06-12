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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Each output in your job is a collection of settings that describes how you want MediaConvert
    /// to encode a single output file or stream. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/create-outputs.html.
    /// </summary>
    public partial class Output
    {
        private List<AudioDescription> _audioDescriptions = AWSConfigs.InitializeCollections ? new List<AudioDescription>() : null;
        private List<CaptionDescription> _captionDescriptions = AWSConfigs.InitializeCollections ? new List<CaptionDescription>() : null;
        private ContainerSettings _containerSettings;
        private string _extension;
        private string _nameModifier;
        private OutputSettings _outputSettings;
        private string _preset;
        private VideoDescription _videoDescription;

        /// <summary>
        /// Gets and sets the property AudioDescriptions. Contains groups of audio encoding settings
        /// organized by audio codec. Include one instance of per output. Can contain multiple
        /// groups of encoding settings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioDescription> AudioDescriptions
        {
            get { return this._audioDescriptions; }
            set { this._audioDescriptions = value; }
        }

        // Check to see if AudioDescriptions property is set
        internal bool IsSetAudioDescriptions()
        {
            return this._audioDescriptions != null && (this._audioDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaptionDescriptions. Contains groups of captions settings.
        /// For each output that has captions, include one instance of CaptionDescriptions. Can
        /// contain multiple groups of captions settings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CaptionDescription> CaptionDescriptions
        {
            get { return this._captionDescriptions; }
            set { this._captionDescriptions = value; }
        }

        // Check to see if CaptionDescriptions property is set
        internal bool IsSetCaptionDescriptions()
        {
            return this._captionDescriptions != null && (this._captionDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerSettings. Container specific settings.
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
        /// Gets and sets the property Extension. Use Extension to specify the file extension
        /// for outputs in File output groups. If you do not specify a value, the service will
        /// use default extensions by container type as follows * MPEG-2 transport stream, m2ts
        /// * Quicktime, mov * MXF container, mxf * MPEG-4 container, mp4 * WebM container, webm
        /// * Animated GIF container, gif * No Container, the service will use codec extensions
        /// (e.g. AAC, H265, H265, AC3)
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property NameModifier. Use Name modifier to have the service add
        /// a string to the end of each output filename. You specify the base filename as part
        /// of your destination URI. When you create multiple outputs in the same output group,
        /// Name modifier is required. Name modifier also accepts format identifiers. For DASH
        /// ISO outputs, if you use the format identifiers $Number$ or $Time$ in one output, you
        /// must use them in the same way in all outputs of the output group.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property OutputSettings. Specific settings for this type of output.
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
        /// Gets and sets the property Preset. Use Preset to specify a preset for your transcoding
        /// settings. Provide the system or custom preset name. You can specify either Preset
        /// or Container settings, but not both.
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property VideoDescription. VideoDescription contains a group of
        /// video encoding settings. The specific video settings depend on the video codec that
        /// you choose for the property codec. Include one instance of VideoDescription per output.
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