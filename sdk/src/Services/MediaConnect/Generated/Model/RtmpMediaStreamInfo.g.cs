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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Information about a single audio or video stream that is part of an RTMP source. This
    /// includes details about the stream type, codec, resolution, frame rate, audio channels,
    /// and sample rate.
    /// </summary>
    public partial class RtmpMediaStreamInfo
    {
        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The number of audio channels in the stream. Used when the <c>streamType</c> is <c>AUDIO</c>.
        /// </para>
        /// </summary>
        public int? Channels { get; set; }

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels.HasValue;

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// The codec used for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color signaling of the video stream. Used when the <c>streamType</c> is <c>VIDEO</c>.
        /// </para>
        /// </summary>
        public ColorInformation Color { get; set; }

        /// <summary>
        /// Checks to see if the Color property is set.
        /// </summary>
        internal bool IsSetColor() => this.Color != null;

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        /// The number of video frames displayed per second. Used when the <c>streamType</c> is
        /// <c>VIDEO</c>.
        /// </para>
        /// </summary>
        public string FrameRate { get; set; }

        /// <summary>
        /// Checks to see if the FrameRate property is set.
        /// </summary>
        internal bool IsSetFrameRate() => this.FrameRate != null;

        /// <summary>
        /// Gets and sets the property FrameResolution. 
        /// <para>
        /// The width and height dimensions of the video frame in pixels. Used when the <c>streamType</c>
        /// is <c>VIDEO</c>.
        /// </para>
        /// </summary>
        public FrameResolution FrameResolution { get; set; }

        /// <summary>
        /// Checks to see if the FrameResolution property is set.
        /// </summary>
        internal bool IsSetFrameResolution() => this.FrameResolution != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language of the audio stream. Used when the <c>streamType</c> is <c>AUDIO</c>.
        /// </para>
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The number of audio samples captured per second. Used when the <c>streamType</c> is
        /// <c>AUDIO</c>.
        /// </para>
        /// </summary>
        public int? SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate.HasValue;

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The sample bit size used by the audio stream. Used when the <c>streamType</c> is <c>AUDIO</c>.
        /// </para>
        /// </summary>
        public int? SampleSize { get; set; }

        /// <summary>
        /// Checks to see if the SampleSize property is set.
        /// </summary>
        internal bool IsSetSampleSize() => this.SampleSize.HasValue;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The method used to display video frames. Used when the <c>streamType</c> is <c>VIDEO</c>.
        /// </para>
        /// </summary>
        public ScanMode ScanMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// A unique identifier for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId.HasValue;

        /// <summary>
        /// Gets and sets the property StreamType. 
        /// <para>
        /// The type of stream (for example, <c>VIDEO</c> or <c>AUDIO</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceMediaStreamType StreamType { get; set; }

        /// <summary>
        /// Checks to see if the StreamType property is set.
        /// </summary>
        internal bool IsSetStreamType() => this.StreamType != null;
    }
}
