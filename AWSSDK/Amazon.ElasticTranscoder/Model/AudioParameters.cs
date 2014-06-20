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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Parameters required for transcoding audio.
    /// </summary>
    public partial class AudioParameters
    {
        private string _bitRate;
        private string _channels;
        private string _codec;
        private AudioCodecOptions _codecOptions;
        private string _sampleRate;


        /// <summary>
        /// Gets and sets the property BitRate. 
        /// <para>
        /// The bit rate of the audio stream in the output file, in kilobits/second. Enter an
        /// integer            between 64 and 320, inclusive.
        /// </para>
        /// </summary>
        public string BitRate
        {
            get { return this._bitRate; }
            set { this._bitRate = value; }
        }


        /// <summary>
        /// Sets the BitRate property
        /// </summary>
        /// <param name="bitRate">The value to set for the BitRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithBitRate(string bitRate)
        {
            this._bitRate = bitRate;
            return this;
        }

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this._bitRate != null;
        }


        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The number of audio channels in the output file. Valid values include:
        /// </para>
        ///         
        /// <para>
        /// <code>auto</code>, <code>0</code>, <code>1</code>, <code>2</code>
        /// </para>
        ///         
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder automatically detects the number
        /// of channels in            the input file.
        /// </para>
        /// </summary>
        public string Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }


        /// <summary>
        /// Sets the Channels property
        /// </summary>
        /// <param name="channels">The value to set for the Channels property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithChannels(string channels)
        {
            this._channels = channels;
            return this;
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null;
        }


        /// <summary>
        /// Gets and sets the property Codec. 
        /// <para>
        /// The audio codec for the output file. Valid values include <code>aac</code>,      
        ///       <code>mp3</code>, and <code>vorbis</code>.
        /// </para>
        /// </summary>
        public string Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }


        /// <summary>
        /// Sets the Codec property
        /// </summary>
        /// <param name="codec">The value to set for the Codec property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithCodec(string codec)
        {
            this._codec = codec;
            return this;
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }


        /// <summary>
        /// Gets and sets the property CodecOptions. 
        /// <para>
        /// If you specified <code>AAC</code> for <code>Audio:Codec</code>, this is the <code>AAC</code>
        ///             compression profile to use. Valid values include:
        /// </para>
        ///         
        /// <para>
        /// <code>auto</code>, <code>AAC-LC</code>, <code>HE-AAC</code>, <code>HE-AACv2</code>
        /// </para>
        ///         
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder chooses a profile based on the
        /// bit rate of the output file.
        /// </para>
        /// </summary>
        public AudioCodecOptions CodecOptions
        {
            get { return this._codecOptions; }
            set { this._codecOptions = value; }
        }


        /// <summary>
        /// Sets the CodecOptions property
        /// </summary>
        /// <param name="codecOptions">The value to set for the CodecOptions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithCodecOptions(AudioCodecOptions codecOptions)
        {
            this._codecOptions = codecOptions;
            return this;
        }

        // Check to see if CodecOptions property is set
        internal bool IsSetCodecOptions()
        {
            return this._codecOptions != null;
        }


        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The sample rate of the audio stream in the output file, in Hertz. Valid values   
        ///         include:
        /// </para>
        ///         
        /// <para>
        /// <code>auto</code>, <code>22050</code>, <code>32000</code>, <code>44100</code>,   
        ///             <code>48000</code>, <code>96000</code>
        /// </para>
        ///         
        /// <para>
        /// If you specify <code>auto</code>, Elastic Transcoder automatically detects the sample
        /// rate.
        /// </para>
        /// </summary>
        public string SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }


        /// <summary>
        /// Sets the SampleRate property
        /// </summary>
        /// <param name="sampleRate">The value to set for the SampleRate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AudioParameters WithSampleRate(string sampleRate)
        {
            this._sampleRate = sampleRate;
            return this;
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate != null;
        }

    }
}