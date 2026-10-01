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
    /// Settings for preset
    /// </summary>
    public partial class PresetSettings
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
        /// Gets and sets the property CaptionDescriptions. This object holds groups of settings
        /// related to captions for one output. For each output that has captions, include one
        /// instance of CaptionDescriptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CaptionDescriptionPreset> CaptionDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<CaptionDescriptionPreset>() : null;

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
