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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Detailed information about a single media stream that is part of an NDI® source.
    /// This includes details about the stream type, codec, resolution, frame rate, audio
    /// channels, and sample rate.
    /// </summary>
    public partial class NdiMediaStreamInfo
    {
        private int? _channels;
        private string _codec;
        private string _frameRate;
        private FrameResolution _frameResolution;
        private int? _sampleRate;
        private ScanMode _scanMode;
        private int? _streamId;
        private string _streamType;

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        ///  The number of audio channels in the stream. Used when the <c>streamType</c> is <c>Audio</c>.
        /// </para>
        /// </summary>
        public int Channels
        {
            get { return this._channels.GetValueOrDefault(); }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        ///  The codec used for the media stream. For NDI sources, use <c>speed-hq</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        ///  The number of video frames displayed per second. Used when the <c>streamType</c>
        /// is <c>Video</c>. 
        /// </para>
        /// </summary>
        public string FrameRate
        {
            get { return this._frameRate; }
            set { this._frameRate = value; }
        }

        // Check to see if FrameRate property is set
        internal bool IsSetFrameRate()
        {
            return this._frameRate != null;
        }

        /// <summary>
        /// Gets and sets the property FrameResolution. 
        /// <para>
        ///  The width and height dimensions of the video frame in pixels. Used when the <c>streamType</c>
        /// is <c>Video</c>. 
        /// </para>
        /// </summary>
        public FrameResolution FrameResolution
        {
            get { return this._frameResolution; }
            set { this._frameResolution = value; }
        }

        // Check to see if FrameResolution property is set
        internal bool IsSetFrameResolution()
        {
            return this._frameResolution != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        ///  The number of audio samples captured per second, measured in kilohertz (kHz). Used
        /// when the <c>streamType</c> is <c>Audio</c>.
        /// </para>
        /// </summary>
        public int SampleRate
        {
            get { return this._sampleRate.GetValueOrDefault(); }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        ///  The method used to display video frames. Used when the <c>streamType</c> is <c>Video</c>.
        /// </para>
        /// </summary>
        public ScanMode ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        ///  A unique identifier for the media stream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int StreamId
        {
            get { return this._streamId.GetValueOrDefault(); }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamType. 
        /// <para>
        ///  The type of media stream (for example, <c>Video</c> or <c>Audio</c>). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StreamType
        {
            get { return this._streamType; }
            set { this._streamType = value; }
        }

        // Check to see if StreamType property is set
        internal bool IsSetStreamType()
        {
            return this._streamType != null;
        }

    }
}