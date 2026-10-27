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
    /// Encoder Settings
    /// </summary>
    public partial class EncoderSettings
    {
        /// <summary>
        /// Gets and sets the property AudioDescriptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AudioDescription> AudioDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioDescription>() : null;

        /// <summary>
        /// Checks to see if the AudioDescriptions property is set.
        /// </summary>
        internal bool IsSetAudioDescriptions() => this.AudioDescriptions != null && (this.AudioDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailBlanking. Settings for ad avail blanking.
        /// </summary>
        public AvailBlanking AvailBlanking { get; set; }

        /// <summary>
        /// Checks to see if the AvailBlanking property is set.
        /// </summary>
        internal bool IsSetAvailBlanking() => this.AvailBlanking != null;

        /// <summary>
        /// Gets and sets the property AvailConfiguration. Event-wide configuration settings for
        /// ad avail insertion.
        /// </summary>
        public AvailConfiguration AvailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AvailConfiguration property is set.
        /// </summary>
        internal bool IsSetAvailConfiguration() => this.AvailConfiguration != null;

        /// <summary>
        /// Gets and sets the property BlackoutSlate. Settings for blackout slate.
        /// </summary>
        public BlackoutSlate BlackoutSlate { get; set; }

        /// <summary>
        /// Checks to see if the BlackoutSlate property is set.
        /// </summary>
        internal bool IsSetBlackoutSlate() => this.BlackoutSlate != null;

        /// <summary>
        /// Gets and sets the property CaptionDescriptions. Settings for caption decriptions
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
        /// Gets and sets the property ColorCorrectionSettings. Color Correction Settings
        /// </summary>
        public ColorCorrectionSettings ColorCorrectionSettings { get; set; }

        /// <summary>
        /// Checks to see if the ColorCorrectionSettings property is set.
        /// </summary>
        internal bool IsSetColorCorrectionSettings() => this.ColorCorrectionSettings != null;

        /// <summary>
        /// Gets and sets the property FeatureActivations. Feature Activations
        /// </summary>
        public FeatureActivations FeatureActivations { get; set; }

        /// <summary>
        /// Checks to see if the FeatureActivations property is set.
        /// </summary>
        internal bool IsSetFeatureActivations() => this.FeatureActivations != null;

        /// <summary>
        /// Gets and sets the property GlobalConfiguration. Configuration settings that apply
        /// to the event as a whole.
        /// </summary>
        public GlobalConfiguration GlobalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GlobalConfiguration property is set.
        /// </summary>
        internal bool IsSetGlobalConfiguration() => this.GlobalConfiguration != null;

        /// <summary>
        /// Gets and sets the property MotionGraphicsConfiguration. Settings for motion graphics.
        /// </summary>
        public MotionGraphicsConfiguration MotionGraphicsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MotionGraphicsConfiguration property is set.
        /// </summary>
        internal bool IsSetMotionGraphicsConfiguration() => this.MotionGraphicsConfiguration != null;

        /// <summary>
        /// Gets and sets the property NielsenConfiguration. Nielsen configuration settings.
        /// </summary>
        public NielsenConfiguration NielsenConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NielsenConfiguration property is set.
        /// </summary>
        internal bool IsSetNielsenConfiguration() => this.NielsenConfiguration != null;

        /// <summary>
        /// Gets and sets the property OutputGroups.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<OutputGroup> OutputGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputGroup>() : null;

        /// <summary>
        /// Checks to see if the OutputGroups property is set.
        /// </summary>
        internal bool IsSetOutputGroups() => this.OutputGroups != null && (this.OutputGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThumbnailConfiguration. Thumbnail configuration settings.
        /// </summary>
        public ThumbnailConfiguration ThumbnailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailConfiguration property is set.
        /// </summary>
        internal bool IsSetThumbnailConfiguration() => this.ThumbnailConfiguration != null;

        /// <summary>
        /// Gets and sets the property TimecodeConfig. Contains settings used to acquire and adjust
        /// timecode information from inputs.
        /// </summary>
        [AWSProperty(Required = true)]
        public TimecodeConfig TimecodeConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimecodeConfig property is set.
        /// </summary>
        internal bool IsSetTimecodeConfig() => this.TimecodeConfig != null;

        /// <summary>
        /// Gets and sets the property VideoDescriptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<VideoDescription> VideoDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<VideoDescription>() : null;

        /// <summary>
        /// Checks to see if the VideoDescriptions property is set.
        /// </summary>
        internal bool IsSetVideoDescriptions() => this.VideoDescriptions != null && (this.VideoDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
