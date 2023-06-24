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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Create Dolby Vision Profile 5 or Profile 8.1 compatible video output.
    /// </summary>
    public partial class DolbyVision
    {
        private DolbyVisionLevel6Metadata _l6Metadata;
        private DolbyVisionLevel6Mode _l6Mode;
        private DolbyVisionMapping _mapping;
        private DolbyVisionProfile _profile;

        /// <summary>
        /// Gets and sets the property L6Metadata. Use these settings when you set DolbyVisionLevel6Mode
        /// to SPECIFY to override the MaxCLL and MaxFALL values in your input with new values.
        /// </summary>
        public DolbyVisionLevel6Metadata L6Metadata
        {
            get { return this._l6Metadata; }
            set { this._l6Metadata = value; }
        }

        // Check to see if L6Metadata property is set
        internal bool IsSetL6Metadata()
        {
            return this._l6Metadata != null;
        }

        /// <summary>
        /// Gets and sets the property L6Mode. Use Dolby Vision Mode to choose how the service
        /// will handle Dolby Vision MaxCLL and MaxFALL properies.
        /// </summary>
        public DolbyVisionLevel6Mode L6Mode
        {
            get { return this._l6Mode; }
            set { this._l6Mode = value; }
        }

        // Check to see if L6Mode property is set
        internal bool IsSetL6Mode()
        {
            return this._l6Mode != null;
        }

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
        public DolbyVisionMapping Mapping
        {
            get { return this._mapping; }
            set { this._mapping = value; }
        }

        // Check to see if Mapping property is set
        internal bool IsSetMapping()
        {
            return this._mapping != null;
        }

        /// <summary>
        /// Gets and sets the property Profile. Required when you enable Dolby Vision. Use Profile
        /// 5 to include frame-interleaved Dolby Vision metadata in your output. Your input must
        /// include Dolby Vision metadata or an HDR10 YUV color space. Use Profile 8.1 to include
        /// frame-interleaved Dolby Vision metadata and HDR10 metadata in your output. Your input
        /// must include Dolby Vision metadata.
        /// </summary>
        public DolbyVisionProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

    }
}