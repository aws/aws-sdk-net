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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings for source monitoring.
    /// </summary>
    public partial class MonitoringConfig
    {
        private List<AudioMonitoringSetting> _audioMonitoringSettings = AWSConfigs.InitializeCollections ? new List<AudioMonitoringSetting>() : null;
        private ContentQualityAnalysisState _contentQualityAnalysisState;
        private ThumbnailState _thumbnailState;
        private List<VideoMonitoringSetting> _videoMonitoringSettings = AWSConfigs.InitializeCollections ? new List<VideoMonitoringSetting>() : null;

        /// <summary>
        /// Gets and sets the property AudioMonitoringSettings. Contains the settings for audio
        /// stream metrics monitoring.
        /// </summary>
        public List<AudioMonitoringSetting> AudioMonitoringSettings
        {
            get { return this._audioMonitoringSettings; }
            set { this._audioMonitoringSettings = value; }
        }

        // Check to see if AudioMonitoringSettings property is set
        internal bool IsSetAudioMonitoringSettings()
        {
            return this._audioMonitoringSettings != null && (this._audioMonitoringSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContentQualityAnalysisState. Indicates whether content
        /// quality analysis is enabled or disabled.
        /// </summary>
        public ContentQualityAnalysisState ContentQualityAnalysisState
        {
            get { return this._contentQualityAnalysisState; }
            set { this._contentQualityAnalysisState = value; }
        }

        // Check to see if ContentQualityAnalysisState property is set
        internal bool IsSetContentQualityAnalysisState()
        {
            return this._contentQualityAnalysisState != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailState. The state of thumbnail monitoring.
        /// </summary>
        public ThumbnailState ThumbnailState
        {
            get { return this._thumbnailState; }
            set { this._thumbnailState = value; }
        }

        // Check to see if ThumbnailState property is set
        internal bool IsSetThumbnailState()
        {
            return this._thumbnailState != null;
        }

        /// <summary>
        /// Gets and sets the property VideoMonitoringSettings. Contains the settings for video
        /// stream metrics monitoring.
        /// </summary>
        public List<VideoMonitoringSetting> VideoMonitoringSettings
        {
            get { return this._videoMonitoringSettings; }
            set { this._videoMonitoringSettings = value; }
        }

        // Check to see if VideoMonitoringSettings property is set
        internal bool IsSetVideoMonitoringSettings()
        {
            return this._videoMonitoringSettings != null && (this._videoMonitoringSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}