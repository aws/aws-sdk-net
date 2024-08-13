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
    /// Required when you set Codec, under AudioDescriptions>CodecSettings, to the value Vorbis.
    /// </summary>
    public partial class VorbisSettings
    {
        private int? _channels;
        private int? _sampleRate;
        private int? _vbrQuality;

        /// <summary>
        /// Gets and sets the property Channels. Optional. Specify the number of channels in this
        /// output audio track. Choosing Mono on the console gives you 1 output channel; choosing
        /// Stereo gives you 2. In the API, valid values are 1 and 2. The default value is 2.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
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
        /// Gets and sets the property SampleRate. Optional. Specify the audio sample rate in
        /// Hz. Valid values are 22050, 32000, 44100, and 48000. The default value is 48000.
        /// </summary>
        [AWSProperty(Min=22050, Max=48000)]
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
        /// Gets and sets the property VbrQuality. Optional. Specify the variable audio quality
        /// of this Vorbis output from -1 (lowest quality, ~45 kbit/s) to 10 (highest quality,
        /// ~500 kbit/s). The default value is 4 (~128 kbit/s). Values 5 and 6 are approximately
        /// 160 and 192 kbit/s, respectively.
        /// </summary>
        [AWSProperty(Min=-1, Max=10)]
        public int? VbrQuality
        {
            get { return this._vbrQuality; }
            set { this._vbrQuality = value; }
        }

        // Check to see if VbrQuality property is set
        internal bool IsSetVbrQuality()
        {
            return this._vbrQuality.HasValue; 
        }

    }
}