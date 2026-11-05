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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Represents a single audio track for selection with optional pre-mixer settings
    /// </summary>
    public partial class AudioTrack
    {
        /// <summary>
        /// Gets and sets the property PremixSettings. Optional audio pre-mixer settings for this
        /// track. When specified, allows per-track audio processing including channel remixing,
        /// gain adjustment, and loudness normalization before interleaving.
        /// </summary>
        public AudioPreMixerSettings PremixSettings { get; set; }

        /// <summary>
        /// Checks to see if the PremixSettings property is set.
        /// </summary>
        internal bool IsSetPremixSettings() => this.PremixSettings != null;

        /// <summary>
        /// Gets and sets the property Track. 1-based integer value that maps to a specific audio
        /// track
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Track { get; set; }

        /// <summary>
        /// Checks to see if the Track property is set.
        /// </summary>
        internal bool IsSetTrack() => this.Track.HasValue;
    }
}
