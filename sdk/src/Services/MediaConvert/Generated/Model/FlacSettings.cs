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
    /// Required when you set Codec, under AudioDescriptions>CodecSettings, to the value FLAC.
    /// </summary>
    public partial class FlacSettings
    {
        private int? _bitDepth;
        private int? _channels;
        private int? _sampleRate;

        /// <summary>
        /// Gets and sets the property BitDepth. Specify Bit depth (BitDepth), in bits per sample,
        /// to choose the encoding quality for this audio track.
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
        /// audio track. Choosing Mono on the console gives you 1 output channel; choosing Stereo
        /// gives you 2. In the API, valid values are between 1 and 8.
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
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
        /// Gets and sets the property SampleRate. Sample rate in Hz.
        /// </summary>
        [AWSProperty(Min=22050, Max=192000)]
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