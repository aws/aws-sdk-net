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

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// A DASH manifest configuration.
    /// </summary>
    public partial class DashManifest
    {
        private ManifestLayout _manifestLayout;
        private string _manifestName;
        private int? _minBufferTimeSeconds;
        private Profile _profile;
        private ScteMarkersSource _scteMarkersSource;
        private StreamSelection _streamSelection;

        /// <summary>
        /// Gets and sets the property ManifestLayout. Determines the position of some tags in
        /// the Media Presentation Description (MPD).  When set to FULL, elements like SegmentTemplate
        /// and ContentProtection are included in each Representation.  When set to COMPACT, duplicate
        /// elements are combined and presented at the AdaptationSet level.
        /// </summary>
        public ManifestLayout ManifestLayout
        {
            get { return this._manifestLayout; }
            set { this._manifestLayout = value; }
        }

        // Check to see if ManifestLayout property is set
        internal bool IsSetManifestLayout()
        {
            return this._manifestLayout != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestName. An optional string to include in the name
        /// of the manifest.
        /// </summary>
        public string ManifestName
        {
            get { return this._manifestName; }
            set { this._manifestName = value; }
        }

        // Check to see if ManifestName property is set
        internal bool IsSetManifestName()
        {
            return this._manifestName != null;
        }

        /// <summary>
        /// Gets and sets the property MinBufferTimeSeconds. Minimum duration (in seconds) that
        /// a player will buffer media before starting the presentation.
        /// </summary>
        public int MinBufferTimeSeconds
        {
            get { return this._minBufferTimeSeconds.GetValueOrDefault(); }
            set { this._minBufferTimeSeconds = value; }
        }

        // Check to see if MinBufferTimeSeconds property is set
        internal bool IsSetMinBufferTimeSeconds()
        {
            return this._minBufferTimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Profile. The Dynamic Adaptive Streaming over HTTP (DASH)
        /// profile type.  When set to "HBBTV_1_5", HbbTV 1.5 compliant output is enabled.
        /// </summary>
        public Profile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property ScteMarkersSource. The source of scte markers used. When
        /// set to SEGMENTS, the scte markers are sourced from the segments of the ingested content.
        /// When set to MANIFEST, the scte markers are sourced from the manifest of the ingested
        /// content. The MANIFEST value is compatible with source HLS playlists using the SCTE-35
        /// Enhanced syntax (#EXT-OATCLS-SCTE35 tags). SCTE-35 Elemental and SCTE-35 Daterange
        /// syntaxes are not supported with this option.
        /// </summary>
        public ScteMarkersSource ScteMarkersSource
        {
            get { return this._scteMarkersSource; }
            set { this._scteMarkersSource = value; }
        }

        // Check to see if ScteMarkersSource property is set
        internal bool IsSetScteMarkersSource()
        {
            return this._scteMarkersSource != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSelection.
        /// </summary>
        public StreamSelection StreamSelection
        {
            get { return this._streamSelection; }
            set { this._streamSelection = value; }
        }

        // Check to see if StreamSelection property is set
        internal bool IsSetStreamSelection()
        {
            return this._streamSelection != null;
        }

    }
}