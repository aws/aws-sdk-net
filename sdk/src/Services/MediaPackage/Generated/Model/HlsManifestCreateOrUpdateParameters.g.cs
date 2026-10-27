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

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A HTTP Live Streaming (HLS) manifest configuration.
    /// </summary>
    public partial class HlsManifestCreateOrUpdateParameters
    {
        /// <summary>
        /// Gets and sets the property AdMarkers. This setting controls how ad markers are included
        /// in the packaged OriginEndpoint. "NONE" will omit all SCTE-35 ad markers from the output.
        /// "PASSTHROUGH" causes the manifest to contain a copy of the SCTE-35 ad markers (comments)
        /// taken directly from the input HTTP Live Streaming (HLS) manifest. "SCTE35_ENHANCED"
        /// generates ad markers and blackout tags based on SCTE-35 messages in the input source.
        /// "DATERANGE" inserts EXT-X-DATERANGE tags to signal ad and program transition events
        /// in HLS and CMAF manifests. For this option, you must set a programDateTimeIntervalSeconds
        /// value that is greater than 0.
        /// </summary>
        public AdMarkers AdMarkers { get; set; }

        /// <summary>
        /// Checks to see if the AdMarkers property is set.
        /// </summary>
        internal bool IsSetAdMarkers() => this.AdMarkers != null;

        /// <summary>
        /// Gets and sets the property AdTriggers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdTriggers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdTriggers property is set.
        /// </summary>
        internal bool IsSetAdTriggers() => this.AdTriggers != null && (this.AdTriggers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdsOnDeliveryRestrictions.
        /// </summary>
        public AdsOnDeliveryRestrictions AdsOnDeliveryRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the AdsOnDeliveryRestrictions property is set.
        /// </summary>
        internal bool IsSetAdsOnDeliveryRestrictions() => this.AdsOnDeliveryRestrictions != null;

        /// <summary>
        /// Gets and sets the property Id. The ID of the manifest. The ID must be unique within
        /// the OriginEndpoint and it cannot be changed after it is created.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IncludeIframeOnlyStream. When enabled, an I-Frame only
        /// stream will be included in the output.
        /// </summary>
        public bool? IncludeIframeOnlyStream { get; set; }

        /// <summary>
        /// Checks to see if the IncludeIframeOnlyStream property is set.
        /// </summary>
        internal bool IsSetIncludeIframeOnlyStream() => this.IncludeIframeOnlyStream.HasValue;

        /// <summary>
        /// Gets and sets the property ManifestName. An optional short string appended to the
        /// end of the OriginEndpoint URL. If not specified, defaults to the manifestName for
        /// the OriginEndpoint.
        /// </summary>
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

        /// <summary>
        /// Gets and sets the property PlaylistType. The HTTP Live Streaming (HLS) playlist type.
        /// When either "EVENT" or "VOD" is specified, a corresponding EXT-X-PLAYLIST-TYPE entry
        /// will be included in the media playlist.
        /// </summary>
        public PlaylistType PlaylistType { get; set; }

        /// <summary>
        /// Checks to see if the PlaylistType property is set.
        /// </summary>
        internal bool IsSetPlaylistType() => this.PlaylistType != null;

        /// <summary>
        /// Gets and sets the property PlaylistWindowSeconds. Time window (in seconds) contained
        /// in each parent manifest.
        /// </summary>
        public int? PlaylistWindowSeconds { get; set; }

        /// <summary>
        /// Checks to see if the PlaylistWindowSeconds property is set.
        /// </summary>
        internal bool IsSetPlaylistWindowSeconds() => this.PlaylistWindowSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ProgramDateTimeIntervalSeconds. The interval (in seconds)
        /// between each EXT-X-PROGRAM-DATE-TIME tag inserted into manifests. Additionally, when
        /// an interval is specified ID3Timed Metadata messages will be generated every 5 seconds
        /// using the ingest time of the content. If the interval is not specified, or set to
        /// 0, then no EXT-X-PROGRAM-DATE-TIME tags will be inserted into manifests and no ID3Timed
        /// Metadata messages will be generated. Note that irrespective of this parameter, if
        /// any ID3 Timed Metadata is found in HTTP Live Streaming (HLS) input, it will be passed
        /// through to HLS output.
        /// </summary>
        public int? ProgramDateTimeIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ProgramDateTimeIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetProgramDateTimeIntervalSeconds() => this.ProgramDateTimeIntervalSeconds.HasValue;
    }
}
