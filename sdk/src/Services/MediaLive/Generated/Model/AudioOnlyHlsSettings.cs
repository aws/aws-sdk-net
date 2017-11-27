/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for AudioOnlyHlsSettings
    /// </summary>
    public partial class AudioOnlyHlsSettings
    {
        private string _audioGroupId;
        private InputLocation _audioOnlyImage;
        private AudioOnlyHlsTrackType _audioTrackType;

        /// <summary>
        /// Gets and sets the property AudioGroupId. Specifies the group to which the audio Rendition
        /// belongs.
        /// </summary>
        public string AudioGroupId
        {
            get { return this._audioGroupId; }
            set { this._audioGroupId = value; }
        }

        // Check to see if AudioGroupId property is set
        internal bool IsSetAudioGroupId()
        {
            return this._audioGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AudioOnlyImage. For use with an audio only Stream. Must
        /// be a .jpg or .png file. If given, this image will be used as the cover-art for the
        /// audio only output. Ideally, it should be formatted for an iPhone screen for two reasons.
        /// The iPhone does not resize the image, it crops a centered image on the top/bottom
        /// and left/right. Additionally, this image file gets saved bit-for-bit into every 10-second
        /// segment file, so will increase bandwidth by {image file size} * {segment count} *
        /// {user count.}.
        /// </summary>
        public InputLocation AudioOnlyImage
        {
            get { return this._audioOnlyImage; }
            set { this._audioOnlyImage = value; }
        }

        // Check to see if AudioOnlyImage property is set
        internal bool IsSetAudioOnlyImage()
        {
            return this._audioOnlyImage != null;
        }

        /// <summary>
        /// Gets and sets the property AudioTrackType. Four types of audio-only tracks are supported:Audio-Only
        /// Variant StreamThe client can play back this audio-only stream instead of video in
        /// low-bandwidth scenarios. Represented as an EXT-X-STREAM-INF in the HLS manifest.Alternate
        /// Audio, Auto Select, DefaultAlternate rendition that the client should try to play
        /// back by default. Represented as an EXT-X-MEDIA in the HLS manifest with DEFAULT=YES,
        /// AUTOSELECT=YESAlternate Audio, Auto Select, Not DefaultAlternate rendition that the
        /// client may try to play back by default. Represented as an EXT-X-MEDIA in the HLS manifest
        /// with DEFAULT=NO, AUTOSELECT=YESAlternate Audio, not Auto SelectAlternate rendition
        /// that the client will not try to play back by default. Represented as an EXT-X-MEDIA
        /// in the HLS manifest with DEFAULT=NO, AUTOSELECT=NO
        /// </summary>
        public AudioOnlyHlsTrackType AudioTrackType
        {
            get { return this._audioTrackType; }
            set { this._audioTrackType = value; }
        }

        // Check to see if AudioTrackType property is set
        internal bool IsSetAudioTrackType()
        {
            return this._audioTrackType != null;
        }

    }
}