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
    /// Audio Only Hls Settings
    /// </summary>
    public partial class AudioOnlyHlsSettings
    {
        /// <summary>
        /// Gets and sets the property AudioGroupId. Specifies the group to which the audio Rendition
        /// belongs.
        /// </summary>
        public string AudioGroupId { get; set; }

        /// <summary>
        /// Checks to see if the AudioGroupId property is set.
        /// </summary>
        internal bool IsSetAudioGroupId() => this.AudioGroupId != null;

        /// <summary>
        /// Gets and sets the property AudioOnlyImage. Optional. Specifies the .jpg or .png image
        /// to use as the cover art for an audio-only output. We recommend a low bit-size file
        /// because the image increases the output audio bandwidth. The image is attached to the
        /// audio as an ID3 tag, frame type APIC, picture type 0x10, as per the "ID3 tag version
        /// 2.4.0 - Native Frames" standard.
        /// </summary>
        public InputLocation AudioOnlyImage { get; set; }

        /// <summary>
        /// Checks to see if the AudioOnlyImage property is set.
        /// </summary>
        internal bool IsSetAudioOnlyImage() => this.AudioOnlyImage != null;

        /// <summary>
        /// Gets and sets the property AudioTrackType. Four types of audio-only tracks are supported:
        /// Audio-Only Variant Stream The client can play back this audio-only stream instead
        /// of video in low-bandwidth scenarios. Represented as an EXT-X-STREAM-INF in the HLS
        /// manifest. Alternate Audio, Auto Select, Default Alternate rendition that the client
        /// should try to play back by default. Represented as an EXT-X-MEDIA in the HLS manifest
        /// with DEFAULT=YES, AUTOSELECT=YES Alternate Audio, Auto Select, Not Default Alternate
        /// rendition that the client may try to play back by default. Represented as an EXT-X-MEDIA
        /// in the HLS manifest with DEFAULT=NO, AUTOSELECT=YES Alternate Audio, not Auto Select
        /// Alternate rendition that the client will not try to play back by default. Represented
        /// as an EXT-X-MEDIA in the HLS manifest with DEFAULT=NO, AUTOSELECT=NO
        /// </summary>
        public AudioOnlyHlsTrackType AudioTrackType { get; set; }

        /// <summary>
        /// Checks to see if the AudioTrackType property is set.
        /// </summary>
        internal bool IsSetAudioTrackType() => this.AudioTrackType != null;

        /// <summary>
        /// Gets and sets the property SegmentType. Specifies the segment type.
        /// </summary>
        public AudioOnlyHlsSegmentType SegmentType { get; set; }

        /// <summary>
        /// Checks to see if the SegmentType property is set.
        /// </summary>
        internal bool IsSetSegmentType() => this.SegmentType != null;
    }
}
