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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set (Codec) under (AudioDescriptions)>(CodecSettings) to the value
    /// WAV.
    /// </summary>
    public partial class WavSettings
    {
        private int? _bitDepth;
        private int? _channels;
        private WavFormat _format;
        private int? _sampleRate;

        /// <summary>
        /// Gets and sets the property BitDepth. Specify Bit depth (BitDepth), in bits per sample,
        /// to choose the encoding quality for this audio track.
        /// </summary>
        public int BitDepth
        {
            get { return this._bitDepth.GetValueOrDefault(); }
            set { this._bitDepth = value; }
        }

        // Check to see if BitDepth property is set
        internal bool IsSetBitDepth()
        {
            return this._bitDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Channels. Set Channels to specify the number of channels
        /// in this output audio track. With WAV, valid values 1, 2, 4, and 8. In the console,
        /// these values are Mono, Stereo, 4-Channel, and 8-Channel, respectively.
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
        /// Gets and sets the property Format.
        /// </summary>
        public WavFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. Sample rate in Hz.
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

    }
}