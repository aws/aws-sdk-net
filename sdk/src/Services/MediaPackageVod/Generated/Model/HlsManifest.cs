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
    /// An HTTP Live Streaming (HLS) manifest configuration.
    /// </summary>
    public partial class HlsManifest
    {
        private AdMarkers _adMarkers;
        private bool? _includeIframeOnlyStream;
        private string _manifestName;
        private int? _programDateTimeIntervalSeconds;
        private bool? _repeatExtXKey;
        private StreamSelection _streamSelection;

        /// <summary>
        /// Gets and sets the property AdMarkers. This setting controls how ad markers are included
        /// in the packaged OriginEndpoint."NONE" will omit all SCTE-35 ad markers from the output."PASSTHROUGH"
        /// causes the manifest to contain a copy of the SCTE-35 admarkers (comments) taken directly
        /// from the input HTTP Live Streaming (HLS) manifest."SCTE35_ENHANCED" generates ad markers
        /// and blackout tags based on SCTE-35messages in the input source.
        /// </summary>
        public AdMarkers AdMarkers
        {
            get { return this._adMarkers; }
            set { this._adMarkers = value; }
        }

        // Check to see if AdMarkers property is set
        internal bool IsSetAdMarkers()
        {
            return this._adMarkers != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeIframeOnlyStream. When enabled, an I-Frame only
        /// stream will be included in the output.
        /// </summary>
        public bool? IncludeIframeOnlyStream
        {
            get { return this._includeIframeOnlyStream; }
            set { this._includeIframeOnlyStream = value; }
        }

        // Check to see if IncludeIframeOnlyStream property is set
        internal bool IsSetIncludeIframeOnlyStream()
        {
            return this._includeIframeOnlyStream.HasValue; 
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
        /// Gets and sets the property ProgramDateTimeIntervalSeconds. The interval (in seconds)
        /// between each EXT-X-PROGRAM-DATE-TIME taginserted into manifests. Additionally, when
        /// an interval is specifiedID3Timed Metadata messages will be generated every 5 seconds
        /// using theingest time of the content.If the interval is not specified, or set to 0,
        /// thenno EXT-X-PROGRAM-DATE-TIME tags will be inserted into manifests and noID3Timed
        /// Metadata messages will be generated. Note that irrespectiveof this parameter, if any
        /// ID3 Timed Metadata is found in HTTP Live Streaming (HLS) input,it will be passed through
        /// to HLS output.
        /// </summary>
        public int? ProgramDateTimeIntervalSeconds
        {
            get { return this._programDateTimeIntervalSeconds; }
            set { this._programDateTimeIntervalSeconds = value; }
        }

        // Check to see if ProgramDateTimeIntervalSeconds property is set
        internal bool IsSetProgramDateTimeIntervalSeconds()
        {
            return this._programDateTimeIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RepeatExtXKey. When enabled, the EXT-X-KEY tag will be
        /// repeated in output manifests.
        /// </summary>
        public bool? RepeatExtXKey
        {
            get { return this._repeatExtXKey; }
            set { this._repeatExtXKey = value; }
        }

        // Check to see if RepeatExtXKey property is set
        internal bool IsSetRepeatExtXKey()
        {
            return this._repeatExtXKey.HasValue; 
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