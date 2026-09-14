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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Each output in your job is a collection of settings that describes how you want MediaConvert
    /// to encode a single output file or stream. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/create-outputs.html.
    /// </summary>
    public partial class Output
    {
        /// <summary>
        /// Gets and sets the property AudioDescriptions. Contains groups of audio encoding settings
        /// organized by audio codec. Include one instance of per output. Can contain multiple
        /// groups of encoding settings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AudioDescription> AudioDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioDescription>() : null;

        /// <summary>
        /// Checks to see if the AudioDescriptions property is set.
        /// </summary>
        internal bool IsSetAudioDescriptions() => this.AudioDescriptions != null && (this.AudioDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptionDescriptions. Contains groups of captions settings.
        /// For each output that has captions, include one instance of CaptionDescriptions. Can
        /// contain multiple groups of captions settings.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CaptionDescription> CaptionDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<CaptionDescription>() : null;

        /// <summary>
        /// Checks to see if the CaptionDescriptions property is set.
        /// </summary>
        internal bool IsSetCaptionDescriptions() => this.CaptionDescriptions != null && (this.CaptionDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainerSettings. Container specific settings.
        /// </summary>
        public ContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Checks to see if the ContainerSettings property is set.
        /// </summary>
        internal bool IsSetContainerSettings() => this.ContainerSettings != null;

        /// <summary>
        /// Gets and sets the property Extension. Use Extension to specify the file extension
        /// for outputs in File output groups. If you do not specify a value, the service will
        /// use default extensions by container type as follows * MPEG-2 transport stream, m2ts
        /// * Quicktime, mov * MXF container, mxf * MPEG-4 container, mp4 * WebM container, webm
        /// * Animated GIF container, gif * No Container, the service will use codec extensions
        /// (e.g. AAC, H265, H265, AC3)
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Extension { get; set; }

        /// <summary>
        /// Checks to see if the Extension property is set.
        /// </summary>
        internal bool IsSetExtension() => this.Extension != null;

        /// <summary>
        /// Gets and sets the property NameModifier. Use Name modifier to have the service add
        /// a string to the end of each output filename. You specify the base filename as part
        /// of your destination URI. When you create multiple outputs in the same output group,
        /// Name modifier is required. Name modifier also accepts format identifiers. For DASH
        /// ISO outputs, if you use the format identifiers $Number$ or $Time$ in one output, you
        /// must use them in the same way in all outputs of the output group.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NameModifier { get; set; }

        /// <summary>
        /// Checks to see if the NameModifier property is set.
        /// </summary>
        internal bool IsSetNameModifier() => this.NameModifier != null;

        /// <summary>
        /// Gets and sets the property OutputSettings. Specific settings for this type of output.
        /// </summary>
        public OutputSettings OutputSettings { get; set; }

        /// <summary>
        /// Checks to see if the OutputSettings property is set.
        /// </summary>
        internal bool IsSetOutputSettings() => this.OutputSettings != null;

        /// <summary>
        /// Gets and sets the property Preset. Use Preset to specify a preset for your transcoding
        /// settings. Provide the system or custom preset name. You can specify either Preset
        /// or Container settings, but not both.
        /// </summary>
        [AWSProperty(Min = 0)]
        public string Preset { get; set; }

        /// <summary>
        /// Checks to see if the Preset property is set.
        /// </summary>
        internal bool IsSetPreset() => this.Preset != null;

        /// <summary>
        /// Gets and sets the property VideoDescription. VideoDescription contains a group of
        /// video encoding settings. The specific video settings depend on the video codec that
        /// you choose for the property codec. Include one instance of VideoDescription per output.
        /// </summary>
        public VideoDescription VideoDescription { get; set; }

        /// <summary>
        /// Checks to see if the VideoDescription property is set.
        /// </summary>
        internal bool IsSetVideoDescription() => this.VideoDescription != null;
    }
}
