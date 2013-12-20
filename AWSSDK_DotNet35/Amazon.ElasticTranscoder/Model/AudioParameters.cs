/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>Parameters required for transcoding audio.</para>
    /// </summary>
    public class AudioParameters
    {
        
        private string codec;
        private string sampleRate;
        private string bitRate;
        private string channels;
        private AudioCodecOptions codecOptions;


        /// <summary>
        /// The audio codec for the output file. Valid values include <c>aac</c>, <c>mp3</c>, and <c>vorbis</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^AAC$)|(^vorbis$)|(^mp3$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Codec
        {
            get { return this.codec; }
            set { this.codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this.codec != null;
        }

        /// <summary>
        /// The sample rate of the audio stream in the output file, in Hertz. Valid values include: <c>auto</c>, <c>22050</c>, <c>32000</c>,
        /// <c>44100</c>, <c>48000</c>, <c>96000</c> If you specify <c>auto</c>, Elastic Transcoder automatically detects the sample rate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^22050$)|(^32000$)|(^44100$)|(^48000$)|(^96000$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SampleRate
        {
            get { return this.sampleRate; }
            set { this.sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this.sampleRate != null;
        }

        /// <summary>
        /// The bit rate of the audio stream in the output file, in kilobits/second. Enter an integer between 64 and 320, inclusive.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{1,3}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string BitRate
        {
            get { return this.bitRate; }
            set { this.bitRate = value; }
        }

        // Check to see if BitRate property is set
        internal bool IsSetBitRate()
        {
            return this.bitRate != null;
        }

        /// <summary>
        /// The number of audio channels in the output file. Valid values include: <c>auto</c>, <c>0</c>, <c>1</c>, <c>2</c> If you specify <c>auto</c>,
        /// Elastic Transcoder automatically detects the number of channels in the input file.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^0$)|(^1$)|(^2$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Channels
        {
            get { return this.channels; }
            set { this.channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this.channels != null;
        }

        /// <summary>
        /// If you specified <c>AAC</c> for <c>Audio:Codec</c>, this is the <c>AAC</c> compression profile to use. Valid values include: <c>auto</c>,
        /// <c>AAC-LC</c>, <c>HE-AAC</c>, <c>HE-AACv2</c> If you specify <c>auto</c>, Elastic Transcoder chooses a profile based on the bit rate of the
        /// output file.
        ///  
        /// </summary>
        public AudioCodecOptions CodecOptions
        {
            get { return this.codecOptions; }
            set { this.codecOptions = value; }
        }

        // Check to see if CodecOptions property is set
        internal bool IsSetCodecOptions()
        {
            return this.codecOptions != null;
        }
    }
}
