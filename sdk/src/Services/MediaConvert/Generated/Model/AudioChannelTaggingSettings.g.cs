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
    /// Specify the QuickTime audio channel layout tags for the audio channels in this audio
    /// track. When you don't specify a value, MediaConvert labels your track as Center (C)
    /// by default. To use Audio layout tagging, your output must be in a QuickTime (MOV)
    /// container and your audio codec must be AAC, WAV, or AIFF.
    /// </summary>
    public partial class AudioChannelTaggingSettings
    {
        /// <summary>
        /// Gets and sets the property ChannelTag. Specify the QuickTime audio channel layout
        /// tags for the audio channels in this audio track. Enter channel layout tags in the
        /// same order as your output's audio channel order. For example, if your output audio
        /// track has a left and a right channel, enter Left (L) for the first channel and Right
        /// (R) for the second. If your output has multiple single-channel audio tracks, enter
        /// a single channel layout tag for each track.
        /// </summary>
        public AudioChannelTag ChannelTag { get; set; }

        /// <summary>
        /// Checks to see if the ChannelTag property is set.
        /// </summary>
        internal bool IsSetChannelTag() => this.ChannelTag != null;

        /// <summary>
        /// Gets and sets the property ChannelTags. Specify the QuickTime audio channel layout
        /// tags for the audio channels in this audio track. Enter channel layout tags in the
        /// same order as your output's audio channel order. For example, if your output audio
        /// track has a left and a right channel, enter Left (L) for the first channel and Right
        /// (R) for the second. If your output has multiple single-channel audio tracks, enter
        /// a single channel layout tag for each track.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChannelTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChannelTags property is set.
        /// </summary>
        internal bool IsSetChannelTags() => this.ChannelTags != null && (this.ChannelTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
