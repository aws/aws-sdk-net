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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
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
namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// An HTTP Live Streaming (HLS) packaging configuration.
    /// </summary>
    public partial class HlsPackage
    {
        private HlsEncryption _encryption;
        private List<HlsManifest> _hlsManifests = AWSConfigs.InitializeCollections ? new List<HlsManifest>() : null;
        private bool? _includeDvbSubtitles;
        private int? _segmentDurationSeconds;
        private bool? _useAudioRenditionGroup;

        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public HlsEncryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property HlsManifests. A list of HLS manifest configurations.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HlsManifest> HlsManifests
        {
            get { return this._hlsManifests; }
            set { this._hlsManifests = value; }
        }

        // Check to see if HlsManifests property is set
        internal bool IsSetHlsManifests()
        {
            return this._hlsManifests != null && (this._hlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeDvbSubtitles. When enabled, MediaPackage passes
        /// through digital video broadcasting (DVB) subtitles into the output.
        /// </summary>
        public bool? IncludeDvbSubtitles
        {
            get { return this._includeDvbSubtitles; }
            set { this._includeDvbSubtitles = value; }
        }

        // Check to see if IncludeDvbSubtitles property is set
        internal bool IsSetIncludeDvbSubtitles()
        {
            return this._includeDvbSubtitles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. Duration (in seconds) of each fragment.
        /// Actual fragments will berounded to the nearest multiple of the source fragment duration.
        /// </summary>
        public int? SegmentDurationSeconds
        {
            get { return this._segmentDurationSeconds; }
            set { this._segmentDurationSeconds = value; }
        }

        // Check to see if SegmentDurationSeconds property is set
        internal bool IsSetSegmentDurationSeconds()
        {
            return this._segmentDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseAudioRenditionGroup. When enabled, audio streams will
        /// be placed in rendition groups in the output.
        /// </summary>
        public bool? UseAudioRenditionGroup
        {
            get { return this._useAudioRenditionGroup; }
            set { this._useAudioRenditionGroup = value; }
        }

        // Check to see if UseAudioRenditionGroup property is set
        internal bool IsSetUseAudioRenditionGroup()
        {
            return this._useAudioRenditionGroup.HasValue; 
        }

    }
}