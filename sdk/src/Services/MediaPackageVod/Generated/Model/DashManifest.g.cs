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
    /// A DASH manifest configuration.
    /// </summary>
    public partial class DashManifest
    {
        /// <summary>
        /// Gets and sets the property ManifestLayout. Determines the position of some tags in
        /// the Media Presentation Description (MPD). When set to FULL, elements like SegmentTemplate
        /// and ContentProtection are included in each Representation. When set to COMPACT, duplicate
        /// elements are combined and presented at the AdaptationSet level.
        /// </summary>
        public ManifestLayout ManifestLayout { get; set; }

        /// <summary>
        /// Checks to see if the ManifestLayout property is set.
        /// </summary>
        internal bool IsSetManifestLayout() => this.ManifestLayout != null;

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
        /// Gets and sets the property MinBufferTimeSeconds. Minimum duration (in seconds) that
        /// a player will buffer media before starting the presentation.
        /// </summary>
        public int? MinBufferTimeSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MinBufferTimeSeconds property is set.
        /// </summary>
        internal bool IsSetMinBufferTimeSeconds() => this.MinBufferTimeSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Profile. The Dynamic Adaptive Streaming over HTTP (DASH)
        /// profile type. When set to "HBBTV_1_5", HbbTV 1.5 compliant output is enabled.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;

        /// <summary>
        /// Gets and sets the property ScteMarkersSource. The source of scte markers used. When
        /// set to SEGMENTS, the scte markers are sourced from the segments of the ingested content.
        /// When set to MANIFEST, the scte markers are sourced from the manifest of the ingested
        /// content.
        /// </summary>
        public ScteMarkersSource ScteMarkersSource { get; set; }

        /// <summary>
        /// Checks to see if the ScteMarkersSource property is set.
        /// </summary>
        internal bool IsSetScteMarkersSource() => this.ScteMarkersSource != null;

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
