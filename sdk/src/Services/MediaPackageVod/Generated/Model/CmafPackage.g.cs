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
    /// A CMAF packaging configuration.
    /// </summary>
    public partial class CmafPackage
    {
        /// <summary>
        /// Gets and sets the property Encryption.
        /// </summary>
        public CmafEncryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property HlsManifests. A list of HLS manifest configurations.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HlsManifest> HlsManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<HlsManifest>() : null;

        /// <summary>
        /// Checks to see if the HlsManifests property is set.
        /// </summary>
        internal bool IsSetHlsManifests() => this.HlsManifests != null && (this.HlsManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeEncoderConfigurationInSegments. When includeEncoderConfigurationInSegments
        /// is set to true, MediaPackage places your encoder's Sequence Parameter Set (SPS), Picture
        /// Parameter Set (PPS), and Video Parameter Set (VPS) metadata in every video segment
        /// instead of in the init fragment. This lets you use different SPS/PPS/VPS settings
        /// for your assets during content playback.
        /// </summary>
        public bool? IncludeEncoderConfigurationInSegments { get; set; }

        /// <summary>
        /// Checks to see if the IncludeEncoderConfigurationInSegments property is set.
        /// </summary>
        internal bool IsSetIncludeEncoderConfigurationInSegments() => this.IncludeEncoderConfigurationInSegments.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentDurationSeconds. Duration (in seconds) of each fragment.
        /// Actual fragments will be rounded to the nearest multiple of the source fragment duration.
        /// </summary>
        public int? SegmentDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SegmentDurationSeconds property is set.
        /// </summary>
        internal bool IsSetSegmentDurationSeconds() => this.SegmentDurationSeconds.HasValue;
    }
}
