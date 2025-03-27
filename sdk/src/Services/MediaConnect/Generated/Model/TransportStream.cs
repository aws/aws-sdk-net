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
    /// The metadata of an elementary transport stream.
    /// </summary>
    public partial class TransportStream
    {
        private int? _channels;
        private string _codec;
        private string _frameRate;
        private FrameResolution _frameResolution;
        private int? _pid;
        private int? _sampleRate;
        private int? _sampleSize;
        private string _streamType;

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        ///  The number of channels in the audio stream.
        /// </para>
        /// </summary>
        public int? Channels
        {
            get { return this._channels; }
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
        ///  The codec used by the stream.
        /// </para>
        /// </summary>
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
        ///  The frame rate used by the video stream.
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
        /// The frame resolution used by the video stream. 
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
        /// Gets and sets the property Pid. 
        /// <para>
        ///  The Packet ID (PID) as it is reported in the Program Map Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Pid
        {
            get { return this._pid; }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        ///  The sample rate used by the audio stream.
        /// </para>
        /// </summary>
        public int? SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        ///  The sample bit size used by the audio stream.
        /// </para>
        /// </summary>
        public int? SampleSize
        {
            get { return this._sampleSize; }
            set { this._sampleSize = value; }
        }

        // Check to see if SampleSize property is set
        internal bool IsSetSampleSize()
        {
            return this._sampleSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamType. 
        /// <para>
        ///  The Stream Type as it is reported in the Program Map Table.
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