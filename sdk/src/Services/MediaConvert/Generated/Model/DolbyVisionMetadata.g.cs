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
    /// Dolby Vision characteristics of the video track: the profile and level, and whether
    /// the RPU (dynamic metadata), base layer, and enhancement layer are present. Use this
    /// to distinguish Dolby Vision content from standard HEVC and to choose your encoding
    /// or passthrough settings. Omitted when the content is not Dolby Vision.
    /// </summary>
    public partial class DolbyVisionMetadata
    {
        /// <summary>
        /// Gets and sets the property BaseLayer. Whether a Dolby Vision component is present
        /// in the track.
        /// </summary>
        public DolbyVisionPresence BaseLayer { get; set; }

        /// <summary>
        /// Checks to see if the BaseLayer property is set.
        /// </summary>
        internal bool IsSetBaseLayer() => this.BaseLayer != null;

        /// <summary>
        /// Gets and sets the property EnhancementLayer. Whether a Dolby Vision component is present
        /// in the track.
        /// </summary>
        public DolbyVisionPresence EnhancementLayer { get; set; }

        /// <summary>
        /// Checks to see if the EnhancementLayer property is set.
        /// </summary>
        internal bool IsSetEnhancementLayer() => this.EnhancementLayer != null;

        /// <summary>
        /// Gets and sets the property Level. The Dolby Vision level, which indicates the maximum
        /// resolution and frame rate.
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level.HasValue;

        /// <summary>
        /// Gets and sets the property Profile. The Dolby Vision profile, for example 5, 7, or
        /// 8. The profile determines the layer structure and playback compatibility of the content.
        /// </summary>
        public int? Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile.HasValue;

        /// <summary>
        /// Gets and sets the property Rpu. Whether a Dolby Vision component is present in the
        /// track.
        /// </summary>
        public DolbyVisionPresence Rpu { get; set; }

        /// <summary>
        /// Checks to see if the Rpu property is set.
        /// </summary>
        internal bool IsSetRpu() => this.Rpu != null;
    }
}
