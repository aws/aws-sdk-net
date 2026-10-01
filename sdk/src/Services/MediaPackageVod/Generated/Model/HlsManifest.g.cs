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

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// An HTTP Live Streaming (HLS) manifest configuration.
    /// </summary>
    public partial class HlsManifest
    {
        /// <summary>
        /// Gets and sets the property AdMarkers. This setting controls how ad markers are included
        /// in the packaged OriginEndpoint. "NONE" will omit all SCTE-35 ad markers from the output.
        /// "PASSTHROUGH" causes the manifest to contain a copy of the SCTE-35 ad markers (comments)
        /// taken directly from the input HTTP Live Streaming (HLS) manifest. "SCTE35_ENHANCED"
        /// generates ad markers and blackout tags based on SCTE-35 messages in the input source.
        /// </summary>
        public AdMarkers AdMarkers { get; set; }

        /// <summary>
        /// Checks to see if the AdMarkers property is set.
        /// </summary>
        internal bool IsSetAdMarkers() => this.AdMarkers != null;

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
        /// Gets and sets the property ManifestName. An optional string to include in the name
        /// of the manifest.
        /// </summary>
        public string ManifestName { get; set; }

        /// <summary>
        /// Checks to see if the ManifestName property is set.
        /// </summary>
        internal bool IsSetManifestName() => this.ManifestName != null;

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

        /// <summary>
        /// Gets and sets the property RepeatExtXKey. When enabled, the EXT-X-KEY tag will be
        /// repeated in output manifests.
        /// </summary>
        public bool? RepeatExtXKey { get; set; }

        /// <summary>
        /// Checks to see if the RepeatExtXKey property is set.
        /// </summary>
        internal bool IsSetRepeatExtXKey() => this.RepeatExtXKey.HasValue;

        /// <summary>
        /// Gets and sets the property StreamSelection.
        /// </summary>
        public StreamSelection StreamSelection { get; set; }

        /// <summary>
        /// Checks to see if the StreamSelection property is set.
        /// </summary>
        internal bool IsSetStreamSelection() => this.StreamSelection != null;
    }
}
