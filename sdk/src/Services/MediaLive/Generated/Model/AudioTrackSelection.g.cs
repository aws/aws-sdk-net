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
    /// Audio Track Selection
    /// </summary>
    public partial class AudioTrackSelection
    {
        /// <summary>
        /// Gets and sets the property DolbyEDecode. Configure decoding options for Dolby E streams
        /// - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337
        /// </summary>
        public AudioDolbyEDecode DolbyEDecode { get; set; }

        /// <summary>
        /// Checks to see if the DolbyEDecode property is set.
        /// </summary>
        internal bool IsSetDolbyEDecode() => this.DolbyEDecode != null;

        /// <summary>
        /// Gets and sets the property Tracks. Selects one or more unique audio tracks from within
        /// a source.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AudioTrack> Tracks { get; set; } = AWSConfigs.InitializeCollections ? new List<AudioTrack>() : null;

        /// <summary>
        /// Checks to see if the Tracks property is set.
        /// </summary>
        internal bool IsSetTracks() => this.Tracks != null && (this.Tracks.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
