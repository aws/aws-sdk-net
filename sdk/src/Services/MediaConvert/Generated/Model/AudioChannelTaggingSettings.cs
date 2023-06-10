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
    /// When you mimic a multi-channel audio layout with multiple mono-channel tracks, you
    /// can tag each channel layout manually. For example, you would tag the tracks that contain
    /// your left, right, and center audio with Left (L), Right (R), and Center (C), respectively.
    /// When you don't specify a value, MediaConvert labels your track as Center (C) by default.
    /// To use audio layout tagging, your output must be in a QuickTime (.mov) container;
    /// your audio codec must be AAC, WAV, or AIFF; and you must set up your audio track to
    /// have only one channel.
    /// </summary>
    public partial class AudioChannelTaggingSettings
    {
        private AudioChannelTag _channelTag;

        /// <summary>
        /// Gets and sets the property ChannelTag. You can add a tag for this mono-channel audio
        /// track to mimic its placement in a multi-channel layout. For example, if this track
        /// is the left surround channel, choose Left surround (LS).
        /// </summary>
        public AudioChannelTag ChannelTag
        {
            get { return this._channelTag; }
            set { this._channelTag = value; }
        }

        // Check to see if ChannelTag property is set
        internal bool IsSetChannelTag()
        {
            return this._channelTag != null;
        }

    }
}