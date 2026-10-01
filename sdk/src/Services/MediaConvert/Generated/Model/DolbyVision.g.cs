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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Create Dolby Vision Profile 5 or Profile 8.1 compatible video output.
    /// </summary>
    public partial class DolbyVision
    {
        /// <summary>
        /// Gets and sets the property Compatibility. When you set Compatibility mapping to Duplicate
        /// Stream, DolbyVision streams that have a backward compatible base layer (e.g., DolbyVision
        /// 8.1) will cause a duplicate stream to be signaled in the manifest as a duplicate stream.
        /// When you set Compatibility mapping to Supplemntal Codecs, DolbyVision streams that
        /// have a backward compatible base layer (e.g., DolbyVision 8.1) will cause the associate
        /// stream in the manifest to include a SUPPLEMENTAL_CODECS property.
        /// </summary>
        public DolbyVisionCompatibility Compatibility { get; set; }

        /// <summary>
        /// Checks to see if the Compatibility property is set.
        /// </summary>
        internal bool IsSetCompatibility() => this.Compatibility != null;

        /// <summary>
        /// Gets and sets the property L6Metadata. Use these settings when you set DolbyVisionLevel6Mode
        /// to SPECIFY to override the MaxCLL and MaxFALL values in your input with new values.
        /// </summary>
        public DolbyVisionLevel6Metadata L6Metadata { get; set; }

        /// <summary>
        /// Checks to see if the L6Metadata property is set.
        /// </summary>
        internal bool IsSetL6Metadata() => this.L6Metadata != null;

        /// <summary>
        /// Gets and sets the property L6Mode. Use Dolby Vision Mode to choose how the service
        /// will handle Dolby Vision MaxCLL and MaxFALL properies.
        /// </summary>
        public DolbyVisionLevel6Mode L6Mode { get; set; }

        /// <summary>
        /// Checks to see if the L6Mode property is set.
        /// </summary>
        internal bool IsSetL6Mode() => this.L6Mode != null;

        /// <summary>
        /// Gets and sets the property Mapping. Required when you set Dolby Vision Profile to
        /// Profile 8.1. When you set Content mapping to None, content mapping is not applied
        /// to the HDR10-compatible signal. Depending on the source peak nit level, clipping might
        /// occur on HDR devices without Dolby Vision. When you set Content mapping to HDR10 1000,
        /// the transcoder creates a 1,000 nits peak HDR10-compatible signal by applying static
        /// content mapping to the source. This mode is speed-optimized for PQ10 sources with
        /// metadata that is created from analysis. For graded Dolby Vision content, be aware
        /// that creative intent might not be guaranteed with extreme 1,000 nits trims.
        /// </summary>
        public DolbyVisionMapping Mapping { get; set; }

        /// <summary>
        /// Checks to see if the Mapping property is set.
        /// </summary>
        internal bool IsSetMapping() => this.Mapping != null;

        /// <summary>
        /// Gets and sets the property Profile. Required when you enable Dolby Vision. Use Profile
        /// 5 to include frame-interleaved Dolby Vision metadata in your output. Your input must
        /// include Dolby Vision metadata or an HDR10 YUV color space. Use Profile 8.1 to include
        /// frame-interleaved Dolby Vision metadata and HDR10 metadata in your output. Your input
        /// must include Dolby Vision metadata.
        /// </summary>
        public DolbyVisionProfile Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;
    }
}
