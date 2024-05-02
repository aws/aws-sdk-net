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
    /// Required when you set Codec, under AudioDescriptions>CodecSettings, to the value MP3.
    /// </summary>
    public partial class Mp3Settings
    {
        private int? _bitrate;
        private int? _channels;
        private Mp3RateControlMode _rateControlMode;
        private int? _sampleRate;
        private int? _vbrQuality;

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// </summary>
        [AWSProperty(Min=16000, Max=320000)]
        public int? Bitrate
        {
            get { return this._bitrate; }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Channels. Specify the number of channels in this output
        /// audio track. Choosing Mono gives you 1 output channel; choosing Stereo gives you 2.
        /// In the API, valid values are 1 and 2.
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
        /// Gets and sets the property RateControlMode. Specify whether the service encodes this
        /// MP3 audio output with a constant bitrate (CBR) or a variable bitrate (VBR).
        /// </summary>
        public Mp3RateControlMode RateControlMode
        {
            get { return this._rateControlMode; }
            set { this._rateControlMode = value; }
        }

        // Check to see if RateControlMode property is set
        internal bool IsSetRateControlMode()
        {
            return this._rateControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property SampleRate. Sample rate in Hz.
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
        /// Gets and sets the property VbrQuality. Required when you set Bitrate control mode
        /// to VBR. Specify the audio quality of this MP3 output from 0 (highest quality) to 9
        /// (lowest quality).
        /// </summary>
        [AWSProperty(Min=0, Max=9)]
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