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
    /// The metadata of an elementary transport stream.
    /// </summary>
    public partial class TransportStream
    {
        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        ///  The number of channels in the audio stream.
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
        ///  The codec used by the stream.
        /// </para>
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Checks to see if the Codec property is set.
        /// </summary>
        internal bool IsSetCodec() => this.Codec != null;

        /// <summary>
        /// Gets and sets the property FrameRate. 
        /// <para>
        ///  The frame rate used by the video stream.
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
        /// The frame resolution used by the video stream. 
        /// </para>
        /// </summary>
        public FrameResolution FrameResolution { get; set; }

        /// <summary>
        /// Checks to see if the FrameResolution property is set.
        /// </summary>
        internal bool IsSetFrameResolution() => this.FrameResolution != null;

        /// <summary>
        /// Gets and sets the property Pid. 
        /// <para>
        ///  The Packet ID (PID) as it is reported in the Program Map Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Pid { get; set; }

        /// <summary>
        /// Checks to see if the Pid property is set.
        /// </summary>
        internal bool IsSetPid() => this.Pid.HasValue;

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        ///  The sample rate used by the audio stream.
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
        ///  The sample bit size used by the audio stream.
        /// </para>
        /// </summary>
        public int? SampleSize { get; set; }

        /// <summary>
        /// Checks to see if the SampleSize property is set.
        /// </summary>
        internal bool IsSetSampleSize() => this.SampleSize.HasValue;

        /// <summary>
        /// Gets and sets the property StreamType. 
        /// <para>
        ///  The Stream Type as it is reported in the Program Map Table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamType { get; set; }

        /// <summary>
        /// Checks to see if the StreamType property is set.
        /// </summary>
        internal bool IsSetStreamType() => this.StreamType != null;
    }
}
