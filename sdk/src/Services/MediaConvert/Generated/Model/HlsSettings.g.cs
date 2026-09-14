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
    /// Settings for HLS output groups
    /// </summary>
    public partial class HlsSettings
    {
        /// <summary>
        /// Gets and sets the property AudioGroupId. Specifies the group to which the audio rendition
        /// belongs.
        /// </summary>
        public string AudioGroupId { get; set; }

        /// <summary>
        /// Checks to see if the AudioGroupId property is set.
        /// </summary>
        internal bool IsSetAudioGroupId() => this.AudioGroupId != null;

        /// <summary>
        /// Gets and sets the property AudioOnlyContainer. Use this setting only in audio-only
        /// outputs. Choose MPEG-2 Transport Stream (M2TS) to create a file in an MPEG2-TS container.
        /// Keep the default value Automatic to create an audio-only file in a raw container.
        /// Regardless of the value that you specify here, if this output has video, the service
        /// will place the output into an MPEG2-TS container.
        /// </summary>
        public HlsAudioOnlyContainer AudioOnlyContainer { get; set; }

        /// <summary>
        /// Checks to see if the AudioOnlyContainer property is set.
        /// </summary>
        internal bool IsSetAudioOnlyContainer() => this.AudioOnlyContainer != null;

        /// <summary>
        /// Gets and sets the property AudioRenditionSets. List all the audio groups that are
        /// used with the video output stream. Input all the audio GROUP-IDs that are associated
        /// to the video, separate by ','.
        /// </summary>
        public string AudioRenditionSets { get; set; }

        /// <summary>
        /// Checks to see if the AudioRenditionSets property is set.
        /// </summary>
        internal bool IsSetAudioRenditionSets() => this.AudioRenditionSets != null;

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
        public HlsAudioTrackType AudioTrackType { get; set; }

        /// <summary>
        /// Checks to see if the AudioTrackType property is set.
        /// </summary>
        internal bool IsSetAudioTrackType() => this.AudioTrackType != null;

        /// <summary>
        /// Gets and sets the property DescriptiveVideoServiceFlag. Specify whether to flag this
        /// audio track as descriptive video service (DVS) in your HLS parent manifest. When you
        /// choose Flag, MediaConvert includes the parameter CHARACTERISTICS="public.accessibility.describes-video"
        /// in the EXT-X-MEDIA entry for this track. When you keep the default choice, Don't flag,
        /// MediaConvert leaves this parameter out. The DVS flag can help with accessibility on
        /// Apple devices. For more information, see the Apple documentation.
        /// </summary>
        public HlsDescriptiveVideoServiceFlag DescriptiveVideoServiceFlag { get; set; }

        /// <summary>
        /// Checks to see if the DescriptiveVideoServiceFlag property is set.
        /// </summary>
        internal bool IsSetDescriptiveVideoServiceFlag() => this.DescriptiveVideoServiceFlag != null;

        /// <summary>
        /// Gets and sets the property IFrameOnlyManifest. Generate a variant manifest that lists
        /// only the I-frames for this rendition. You might use this manifest as part of a workflow
        /// that creates preview functions for your video. MediaConvert adds both the I-frame
        /// only variant manifest and the regular variant manifest to the multivariant manifest.
        /// To have MediaConvert write a variant manifest that references I-frames from your output
        /// content using EXT-X-BYTERANGE tags: Choose Include. To have MediaConvert output I-frames
        /// as single frame TS files and a corresponding variant manifest that references them:
        /// Choose Include as TS. When you don't need the I-frame only variant manifest: Keep
        /// the default value, Exclude.
        /// </summary>
        public HlsIFrameOnlyManifest IFrameOnlyManifest { get; set; }

        /// <summary>
        /// Checks to see if the IFrameOnlyManifest property is set.
        /// </summary>
        internal bool IsSetIFrameOnlyManifest() => this.IFrameOnlyManifest != null;

        /// <summary>
        /// Gets and sets the property SegmentModifier. Use this setting to add an identifying
        /// string to the filename of each segment. The service adds this string between the name
        /// modifier and segment index number. You can use format identifiers in the string. For
        /// more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/using-variables-in-your-job-settings.html
        /// </summary>
        public string SegmentModifier { get; set; }

        /// <summary>
        /// Checks to see if the SegmentModifier property is set.
        /// </summary>
        internal bool IsSetSegmentModifier() => this.SegmentModifier != null;
    }
}
