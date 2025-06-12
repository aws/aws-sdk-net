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
    /// Encoder Settings
    /// </summary>
    public partial class EncoderSettings
    {
        private List<AudioDescription> _audioDescriptions = AWSConfigs.InitializeCollections ? new List<AudioDescription>() : null;
        private AvailBlanking _availBlanking;
        private AvailConfiguration _availConfiguration;
        private BlackoutSlate _blackoutSlate;
        private List<CaptionDescription> _captionDescriptions = AWSConfigs.InitializeCollections ? new List<CaptionDescription>() : null;
        private ColorCorrectionSettings _colorCorrectionSettings;
        private FeatureActivations _featureActivations;
        private GlobalConfiguration _globalConfiguration;
        private MotionGraphicsConfiguration _motionGraphicsConfiguration;
        private NielsenConfiguration _nielsenConfiguration;
        private List<OutputGroup> _outputGroups = AWSConfigs.InitializeCollections ? new List<OutputGroup>() : null;
        private ThumbnailConfiguration _thumbnailConfiguration;
        private TimecodeConfig _timecodeConfig;
        private List<VideoDescription> _videoDescriptions = AWSConfigs.InitializeCollections ? new List<VideoDescription>() : null;

        /// <summary>
        /// Gets and sets the property AudioDescriptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AvailBlanking. Settings for ad avail blanking.
        /// </summary>
        public AvailBlanking AvailBlanking
        {
            get { return this._availBlanking; }
            set { this._availBlanking = value; }
        }

        // Check to see if AvailBlanking property is set
        internal bool IsSetAvailBlanking()
        {
            return this._availBlanking != null;
        }

        /// <summary>
        /// Gets and sets the property AvailConfiguration. Event-wide configuration settings for
        /// ad avail insertion.
        /// </summary>
        public AvailConfiguration AvailConfiguration
        {
            get { return this._availConfiguration; }
            set { this._availConfiguration = value; }
        }

        // Check to see if AvailConfiguration property is set
        internal bool IsSetAvailConfiguration()
        {
            return this._availConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BlackoutSlate. Settings for blackout slate.
        /// </summary>
        public BlackoutSlate BlackoutSlate
        {
            get { return this._blackoutSlate; }
            set { this._blackoutSlate = value; }
        }

        // Check to see if BlackoutSlate property is set
        internal bool IsSetBlackoutSlate()
        {
            return this._blackoutSlate != null;
        }

        /// <summary>
        /// Gets and sets the property CaptionDescriptions. Settings for caption decriptions
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
        /// Gets and sets the property ColorCorrectionSettings. Color Correction Settings
        /// </summary>
        public ColorCorrectionSettings ColorCorrectionSettings
        {
            get { return this._colorCorrectionSettings; }
            set { this._colorCorrectionSettings = value; }
        }

        // Check to see if ColorCorrectionSettings property is set
        internal bool IsSetColorCorrectionSettings()
        {
            return this._colorCorrectionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureActivations. Feature Activations
        /// </summary>
        public FeatureActivations FeatureActivations
        {
            get { return this._featureActivations; }
            set { this._featureActivations = value; }
        }

        // Check to see if FeatureActivations property is set
        internal bool IsSetFeatureActivations()
        {
            return this._featureActivations != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalConfiguration. Configuration settings that apply
        /// to the event as a whole.
        /// </summary>
        public GlobalConfiguration GlobalConfiguration
        {
            get { return this._globalConfiguration; }
            set { this._globalConfiguration = value; }
        }

        // Check to see if GlobalConfiguration property is set
        internal bool IsSetGlobalConfiguration()
        {
            return this._globalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MotionGraphicsConfiguration. Settings for motion graphics.
        /// </summary>
        public MotionGraphicsConfiguration MotionGraphicsConfiguration
        {
            get { return this._motionGraphicsConfiguration; }
            set { this._motionGraphicsConfiguration = value; }
        }

        // Check to see if MotionGraphicsConfiguration property is set
        internal bool IsSetMotionGraphicsConfiguration()
        {
            return this._motionGraphicsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NielsenConfiguration. Nielsen configuration settings.
        /// </summary>
        public NielsenConfiguration NielsenConfiguration
        {
            get { return this._nielsenConfiguration; }
            set { this._nielsenConfiguration = value; }
        }

        // Check to see if NielsenConfiguration property is set
        internal bool IsSetNielsenConfiguration()
        {
            return this._nielsenConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OutputGroups.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<OutputGroup> OutputGroups
        {
            get { return this._outputGroups; }
            set { this._outputGroups = value; }
        }

        // Check to see if OutputGroups property is set
        internal bool IsSetOutputGroups()
        {
            return this._outputGroups != null && (this._outputGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThumbnailConfiguration. Thumbnail configuration settings.
        /// </summary>
        public ThumbnailConfiguration ThumbnailConfiguration
        {
            get { return this._thumbnailConfiguration; }
            set { this._thumbnailConfiguration = value; }
        }

        // Check to see if ThumbnailConfiguration property is set
        internal bool IsSetThumbnailConfiguration()
        {
            return this._thumbnailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TimecodeConfig. Contains settings used to acquire and adjust
        /// timecode information from inputs.
        /// </summary>
        [AWSProperty(Required=true)]
        public TimecodeConfig TimecodeConfig
        {
            get { return this._timecodeConfig; }
            set { this._timecodeConfig = value; }
        }

        // Check to see if TimecodeConfig property is set
        internal bool IsSetTimecodeConfig()
        {
            return this._timecodeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VideoDescriptions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VideoDescription> VideoDescriptions
        {
            get { return this._videoDescriptions; }
            set { this._videoDescriptions = value; }
        }

        // Check to see if VideoDescriptions property is set
        internal bool IsSetVideoDescriptions()
        {
            return this._videoDescriptions != null && (this._videoDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}