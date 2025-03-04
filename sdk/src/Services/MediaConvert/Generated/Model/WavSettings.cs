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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Codec to the value WAV.
    /// </summary>
    public partial class WavSettings
    {
        private int? _bitDepth;
        private int? _channels;
        private WavFormat _format;
        private int? _sampleRate;

        /// <summary>
        /// Gets and sets the property BitDepth. Specify Bit depth, in bits per sample, to choose
        /// the encoding quality for this audio track.
        /// </summary>
        [AWSProperty(Min=16, Max=24)]
        public int? BitDepth
        {
            get { return this._bitDepth; }
            set { this._bitDepth = value; }
        }

        // Check to see if BitDepth property is set
        internal bool IsSetBitDepth()
        {
            return this._bitDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Channels. Specify the number of channels in this output
        /// audio track. Valid values are 1 and even numbers up to 64. For example, 1, 2, 4, 6,
        /// and so on, up to 64.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Format. Specify the file format for your wave audio output.
        /// To use a RIFF wave format: Keep the default value, RIFF. If your output audio is likely
        /// to exceed 4GB in file size, or if you otherwise need the extended support of the RF64
        /// format: Choose RF64. If your player only supports the extensible wave format: Choose
        /// Extensible.
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
        [AWSProperty(Min=8000, Max=192000)]
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

    }
}